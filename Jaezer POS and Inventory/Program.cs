using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.View.Forms;
using Jaezer_POS_and_Inventory.Model;
namespace Jaezer_POS_and_Inventory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Properties.Settings.Default.user = "";
            //Properties.Settings.Default.password = "";
            //Properties.Settings.Default.server = "";
            //Properties.Settings.Default.port = "";
            //Properties.Settings.Default.database = "posinv_db_v2";
            ////Properties.Settings.Default.isDBSetup = false;
            ////Properties.Settings.Default.isBNameSetup = false;
            //Properties.Settings.Default.Save();
            var connDB = new Database()
            {
                DatabaseName = Properties.Settings.Default.database,
                Server = Properties.Settings.Default.server,
                Username = Properties.Settings.Default.user,
                Password = Properties.Settings.Default.password
            };
            var db = new DBConnection();
            //bool isDBSetup = Properties.Settings.Default.isDBSetup;
            //bool isNameSetup = Properties.Settings.Default.isBNameSetup;
            Application.SetCompatibleTextRenderingDefault(false);
            if(db.TestConnection(connDB))
            {
                var model = new SalesTransactionModel();
                if(model.EndSaleEvent())
                    Application.Run(new frmLogin());
            }
            else
                Application.Run(new frmSetup());



        }
    }
}
