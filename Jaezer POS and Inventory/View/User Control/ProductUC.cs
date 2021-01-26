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
    public partial class ProductUC : UserControl
    {
        private frmProduct frm;
        private FormModal modal;
        private ProductModel model = new ProductModel();
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private List<int> ids = new List<int>();
        public ProductUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmodal(0, false);
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        public void ProductList()
        {
            ProductDG.Rows.Clear();
            foreach(var obj in model.getProduct(SearchTxt.Text))
            {
                ProductDG.Rows.Add(obj.ProductID, false, obj.ProductName, obj.Brand, obj.Category, obj.ReOrderLevel, obj.UnitCode, obj.HasExpiry);
            }
        }

        private void ProductDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch(ProductDG.Columns[e.ColumnIndex].Name)
                {
                    case "check":
                        ProductDG.CurrentCell.Value = (bool)ProductDG.CurrentCell.Value ? false : true;
                        if((bool)ProductDG.CurrentCell.Value)
                        {
                            ids.Add(Int32.Parse(ProductDG.CurrentRow.Cells["id"].Value.ToString()));
                            rows.Add(ProductDG.CurrentRow);
                        } else
                        {

                            ids.Remove(Int32.Parse(ProductDG.CurrentRow.Cells["id"].Value.ToString()));
                            rows.Remove(ProductDG.CurrentRow);
                        }
                        break;
                    case "edit":
                        frmmodal(Int32.Parse(ProductDG.CurrentRow.Cells["id"].Value.ToString()), true);
                        break;
                    case "delete":
                        deleteProduct(Int32.Parse(ProductDG.CurrentRow.Cells["id"].Value.ToString()),ProductDG.CurrentRow);
                        break;
                }
            }

        }

        private void deleteProduct()
        {
            if (ids.Count > 0)
            {
                var result = MessageBox.Show("Do you want to delete selected rows?", model.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (model.delete(ids))
                    {
                        MessageBox.Show("Selected row deleted successfully", model.AppName);
                        foreach (var row in rows)
                            ProductDG.Rows.Remove(row);
                        rows.Clear();
                        ids.Clear();
                    }
                }

            }
        }
        private void deleteProduct(int id,DataGridViewRow row)
        {
                var result = MessageBox.Show("Do you want to delete selected rows?", model.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (model.delete(id))
                    {
                         MessageBox.Show("Selected row deleted successfully", model.AppName);
                        ProductDG.Rows.Remove(row);
                    }
                }

        }


        private void frmmodal(int id, bool forupdate)
        {
            frm = new frmProduct(this, id, forupdate);
            modal = new FormModal(this, frm);
            modal.Show();
        }

        private void CheckAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAllCB.CheckState == CheckState.Checked)
            {
                foreach (DataGridViewRow row in ProductDG.Rows)
                {
                    row.Cells["check"].Value = true;
                    ids.Add(Convert.ToInt32(row.Cells["id"].Value.ToString()));
                    rows.Add(row);
                }
            }
            else
            {
                foreach (DataGridViewRow row in ProductDG.Rows)
                {
                    row.Cells["check"].Value = false;
                }
                ids.Clear();
                rows.Clear();
            }
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ProductList();
            }
        }
    }
}
