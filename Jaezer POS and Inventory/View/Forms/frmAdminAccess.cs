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


namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmAdminAccess : Form
    {
        private frmCancelOrder frm;
        public frmAdminAccess(frmCancelOrder _frm)
        {
            InitializeComponent();
            frm = _frm;
        }

        private void UserAuthentication()
        {
            var obj = new User();
            var model = new UserModel();
            obj.UserName = txtUsername.Text;
            obj.Password = txtPassword.Text;
            var rules = new UserAuthValidator();
            var result = rules.Validate(obj);
            string msg = null;
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                    msg += $"{item.ErrorMessage} \n";
                MessageBox.Show(msg);
                return;
            }
            var encryptPass = new PasswordEncryptModel(obj.Password);
            obj.Password = Convert.ToBase64String(encryptPass.EncryptStringToBytes_Aes());
            obj = model.IsAccountMatch(obj.UserName, obj.Password);

            if (obj.UserName == null)
            {
                MessageBox.Show("Username / Passwords is incorrect.");
                return;
            }

            if (!obj.Status)
            {
                MessageBox.Show("This Account is  DEACTIVATED. \n Please refer to the Administrator for Account Reactivation.");
                return;
            }
            if(obj.UserType == "Admin")
            {
                MessageBox.Show("Acces Granted");
                frm.CancelOrder();
                
            }

            this.Hide();
           
        }

        private void frmAdminAccess_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
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
    }
}
