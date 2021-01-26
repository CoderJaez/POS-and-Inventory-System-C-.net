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
using Jaezer_POS_and_Inventory.View.User_Control;
using FluentValidation.Results;
namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmExpenseCat : Form
    {
        private int _id;
        private bool _forUpdate = false;
        ExpenseModel model = new ExpenseModel();
        ExpenseCatUC uc;
        public frmExpenseCat(ExpenseCatUC _uc, int id, bool isUpdate,string data)
        {
            _id = id;
            _forUpdate = isUpdate;
            uc = _uc;
            InitializeComponent();
            txtExpenses.Text = data;
        }

        private void frmExpenseCat_Shown(object sender, EventArgs e)
        {
            txtExpenses.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var data = new Expenses { Id = _forUpdate ? _id : 0, Description = txtExpenses.Text };
            var rules = new ExpensesValidator();
            var result = rules.Validate(data);
            StringBuilder errmsg = new StringBuilder();
           if(!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    errmsg.Append(item.ErrorMessage);
                }
                MessageBox.Show(errmsg.ToString());
                return;
            }
           if(_forUpdate)
            {
                if(model.update(data))
                    MessageBox.Show("Update Succesfully");
            } else
            {
                if(model.insert(data))
                    MessageBox.Show("Registered Succesfully");

            }
            uc.ExpensesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
