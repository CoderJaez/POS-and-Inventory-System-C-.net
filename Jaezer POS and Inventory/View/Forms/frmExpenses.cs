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
    public partial class frmExpenses : Form
    {
        ExpenseModel model = new ExpenseModel();
        ExpensesUC uc;
        bool forUpdate;
        private int id;
        private int UserID = Properties.Settings.Default.UserID;
        public frmExpenses(ExpensesUC _uc)
        {
            InitializeComponent();
            uc = _uc;
            _ExpenseCat();
        }
        public frmExpenses(Expenses data, bool _forUpdate, ExpensesUC _uc)
        {
            InitializeComponent();
            _ExpenseCat();
            forUpdate = _forUpdate;
            uc = _uc;
            id = data.Id;
            dtDateExpense.Value = DateTime.Parse(data.Date);
            cbExpenseType.Text = data.Description;
            txtAmount.Text = data.Amount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var data = new Expenses {
                Id = id,
                ExpID = int.Parse(cbExpenseType.SelectedValue.ToString()),
                Description = cbExpenseType.Text,
                Amount = decimal.Parse(txtAmount.Text),
                Date = dtDateExpense.Value.ToString("yyyy-MM-dd"),
                UserID = UserID
            };

            var rules = new ExpenseValidator();
            var result = rules.Validate(data);
            if(!result.IsValid)
            {
                StringBuilder msg = new StringBuilder();
                foreach (var item in result.Errors)
                {
                    msg.Append(item.ErrorMessage);
                }
                MessageBox.Show(msg.ToString());
                return;
            }
            if(forUpdate)
            {
                if(model.updateExpense(data))
                {
                    MessageBox.Show("Updated successfully");
                    forUpdate = false;
                }
            }
            else
            {
                if(model.insertExpense(data))
                {
                    MessageBox.Show("Inserted Successfully");
                }
            }
            clear();
            uc.LoadExpenseList();
            
        }

        private void clear()
        {
            cbExpenseType.Text = "";
            txtAmount.Text = "";
        }

        private void _ExpenseCat()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("description");

            cbExpenseType.ValueMember = "id";
            cbExpenseType.DisplayMember = "description";
            dt.Rows.Add("", "");
            foreach (var item in model.GetAll(""))
                dt.Rows.Add(item.Id, item.Description);

            cbExpenseType.DataSource = dt;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
