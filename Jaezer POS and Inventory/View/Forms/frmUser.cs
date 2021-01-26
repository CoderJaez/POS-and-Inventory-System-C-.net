using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using Jaezer_POS_and_Inventory.View.User_Control;
using Jaezer_POS_and_Inventory.Model;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmUser : Form
    {
        User obj = new User();
        UserModel model = new UserModel();
        UserUC uc;
        public frmUser(UserUC _uc)
        {
            InitializeComponent();
            uc = _uc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }


        private void SaveUser()
        {
            obj.UserName = txtUserName.Text;
            obj.Fullname = txtFullName.Text;
            obj.UserType = cbUserType.Text;
            var rules = new UserValidator();
            var result = rules.Validate(obj);
           
            string msg = null;
            if(!result.IsValid)
            {
                foreach (var row in result.Errors)
                    msg += $"{row.ErrorMessage} \n";

                MessageBox.Show(msg, model.AppName);
                return;
            }
            var encryptPass = new PasswordEncryptModel("1234");
            obj.Password = Convert.ToBase64String(encryptPass.EncryptStringToBytes_Aes());
            if(model.Insert(obj))
            {
                MessageBox.Show("User Account is now Registered", model.AppName);
                clear();
            }
        }

        private void clear()
        {
            txtFullName.Text = "";
            txtUserName.Text = "";
            cbUserType.Text = "";
            txtUserName.Focus();
        }

        private void frmUser_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
