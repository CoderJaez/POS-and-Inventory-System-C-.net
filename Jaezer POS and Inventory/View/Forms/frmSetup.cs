using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using Jaezer_POS_and_Inventory.Model;
using System.IO;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmSetup : Form
    {
        Database obj = new Database();
        public frmSetup()
        {
            InitializeComponent();
            tbSetup.SelectTab(0);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbSetup.SelectTab(1);
        }

        private void btnNextToAcc_Click(object sender, EventArgs e)
        {
            tbSetup.SelectTab(2);
        }

        private void btnNextToDB_Click(object sender, EventArgs e)
        {
            tbSetup.SelectTab(1);
        }

    

        private void btnNextToEst_Click(object sender, EventArgs e)
        {
            tbSetup.SelectTab(3);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png) | *.jpg; *.jpeg; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgLogo.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveDBConfig();
        }

        private void SaveDBConfig()
        {
            setDB();
            var rules = new DatabaseValidator();
            var result = rules.Validate(obj);
            DBConnection model = new DBConnection();

            if (!result.IsValid)
            {
                string msg = null;
                foreach (var item in result.Errors)
                    msg += $"{item.ErrorMessage} \n";
                MessageBox.Show(msg);
                return;
            }
            MessageBox.Show("Dont close the Application while mporting database to this Computer", "Importing Database");
            if(model.SaveDatabaseConfig(obj))
            {
                btnNextToAcc.Enabled = true;

            }

        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            setDB();
            DBConnection model = new DBConnection();
            if (!model.TestConnection(obj))
            {
                MessageBox.Show("Not Connected to the Server");
                return;
            } else
            {
                MessageBox.Show("Mysql Server Connection Successfull");
            }
        }

        private void setDB()
        {
            obj.Server = txtSever.Text;
            obj.Username = txtServerUname.Text;
            obj.Port = txtPort.Text;
            obj.Password = txtServerPass.Text;
            obj.ImportDB = cbImportDB.Checked;
            obj.DatabaseName = txtDatabase.Text;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supObjt = new Supplier();
            MemoryStream mstream = new MemoryStream();
            CompanyProfileModel pmodel = new CompanyProfileModel();
            supObjt.BusinessName = txtCompanyName.Text;
            supObjt.ContactNo = txtContact.Text;
            supObjt.brgy.BrgyDesc = txtBrgy.Text;
            supObjt.StreetAddress = txtStreetAdd.Text;
            supObjt.citymun.CityMunDesc = txtCity.Text;
            supObjt.prov.ProvDesc = txtProv.Text;
            imgLogo.Image.Save(mstream, imgLogo.Image.RawFormat);
            supObjt.logo = mstream.GetBuffer();
            mstream.Close();
            if (pmodel.update(supObjt))
            {
                MessageBox.Show("Setup is now complete.");
                Properties.Settings.Default.isBNameSetup = true;
                Properties.Settings.Default.Save();
                btnFinishSetup.Enabled = true;
            }
          
        }

        private void btnFinishSetup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Close and ReOpen the Application to take Effect");
            this.Close();
        }
    }
}
