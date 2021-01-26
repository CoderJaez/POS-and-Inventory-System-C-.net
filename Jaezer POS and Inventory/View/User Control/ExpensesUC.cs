using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.View.Forms;
using Jaezer_POS_and_Inventory.Model;
namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class ExpensesUC : UserControl
    {
        ExpenseModel model = new ExpenseModel();
        frmExpenses frm;
        FormModal modal;
        private int UserID;
        public ExpensesUC()
        {
            InitializeComponent();
            UserID = Properties.Settings.Default.UserID;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadExpenseList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm = new frmExpenses(this);
            modal = new FormModal(this, frm);
            modal.Show();
        }

        public void LoadExpenseList()
        {
            string dateFrom = dpDateFrom.Value.AddDays(-1).ToString("yyyy-MM-dd");
            string dateTo = dpDateTo.Value.ToString("yyyy-MM-dd");
            ExpensesCatDG.Rows.Clear();
            foreach (var item in model.GetAllExpenses(dateFrom,dateTo))
            {
                ExpensesCatDG.Rows.Add(item.Id, item.Description, item.Amount, item.Date, item.UserName);
            }
        }

        private void ExpensesCatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                switch (ExpensesCatDG.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        var data = new Expenses
                        {
                            Id = int.Parse(ExpensesCatDG.CurrentRow.Cells["id"].Value.ToString()),
                            Description = ExpensesCatDG.CurrentRow.Cells["Description"].Value.ToString(),
                            Amount = decimal.Parse(ExpensesCatDG.CurrentRow.Cells["Amount"].Value.ToString()),
                            Date = ExpensesCatDG.CurrentRow.Cells["date"].Value.ToString()
                        };
                        frm = new frmExpenses(data,true,this);
                        modal = new FormModal(this, frm);
                        modal.Show();
                        break;
                    case "delete":
                        int id = int.Parse(ExpensesCatDG.CurrentRow.Cells["id"].Value.ToString());
                        var result = MessageBox.Show("Delete selected row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            if(model.deleteExpense(id))
                            {
                                MessageBox.Show("Deleted Successfully");
                                ExpensesCatDG.Rows.Remove(ExpensesCatDG.CurrentRow);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
