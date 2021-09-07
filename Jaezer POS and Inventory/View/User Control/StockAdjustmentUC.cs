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
using FluentValidation.Results;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class StockAdjustmentUC : UserControl
    {
        InventoryModel imodel = new InventoryModel();
        StockIn obj = new StockIn();
        User userInfo;

        private int limit = 50;
        private int totalRows = 0;
        private int filteredRows = 0;
        private int page = 1;
        private int start = 0;
        private int totalPage = 0;
        public StockAdjustmentUC(User _userInfo)
        {
            InitializeComponent();
            userInfo = _userInfo;
            lblIncharge.Text = userInfo.Fullname;
            _Remarks();
        }

        private void StockAdjustmentUC_Load(object sender, EventArgs e)
        {
            InventoryList();
        }
        private void _Remarks()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("val");
            dt.Columns.Add("remarks");
            dt.Rows.Add("", "");
            dt.Rows.Add(1, "ERRONEOUS ENTRY");
            dt.Rows.Add(2, "DAMAGED");
            dt.Rows.Add(3, "EXPIRED");
            cbRemarks.ValueMember = "val";
            cbRemarks.DisplayMember = "remarks";
            cbRemarks.DataSource = dt;
        }

        private void InventoryList()
        {
            InventoryDG.Rows.Clear();
            StockInDG.Rows.Clear();
            foreach (var item in imodel.GetProductInventory(SearchTxt.Text,start,limit).ProductList)
            {
                    InventoryDG.Rows.Add(item.ProductID, InventoryDG.Rows.Count + 1 + start, item.ProductName, item.Brand, item.Category, item.ReOrderLevel, item.Onhand, item.UnitCode);
                if (item.Onhand <= item.ReOrderLevel)
                {
                    InventoryDG.Rows[InventoryDG.Rows.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                    InventoryDG.Rows[InventoryDG.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            if(InventoryDG.Rows.Count > 0)
                InventoryDG.Rows[0].Selected = false;

            if(SearchTxt.Text == "")
            {
                totalRows = imodel.TotalRows;
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
            } else
            {
                filteredRows = imodel.FilteredRows;
                totalPage = (int)Math.Round((double)filteredRows / (double)limit);
                pageLabel.Text = $"{page}/{(totalPage != 0 ? totalPage:page)}";

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

        private void StockinList(string prodID)
        {
            StockInDG.Rows.Clear();
            foreach (var item in imodel.getStockinList(prodID).ProductList)
            {
                StockInDG.Rows.Add(item.StockID,item.ProductID, StockInDG.Rows.Count + 1, item.ReferenceNo, item.ProductName, item.DateStockin, item.DateExpiry,item.Qty, item.Price, item.Onhand);
                if(item.HasExpiry && Convert.ToDateTime(item.DateExpiry).Subtract(DateTime.Now).Days <= item.DayBeforeExpiry)
                {
                    StockInDG.Rows[StockInDG.Rows.Count - 1].DefaultCellStyle.BackColor = Color.IndianRed;
                    StockInDG.Rows[StockInDG.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }

            }
            if(StockInDG.Rows.Count >0)
               StockInDG.Rows[0].Selected = false;
        }



        private void InventoryDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(InventoryDG.Columns[e.ColumnIndex].Name == "view")
                {
                    string prodID = InventoryDG.CurrentRow.Cells["ProductID"].Value.ToString();
                    StockinList(prodID);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StockInDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                lblReferenceNo.Text = StockInDG.CurrentRow.Cells["ReferenceNo"].Value.ToString();
                lblProductName.Text = StockInDG.CurrentRow.Cells["ProdName"].Value.ToString();
                obj.StockID = int.Parse(StockInDG.CurrentRow.Cells["StockinID"].Value.ToString());
                obj.Onhand = int.Parse(StockInDG.CurrentRow.Cells["qty"].Value.ToString());
                obj.ProductID = int.Parse(StockInDG.CurrentRow.Cells["ProdID"].Value.ToString());
                obj.Price = decimal.Parse(StockInDG.CurrentRow.Cells["costPrice"].Value.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            obj.ProductName = lblProductName.Text;
            obj.Qty = txtQty.Text != "" ? int.Parse(txtQty.Text) : 0;
            obj.Action = checkAddStock.Checked || checkRemoveStock.Checked ? (checkAddStock.Checked ? checkAddStock.Text : checkRemoveStock.Text) : "";
            obj.Remarks = cbRemarks.Text;
            obj.InCharge = lblIncharge.Text;
            obj.UserID = userInfo.UserID;
            obj.ReferenceNo = lblReferenceNo.Text; 
            obj.remarksVal = int.Parse(cbRemarks.SelectedValue.ToString());
            obj.DateStockin = DateTime.Now.ToString("yyyy-MM-dd");
            var rules = new StockAdjustmentValidator();
            var result = rules.Validate(obj);
            string msg = null;

            if (!result.IsValid)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(imodel.StockQtyAdjustment(obj))
            {
                MessageBox.Show("Stock Adjustment Successfull", imodel.AppName);
                InventoryList();
                clear();
            }
        }

        private void checkAddStock_CheckedChanged(object sender, EventArgs e)
        {
            checkRemoveStock.Checked = false;
        }

        private void checkRemoveStock_CheckedChanged(object sender, EventArgs e)
        {
            checkAddStock.Checked = false;
        }

        private void clear()
        {
            lblProductName.Text = null;
            lblReferenceNo.Text = null;
            txtQty.Text = null;
            
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            start = 0;
            page = 1;
            InventoryList();
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
            InventoryList();
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
            InventoryList();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

            page = totalRows / limit;
            start = page * limit;
            btnPrev.Enabled = true;
            btnLastPage.Enabled = false;
            btnFirstPage.Enabled = true;
            InventoryList();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            start = 0;
            page = 1;
            btnFirstPage.Enabled = false;
            btnLastPage.Enabled = true;
            btnPrev.Enabled = false;
            InventoryList();

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
            }
            else
            {
                btnFirstPage.Enabled = true;
                btnLastPage.Enabled = true;
            }
            InventoryList();
        }
    }
}
