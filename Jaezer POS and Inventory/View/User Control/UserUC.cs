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
using Jaezer_POS_and_Inventory.View.Forms;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class UserUC : UserControl
    {
        UserModel model = new UserModel();
        frmUser frm;
        FormModal modal;
        User UserInfo;
        public UserUC(User _obj)
        {
            InitializeComponent();
            UserInfo = _obj;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             frm = new frmUser(this);
            modal = new FormModal(this, frm);
            modal.Show();

        }

        public void UserList()
        {
            UserDG.Rows.Clear();
            Bitmap img;
            foreach (var item in model.GetUser(SearchTxt.Text))
            {
                if (!item.Status)
                    img = Properties.Resources.icons8_toggle_off_16;
                else
                    img = Properties.Resources.icons8_toggle_on_16;

                UserDG.Rows.Add(item.UserID, item.UserName, item.Fullname, item.UserType, img,item.Status);
            }
        }

        private void UserUC_Load(object sender, EventArgs e)
        {
            UserList();
        }


        private void UserDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch(UserDG.Columns[e.ColumnIndex].Name)
                {
                    case "setStatus":
                        bool status = (bool)UserDG.CurrentRow.Cells["status"].Value;
                        int id = int.Parse(UserDG.CurrentRow.Cells["UserID"].Value.ToString());
                        string _SetSatus = status ? "Deactivate" : "Activate";
                        var result = MessageBox.Show($"Do you want to {_SetSatus} selected row?", model.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            status = status ? false : true;
                            if(model.UpdateStatus(id, status))
                            {
                                MessageBox.Show($"Selected Row Succesfully {_SetSatus}");
                                UserDG.CurrentCell.Value = status ? Properties.Resources.icons8_toggle_on_16 : Properties.Resources.icons8_toggle_off_16;
                                UserDG.CurrentRow.Cells["status"].Value = status;
                            }
                        }
                        break;
                    case "delete":
                        int _id = int.Parse(UserDG.CurrentRow.Cells["UserID"].Value.ToString());
                        var _result = MessageBox.Show("Do you want to delete selected row?", model.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(_result == DialogResult.Yes)
                        {
                            if(model.Delete(_id))
                            {
                                MessageBox.Show("Selected Row Successfully Deleted");
                                UserDG.Rows.Remove(UserDG.CurrentRow);
                            }
                        }
                        break;
                }
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            UserList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInfo.Password = txtOldPass.Text;
            UserInfo.NewPassword = txtNewPass.Text;
            UserInfo.ConfirmNewPassword = txtConfirmNewPass.Text;
            var encryptPass = new PasswordEncryptModel(UserInfo.Password);
            UserInfo.Password = Convert.ToBase64String(encryptPass.EncryptStringToBytes_Aes());

            var rules = new ChangePassValidator();
            var result = rules.Validate(UserInfo);

            if (!result.IsValid)
            {
                string msg = null;
                foreach (var item in result.Errors)
                    msg += $"{item.ErrorMessage} \n";
                MessageBox.Show(msg);
                return;
            }
            var encryprNewPass = new PasswordEncryptModel(txtNewPass.Text);
            UserInfo.NewPassword = Convert.ToBase64String(encryprNewPass.EncryptStringToBytes_Aes());
            if (model.ChangePassword(UserInfo))
            {
                MessageBox.Show("Succesfully Changed Password.");
             
            }
        }
    }
}
