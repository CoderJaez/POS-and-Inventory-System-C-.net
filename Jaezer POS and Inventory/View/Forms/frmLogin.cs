using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.Model;
using FluentValidation.Results;
using System.IO;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmLogin : Form
    {
        User obj = new User();
        
        string DefaultPass = "1234";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = txtPassword.UseSystemPasswordChar ? false : true;
            txtPassword.PasswordChar = txtPassword.UseSystemPasswordChar ? (char)7:(char)0;
            btnTogglePass.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.icons8_closed_eye_16 : Properties.Resources.icons8_eye_16;
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void UserAuthentication()
        {
            UserModel model = new UserModel();
            obj.UserName = txtUsername.Text;
            obj.Password = txtPassword.Text;
            var rules = new UserAuthValidator();
            var result = rules.Validate(obj);
            string msg = null;
            if(!result.IsValid)
            {
                foreach (var item in result.Errors)
                    msg += $"{item.ErrorMessage} \n";
                MessageBox.Show(msg);
                return;
            }
            var encryptPass = new PasswordEncryptModel(obj.Password);
            obj.Password = Convert.ToBase64String(encryptPass.EncryptStringToBytes_Aes());
            obj = model.IsAccountMatch(obj.UserName, obj.Password);

            if(obj.UserName == null)
            {
                MessageBox.Show("Username / Passwords is incorrect.");
                return;
            } 

            if(!obj.Status)
            {
                MessageBox.Show("Your Account is  DEACTIVATED. \n Please refer to the Administrator for Account Reactivation.");
                return; 
            }

            MessageBox.Show("Succesfully log in");
            this.Hide();
            this.ShowInTaskbar = false;
            if (txtPassword.Text == DefaultPass)
            {

                frmChangePass frm = new frmChangePass(obj,true);
                frm.Show();
            } else
            {
                Properties.Settings.Default.UserID = obj.UserID;
                Properties.Settings.Default.Save();
                if (obj.UserType == "Admin")
                {
                   
                    frmMain main = new frmMain(obj);
                    main.Show();
                }
                else
                {
                    frmPOS pos = new frmPOS(obj);
                    pos.Show();
                }
            }
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserAuthentication();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                UserAuthentication();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UserAuthentication();
        }

        private void GetCompanyProfile()
        {
            var profile = new CompanyProfileModel().getBusinessProfile();
            try
            {
                lblProfile.Text = profile.BusinessName;
                byte[] img = profile.logo;
                MemoryStream ms = new MemoryStream(img);
                pbLogo.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            GetCompanyProfile();
        }
    }
}
