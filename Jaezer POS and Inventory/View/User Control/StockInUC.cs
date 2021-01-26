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
using FluentValidation.Results;
using System.Threading;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class StockInUC : UserControl
    {
        StockinModel model = new StockinModel();
        StockIn stocks = new StockIn();
        FormModal modal;
        frmProductList prodList;
        User userInfo;
        DateTimePicker dtp = new DateTimePicker();
        ComboBox UnitCodeCB = new ComboBox();
        Rectangle _rectangle;
        frmLoadingScreen load = new frmLoadingScreen();
        List<int> StockIDs = new List<int>();
        frmEditStockPrice frm;
        ComboBox SupplierCB = new ComboBox();
        ComboBox CategoryCB = new ComboBox();
        ComboBox ItemCB = new ComboBox();
        public StockInUC()
        {
            InitializeComponent();
            ProductListDG.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Short;
            dtp.ValueChanged += new EventHandler(dtp_ValueChanged);
            _Filters();
            _FiltersInit();
            SupplierList();
        }

        struct DataParams
        {
            public int Process;
            public int Delay;
        }

        private DataParams _inputParams;
        public void UserInfo(User _user)
        {
            userInfo = _user;
            txtIncharge.Text = userInfo.Fullname;
        }

        private void _FiltersInit()
        {
            CategoryCB.Name = "CategoryCB";
            SupplierCB.Name = "SupplierCB";
            ItemCB.Name = "ItemCB";

            CategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SupplierCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemCB.DropDownStyle = ComboBoxStyle.DropDownList;

            CategoryCB.DisplayMember = "Category";
            CategoryCB.ValueMember = "CatID";

            SupplierCB.DisplayMember = "Supplier";
            SupplierCB.ValueMember = "SupplierID";

            ItemCB.DisplayMember = "Product";
            ItemCB.ValueMember = "ProductID";

            CategoryCB.SelectionChangeCommitted += CategoryCB_SelectionChangeCommitted;
            _Category();
            _Supplier();
            _Items("");
            FilterFL.Controls.Add(CategoryCB);
            FilterFL.Controls.Add(SupplierCB);
            FilterFL.Controls.Add(ItemCB);
            CategoryCB.Visible = false;
            SupplierCB.Visible = false;
            ItemCB.Visible = false;

        }


        private void CategoryCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int filterID = int.Parse(cbFilter.SelectedValue.ToString());
            if (filterID == 1 || filterID == 2)
            {
                _Items(CategoryCB.SelectedValue.ToString());
            }
        }

        private void _Filters()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("type", typeof(string));
            
            dt.Rows.Add(0, "Dates Only");
            dt.Rows.Add(1, "Category Item/Supplier/Item");
            dt.Rows.Add(2, "Category Item/Supplier");
            dt.Rows.Add(3, "Category Item/Products");
            dt.Rows.Add(4, "Supplier/Item");
            dt.Rows.Add(5, "Category Item");
            dt.Rows.Add(6, "Supplier");
            dt.Rows.Add(7, "Item");
            cbFilter.ValueMember = "id";
            cbFilter.DisplayMember = "type";
            cbFilter.DataSource = dt;
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if(ProductListDG.Rows.Count > 0)
                 ProductListDG.CurrentCell.Value = dtp.Value.ToString("yyyy-MM-dd");
            //dtp.Visible = false;
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            prodList = new frmProductList(this);
            modal = new FormModal(this, prodList);
            modal.Show();
        }

        public void StockInHistory()
        {
            string dateFrom = datePSIFrom.Value.AddDays(-1).ToString("yyyy-MM-dd");
            string dateTo = datePSITo.Value.AddDays(1).ToString("yyyy-MM-dd");
            var stockModel = new StockinModel();
            StockInDG.Rows.Clear();
            foreach (var item in stockModel.GetStockInHistory(dateFrom, dateTo, _where()).ProductList)
            {
                StockInDG.Rows.Add(item.StockID,false, StockInDG.Rows.Count + 1, item.ReferenceNo, item.ProductName, item.DateArrival, item.DateExpiry,item.Price, item.Qty, item.UnitCode, item.Price * item.Qty, item.SupplierName);
            }
        }

        private string _where()
        {
            string where = string.Empty;
            switch (int.Parse(cbFilter.SelectedValue.ToString()))
            {
                case 1:
                    where = $"and catID like '%{CategoryCB.SelectedValue.ToString()}%' and supplierID like '%{SupplierCB.SelectedValue.ToString()}%' and prodID like '%{ItemCB.SelectedValue.ToString()}%' ";
                    break;
                case 2:
                    where = $"and catID like '%{CategoryCB.SelectedValue.ToString()}%' and supplierID like '%{SupplierCB.SelectedValue.ToString()}%' ";
                    break;
                case 3:
                    where = $"and catID like '%{CategoryCB.SelectedValue.ToString()}%' and prodID like '%{ItemCB.SelectedValue.ToString()}%' ";
                    break;
                case 4:
                    where = $"and supplierID like '%{SupplierCB.SelectedValue.ToString()}%' and prodID like '%{ItemCB.SelectedValue.ToString()}%' ";
                    break;
                case 5:
                    where = $"and catID like '%{CategoryCB.SelectedValue.ToString()}%' ";
                    break;
                case 6:
                    where = $"and supplierID like '%{SupplierCB.SelectedValue.ToString()}%'  ";
                    break;
                case 7:
                    where = $"and prodID like '%{ItemCB.SelectedValue.ToString()}%' ";
                    break;
                default:
                    break;
            }
            return where;
        }

        public void AddToList(DataTable items)
        {
            foreach (DataRow item in items.Rows)
            {
                ProductListDG.Rows.Add(item["ProdID"].ToString(), ProductListDG.Rows.Count + 1, item["ProductName"].ToString(), item["hasExpiry"]);
            }
        }
        public void AddToList(DataGridViewRow item)
        {
            bool hasDuplicate = false;
            foreach (DataGridViewRow row in ProductListDG.Rows)
            {
                if (row.Cells["ProductID"].Value.ToString() == item.Cells["ProductID"].Value.ToString())
                {
                    hasDuplicate = true;
                    break;
                }
            }

            if (!hasDuplicate)
            {
                ProductListDG.Rows.Add(item.Cells["ProductID"].Value, ProductListDG.Rows.Count + 1, item.Cells["Qty"].Value.ToString(), (bool)item.Cells["HasExpiry"].Value ? true : false, item.Cells["ProductName"].Value.ToString(), (bool)item.Cells["HasExpiry"].Value ? "" : "No Expiry Date");
                //LoadUnits((int)item.Cells["ProductID"].Value);
            }
        }

        private void ProductListDG_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Qty_KeyPress);
            string ColName = ProductListDG.Columns[ProductListDG.CurrentCell.ColumnIndex].Name;
            if ( ColName == "Qty" || ColName == "Price" )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Qty_KeyPress);
                }

            }
        }

        private void LoadUnits(int ProdID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Qty");
            dt.Columns.Add("UnitCode");
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)(ProductListDG.Rows[ProductListDG.Rows.Count - 1].Cells["UnitCode"]);
            cb.DisplayMember = "UnitCode";
            cb.ValueMember = "Qty";
            dt.Rows.Add(0, "");
            foreach (var item in new UnitMeasureModel().ProductUnitList(ProdID))
            {
                dt.Rows.Add(item.Qty, item.UnitCode);
            }
            cb.DataSource = dt;
        }

        private void Qty_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allowed numeric and one dot  ex. 10.23
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

        private void SupplierList()
        {
            var smodel = new SupplierModel();
            DataTable dt = new DataTable();
            dt.Columns.Add("SupplierID");
            dt.Columns.Add("Supplier");
            cbSupplier.ValueMember = "SupplierID";
            cbSupplier.DisplayMember = "Supplier";
            dt.Rows.Add(0, "");
            foreach(var obj in smodel.GetSupplier(""))
            {
                dt.Rows.Add(obj.SupplierID,$"{obj.BusinessName} | {obj.SupplierName}");
            }
            cbSupplier.DataSource = dt; 
        }

       


        private void ProductListDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(ProductListDG.Rows.Count > 0)
                switch (ProductListDG.Columns[e.ColumnIndex].Name)
                {
                    case "DateExpiry":
                        _rectangle = ProductListDG.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Value = DateTime.Today;
                        dtp.Size = new Size(_rectangle.Width, _rectangle.Height);
                        dtp.Location = new Point(_rectangle.X, _rectangle.Y);
                        dtp.Visible = (bool)ProductListDG.CurrentRow.Cells["HasExpiry"].Value ? true : false;
                        break;
                    case "delete":
                        var result = MessageBox.Show("Remove selected Item?", model.AppName, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            ProductListDG.Rows.Remove(ProductListDG.CurrentRow);
                        break;
                    default:
                        dtp.Visible = false;
                        break;
                }
        }

        private void ProductListDG_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ProductToStockin())
                return;
            stocks.ReferenceNo = txtReferenceNo.Text;
            stocks.DateArrival = dtDateArrval.Value.ToShortDateString();
            stocks.SupplierName = cbSupplier.Text;
            stocks.InCharge = txtIncharge.Text;
            var rules = new StockInValidator();
            var results = rules.Validate(stocks);
            string msg = null;
            if (results.IsValid == false)
            {
                foreach (ValidationFailure error in results.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{model.AppName}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if(!backgroundWorker.IsBusy)
            {
                _inputParams.Delay = 200;
                _inputParams.Process = stocks.ProductList.Count();
                backgroundWorker.RunWorkerAsync(_inputParams);
                load.ShowDialog();
            }

            //if(model.insert(stocks))
            //{
            //    MessageBox.Show("New Stocks Successfully Added to the Inventory", model.AppName);
            //    ProductListDG.Rows.Clear();
            //    txtIncharge.Text = null;
            //    txtReferenceNo.Text = null;
            //    cbSupplier.Text = "";
            //}
        }

        private bool ProductToStockin()
        {
            stocks.ProductList.Clear();
            foreach (DataGridViewRow item in ProductListDG.Rows)
            {
                var obj = new StockIn();
                obj.ProductID = int.Parse(item.Cells["ProductID"].Value.ToString());
                obj.ProductName = item.Cells["Product"].Value.ToString();
                obj.SupplierID = int.Parse(cbSupplier.SelectedValue.ToString());
                obj.SupplierName = cbSupplier.Text;
                obj.DateArrival = dtDateArrval.Value.ToString("yyyy-MM-dd");
                obj.DateExpiry = (bool)item.Cells["HasExpiry"].Value ? item.Cells["DateExpiry"].Value.ToString():"0000-00-00";
                obj.DateStockin = DateTime.Today.ToString("yyyy-MM-dd");
                obj.HasExpiry = (bool)item.Cells["HasExpiry"].Value;
                obj.InCharge = txtIncharge.Text;
                obj.ReferenceNo = txtReferenceNo.Text;
                obj.Price = item.Cells["Price"].Value != null ? decimal.Parse(item.Cells["Price"].Value.ToString()): 0;
                obj.Qty = (item.Cells["Qty"].Value != null)? int.Parse(item.Cells["Qty"].Value.ToString()):0;
                obj.UserID = userInfo.UserID;
                stocks.ProductList.Add(obj);

            }
            return ProductListDG.Rows.Count > 0 ? true : false;
        }

        private void btnGenRefNo_Click(object sender, EventArgs e)
        {
            txtReferenceNo.Text = model.GenerateRefNo();
        }

      
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParams)e.Argument).Process;
            int delay = ((DataParams)e.Argument).Delay;
            int index = 1;
            try
            {
                foreach (var item in stocks.ProductList)
                {
                    if(!backgroundWorker.CancellationPending)
                    {
                        if (model.insert(item))
                        {
                            backgroundWorker.ReportProgress(index++ * 100 / process);
                        }
                        Thread.Sleep(delay);
                    }
                   
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            load.pb.Value = e.ProgressPercentage;
            load.pb.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("New Stocks Successfully Added to the Inventory", model.AppName);
            ProductListDG.Rows.Clear();
            txtReferenceNo.Text = null;
            cbSupplier.Text = "";
            load.Close();
        }

        private void btnLDStockin_Click(object sender, EventArgs e)
        {
            StockInHistory();
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            if(StockIDs.Count > 0)
            {
                frm = new frmEditStockPrice(StockIDs,this);
                frm.ShowDialog();
                StockIDs.Clear();
                StockDGCB.Checked = false;
                foreach (DataGridViewRow item in StockInDG.Rows)
                    item.Cells["stockCB"].Value = false;
            }
        }

        private void StockInDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StockInDG.Rows.Count >= 0)
            {
                if (decimal.Parse(StockInDG.CurrentRow.Cells["CostPrice"].Value.ToString()) > 0)
                {
                    MessageBox.Show("You cannot edit the selected product");
                    return;
                }
                switch (StockInDG.Columns[e.ColumnIndex].Name)
                {
                    case "stockCB":
                       
                        StockInDG.CurrentCell.Value = (bool)StockInDG.CurrentCell.Value ? false : true;
                        if((bool)StockInDG.CurrentCell.Value)
                            StockIDs.Add(int.Parse(StockInDG.CurrentRow.Cells["StockID"].Value.ToString()));
                        else
                            StockIDs.Remove(int.Parse(StockInDG.CurrentRow.Cells["StockID"].Value.ToString()));

                        break;
                    case "edit":
                        StockIDs.Clear();
                        StockIDs.Add(int.Parse(StockInDG.CurrentRow.Cells["StockID"].Value.ToString()));
                        frm = new frmEditStockPrice(StockIDs,this);
                        frm.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
        }

        private void StockDGCB_CheckedChanged(object sender, EventArgs e)
        {
            if (StockInDG.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in StockInDG.Rows)
                {
                    if(decimal.Parse(item.Cells["CostPrice"].Value.ToString()) <= 0)
                    {
                        item.Cells["stockCB"].Value = (bool)StockDGCB.Checked ? true : false;
                        if ((bool)StockDGCB.Checked)
                            StockIDs.Add(int.Parse(item.Cells["StockID"].Value.ToString()));
                        else
                            StockIDs.Remove(int.Parse(item.Cells["StockID"].Value.ToString()));
                    }
                  
                }
            }
        }

        private void cbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedFilters(int.Parse(cbFilter.SelectedValue.ToString()));
        }

        private void _Category()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CatID");
            dt.Columns.Add("Category");
            dt.Rows.Add("", "ALL Item Categories");
            foreach(var item in new CategoryModel().getCategory(""))
            {
                dt.Rows.Add(item.id, item.category);
            }

            CategoryCB.DataSource = dt;
        }

        private void _Supplier()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SupplierID");
            dt.Columns.Add("Supplier");
            dt.Rows.Add("", "ALL Suppliers");
            foreach (var item in new SupplierModel().GetSupplier(""))
            {
                dt.Rows.Add(item.SupplierID, item.SupplierName);
            }
            SupplierCB.DataSource = dt;
        }

        private void _Items(string id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("Product");
            dt.Rows.Add("", "ALL Product Items");
            foreach (var item in new ProductModel().getProduct(id))
            {
                dt.Rows.Add(item.ProductID, item.ProductName);
            }
            ItemCB.DataSource = dt;
        }


        private void selectedFilters(int id)
        {
            switch (id)
            {
                case 1:
                    CategoryCB.Visible = true;
                    SupplierCB.Visible = true;
                    ItemCB.Visible = true;
                    break;
                case 2:
                    CategoryCB.Visible = true;
                    SupplierCB.Visible = true;
                    ItemCB.Visible = false;
                    break;
                case 3:
                    CategoryCB.Visible = true;
                    SupplierCB.Visible = false;
                    ItemCB.Visible = true;
                    break;
                case 4:
                    CategoryCB.Visible = false;
                    SupplierCB.Visible = true;
                    ItemCB.Visible = true;
                    break;
                case 5:
                    CategoryCB.Visible = true;
                    SupplierCB.Visible = false;
                    ItemCB.Visible = false;
                    break;
                case 6:
                    CategoryCB.Visible = false;
                    ItemCB.Visible = false;
                    SupplierCB.Visible = true;
                    break;
                case 7:
                    CategoryCB.Visible = false;
                    SupplierCB.Visible = false;
                    ItemCB.Visible = true;
                    break;
                default:
                    CategoryCB.Visible = false;
                    SupplierCB.Visible = false;
                    ItemCB.Visible = false;
                    break;
            }
        }
    }
}
