using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using FluentValidation;
using System.IO;
namespace Jaezer_POS_and_Inventory.Model
{
    public class DBConnection
    {
        private string user = Properties.Settings.Default.user;
        private string pass = Properties.Settings.Default.password;
        private string server = Properties.Settings.Default.server;
        private string port = Properties.Settings.Default.port;
        private string db = Properties.Settings.Default.database;

        protected MySqlTransaction tr;
        protected MySqlConnection con;
        protected MySqlCommand cmd;
        protected string connection = null;
        protected string query = null;
        protected string where = null;
        public string AppName = Properties.Settings.Default.appname;
        public string ConnString { get { return $"server= {server};user={user};password={pass};database={db};port={port};Convert Zero Datetime=True"; } }

        public bool TestConnection(Database obj)
        {
           string _ConnString = $"server= {obj.Server};user={obj.Username};password={obj.Password};port={obj.Port};database = {obj.DatabaseName};Convert Zero Datetime=True;";
            try
            {
                using (con = new MySqlConnection(_ConnString))
                {
                    con.Open();
                    //MessageBox.Show("Mysql Server Connection Successfull");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public bool SaveDatabaseConfig(Database obj)
        {
            try
            {
                Properties.Settings.Default.user = obj.Username;
                Properties.Settings.Default.password = obj.Password;
                Properties.Settings.Default.server = obj.Server;
                Properties.Settings.Default.port = obj.Port;
                Properties.Settings.Default.isDBSetup = true;
                Properties.Settings.Default.database = obj.DatabaseName;
                Properties.Settings.Default.Save();
                if (obj.ImportDB)
                {
                    string connString = $"server={ obj.Server}; user={obj.Username};password={obj.Password};port={obj.Port};";
                    using (con = new MySqlConnection(connString))
                    {
                        con.Open();
                        using (cmd = new MySqlCommand($"CREATE DATABASE {Properties.Settings.Default.database}", con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                       
                    }

                    using (con = new MySqlConnection(ConnString))
                    {
                        MySqlScript script = new MySqlScript(con, File.ReadAllText($"{Directory.GetCurrentDirectory()}/posdb.sql"));
                        script.Execute();
                    }
                }
                MessageBox.Show("Database Configuration Successfull");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
           
        }


        public async Task<bool> BackupDatabaseAsync(string path)
        {
            var result = await Task.Run(() => MakeBackup(path));
            return result;
        }

        private bool MakeBackup(string path)
        {
            try
            {
                using ( con = new MySqlConnection(ConnString))
                {
                    using ( cmd = new MySqlCommand())
                    {

                        using (var mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = con;
                            con.Open();
                            string filename = $"PosInventoryDB_{DateTime.Now.ToString("MMddyyyyHHmmss")}.sql";
                            mb.ExportToFile($@"{path}/{filename}");
                            
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Back up database failed. \nContact the administrator\n{ex.Message}");
                return false;
            }
        }
    
    }


    public class Database
    {
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string DatabaseName { get; set; }
        public bool ImportDB { get; set; }

    }


    public class DatabaseValidator:AbstractValidator<Database>
    {
        public DatabaseValidator()
        {
            RuleFor(server => server.Server)
                .NotEmpty();
            RuleFor(uname => uname.Username)
                .NotEmpty();
            RuleFor(port => port.Port)
                .NotEmpty();
        }
    }
}
