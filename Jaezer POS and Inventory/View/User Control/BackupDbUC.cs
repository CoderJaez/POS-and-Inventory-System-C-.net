using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.Model;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class BackupDbUC : UserControl
    {
        public BackupDbUC()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    button1.Text = "Processing...";
                    button1.Enabled = false;
                    var db = new DBConnection();
                    var result = await db.BackupDatabaseAsync(fbd.SelectedPath);
                    if(result)
                    {
                        MessageBox.Show("Backup successfull");
                        button1.Text = "Back up Databse";
                        button1.Enabled = true;
                    }
                    else
                    {
                        button1.Text = "Back up Databse";
                        button1.Enabled = true;
                    }
                   
                }
            }
        }
    }
}
