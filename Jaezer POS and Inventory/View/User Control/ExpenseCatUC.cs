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
    public partial class ExpenseCatUC : UserControl
    {

        frmExpenseCat frm;
        FormModal modal;
        ExpenseModel model = new ExpenseModel();
        public ExpenseCatUC()
        {
            InitializeComponent();
            ExpensesList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm = new frmExpenseCat(this,0, false,"");
            modal = new FormModal(this, frm);
            modal.Show();
        }


        public void ExpensesList()
        {
            ExpensesCatDG.Rows.Clear();
            foreach (var item in model.GetAll(SearchTxt.Text))
            {
                ExpensesCatDG.Rows.Add(item.Id, item.Description);
            }
        }

        private void ExpensesCatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                int id;
                switch(ExpensesCatDG.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                         id = int.Parse(ExpensesCatDG.CurrentRow.Cells["id"].Value.ToString());
                        string description = ExpensesCatDG.CurrentRow.Cells["Description"].Value.ToString();
                        frm = new frmExpenseCat(this, id, true, description);
                        modal = new FormModal(this, frm);
                        modal.Show();
                        break;
                    case "delete":
                        id = int.Parse(ExpensesCatDG.CurrentRow.Cells["id"].Value.ToString());
                        var result = MessageBox.Show("Delete selected row?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if(model.delete(id))
                            {
                                MessageBox.Show("Deleted successfully");
                                ExpensesCatDG.Rows.Remove(ExpensesCatDG.CurrentRow);
                            }
                        }
                        break;

                }
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            ExpensesList();
        }
    }
}
