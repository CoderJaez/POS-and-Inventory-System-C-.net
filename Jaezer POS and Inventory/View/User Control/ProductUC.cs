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

        private int limit = 50;
        private int totalRows = 0;
        private int filteredRows = 0;
        private int page = 1;
        private int start = 0;
        private int totalPage = 0;

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
            foreach (var obj in model.getProduct(SearchTxt.Text, start, limit))
            {
                ProductDG.Rows.Add(obj.ProductID,ProductDG.Rows.Count + start + 1,false, obj.ProductName, obj.Brand, obj.Category, obj.ReOrderLevel, obj.UnitCode, obj.HasExpiry);
            }


            if (SearchTxt.Text == "")
            {
                totalRows = model.TotalRows;
                totalPage = (int)Math.Round((double)totalRows / (double)limit);
                pageLabel.Text = $"{page}/{totalPage}";
                if (totalRows - start < limit)
                {
                    btnNext.Enabled = false;
                    labelEntries.Text = $"Showing {start + 1} to {totalRows} of {totalRows} entries";
                }
                else
                {
                    labelEntries.Text = $"Showing {start + 1} to {start + limit} of {totalRows} entries";
                    btnNext.Enabled = true;
                }
            }
            else
            {
                filteredRows = model.FilteredRows;
                totalPage = (int)Math.Round((double)filteredRows / (double)limit);
                pageLabel.Text = $"{page}/{(totalPage != 0 ? totalPage : page)}";

                if (filteredRows - start < limit)
                {
                    btnNext.Enabled = false;
                    labelEntries.Text = $"Showing {start + 1} to {filteredRows} of {filteredRows} entries (Filtered from {totalRows} total entries)";
                }
                else
                {
                    labelEntries.Text = $"Showing {start + 1} to {start + limit} of  {filteredRows} entries (Filtered from {totalRows} total entries)";
                    btnNext.Enabled = true;
                }
            }
        }

        private void ProductDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (ProductDG.Columns[e.ColumnIndex].Name)
                {
                    case "check":
                        ProductDG.CurrentCell.Value = (bool)ProductDG.CurrentCell.Value ? false : true;
                        if ((bool)ProductDG.CurrentCell.Value)
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
                        deleteProduct(Int32.Parse(ProductDG.CurrentRow.Cells["id"].Value.ToString()), ProductDG.CurrentRow);
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
                        foreach (DataGridViewRow row in rows)
                            ProductDG.Rows.Remove(row);
                        rows.Clear();
                        ids.Clear();
                    }
                }

            }
        }
        private void deleteProduct(int id, DataGridViewRow row)
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            start -= limit;
            page -= 1;
            if (start <= 0)
            {
                start = 0;
                page = 1;
                btnPrev.Enabled = false;
                btnFirstPage.Enabled = false;
            }
            btnLastPage.Enabled = true;
            ProductList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            start += limit;
            page += 1;

            if ((totalRows - start) <= limit)
            {
                btnNext.Enabled = false;
                btnLastPage.Enabled = false;
            }
            btnPrev.Enabled = true;
            btnFirstPage.Enabled = true;
            ProductList();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            page = totalRows / limit;
            start = page * limit;
            btnPrev.Enabled = true;
            btnLastPage.Enabled = false;
            btnFirstPage.Enabled = true;
            ProductList();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            start = 0;
            page = 1;
            btnFirstPage.Enabled = false;
            btnLastPage.Enabled = true;
            btnPrev.Enabled = false;
            ProductList();

        }

        private void cbPerPage_SelectedValueChanged(object sender, EventArgs e)
        {
            limit = cbPerPage.Text == "" ? 50 : int.Parse(cbPerPage.Text);
            start = 0;
            page = 1;
            if (totalRows <= limit || filteredRows <= limit)
            {
                btnFirstPage.Enabled = false;
                btnLastPage.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            } else
            {
                btnFirstPage.Enabled = true;
                btnLastPage.Enabled = true;
            }
            ProductList();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            ProductList();
        }
    }
}
