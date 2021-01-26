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
using Jaezer_POS_and_Inventory.View.Forms;
using FluentValidation.Results;

namespace Jaezer_POS_and_Inventory.View
{
    public partial class frmChangePass : Form
    {
        User obj;
        bool isPasswordDefaault;
        UserModel model = new UserModel();
        public frmChangePass(User _obj, bool _isPassDefault)
        {
            InitializeComponent();
            obj = _obj;
            isPasswordDefaault = _isPassDefault;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            obj.Password = txtOldPass.Text;
            obj.NewPassword = txtNewPass.Text;
            obj.ConfirmNewPassword = txtConfirmNewPass.Text;
            var encryptPass = new PasswordEncryptModel(obj.Password);
            obj.Password = Convert.ToBase64String(encryptPass.EncryptStringToBytes_Aes());

            var rules = new ChangePassValidator();
            var result = rules.Validate(obj);

            if(!result.IsValid)
            {
                string msg = null;
                foreach (var item in result.Errors)
                    msg += $"{item.ErrorMessage} \n";
                MessageBox.Show(msg);
                return;
            }
            var encryprNewPass = new PasswordEncryptModel(txtNewPass.Text);
            obj.NewPassword = Convert.ToBase64String(encryprNewPass.EncryptStringToBytes_Aes());
            if(model.ChangePassword(obj))
            {
                MessageBox.Show("Succesfully Changed Password.");
                if (isPasswordDefaault)
                {
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
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
