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
using Zen.Barcode;
namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmProduct : Form
    {
        public Product product = new Product();
        PriceItem pItem = new PriceItem();
        PriceItemCollection PriceColl = new PriceItemCollection();
        PricingModel pmodel = new PricingModel();
        BrandModel bmodel = new BrandModel();
        CategoryModel cmodel = new CategoryModel();
        UnitMeasureModel umodel = new UnitMeasureModel();
        ProductUC uc = new ProductUC();
        frmPriceItem frm;
        DataTable dt = new DataTable();
        private bool isForUpdate;
        public string _UnitCode { get { return lblUnitCode.Text; } set { lblUnitCode.Text = value; } }
        public frmProduct(ProductUC _uc, int _id, bool _isForUpdate)
        {
            InitializeComponent();
            uc = _uc;
            isForUpdate = _isForUpdate;
            CategoryList();
            BrandList();
            if (isForUpdate)
                ProductInfo(_id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(product.ProductID != 0 && product.UnitCode == null)
            {
                MessageBox.Show("Please set the Base Unit of Measure of this Product");
                return;
            }
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            product.ProductName = txtProductName.Text;
            product.Brand = cbBrand.Text;
            product.Category = cbCategory.Text;
            product.HasExpiry = cbHasExpire.Checked;
            try
            {
                product.BrandID= Int32.Parse(cbBrand.SelectedValue.ToString());
                product.CatID = Int32.Parse(cbCategory.SelectedValue.ToString());
                product.ReOrderLevel = Convert.ToInt32(txtReOrderLvl.Text);
                product.DayBeforeExpiry = Convert.ToInt32(txtDayBExp.Text);
            }
            catch (Exception)
            {

            }
            var rules = new ProductValidator();
            var result = rules.Validate(product);
            string msg = null;

            if (!result.IsValid)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if(!isForUpdate)
            {
                product.ProductID = (int)pmodel.insert(product);
                if (product.ProductID != 0)
                {
                    MessageBox.Show("Product Registration Successfull.", pmodel.AppName);
                    btnSave.Enabled = false;
                }
            } else
            {
                if (pmodel.update(product))
                {
                    MessageBox.Show("Product Update Successfull.", pmodel.AppName);
                    this.Close();
                }
            }

            uc.ProductList();

        }


       

        private void clear()
        {
            txtProductName.Text = null;
            txtReOrderLvl.Text = null;
            cbHasExpire.CheckState = CheckState.Unchecked;
            cbBrand.Text = "";
            cbCategory.Text = "";
            product = new Product();
            btnSave.Enabled = true;
            btnAddNew.Visible = false;
            PriceListDG.Rows.Clear();
            _UnitCode = "";
        }
        private void ProductInfo(int id)
        {
            product = pmodel.getProduct(id);
            txtProductName.Text = product.ProductName;
            txtReOrderLvl.Text = product.ReOrderLevel.ToString();
            cbBrand.SelectedValue = product.BrandID;
            cbCategory.SelectedValue = product.CatID;
            cbHasExpire.Checked = product.HasExpiry ;
            txtDayBExp.Text = product.DayBeforeExpiry.ToString();
            txtDayBExp.Visible = product.HasExpiry;
            lblUnitCode.Text = product.UnitCode != "" ? product.UnitCode : "Not Set";
            ProductPriceList();
        }

        private void ProductPriceList()
        {
            PriceListDG.Rows.Clear();
            foreach (var obj in pmodel.GetPriceList(product.ProductID).PriceList)
            {
                PriceListDG.Rows.Add(obj.priceID, obj.Barcode, obj.Variant, obj.Price, obj.UnitCode);
            }
        }

        private void CategoryList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("category");
            cbCategory.DisplayMember = "category";
            cbCategory.ValueMember = "id";
            dt.Rows.Add("", "");
            foreach (var obj in cmodel.getCategory(""))
                dt.Rows.Add(obj.id, obj.category);
            cbCategory.DataSource = dt;
        }

        private void BrandList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("brand");
            cbBrand.DisplayMember = "brand";
            cbBrand.ValueMember = "id";
            dt.Rows.Add("", "");
            foreach (var obj in bmodel.getBrandList(""))
                dt.Rows.Add(obj.id, obj.brand);
            cbBrand.DataSource = dt;
        }

       

       

        private void txtReOrderLvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnNewPrice_Click(object sender, EventArgs e)
        {
           if(product.ProductID == 0)
            {
                MessageBox.Show("Create a New Product First.", pmodel.AppName,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShowPriceItemForm();
        }

        
        private void ShowPriceItemForm()
        {
            pItem.ProductID = product.ProductID;
            pItem.ProductName = product.ProductName;
            foreach (var item in product.UnitList)
            {

            }
            frm = new frmPriceItem(false, pItem);
            frm.ShowDialog();

        }

        private void ShowPriceItemForm(DataGridViewRow row)
        {
            pItem.ProductID = product.ProductID;
            pItem.ProductName = product.ProductName;
            pItem.priceID = int.Parse(row.Cells["id"].Value.ToString());
            pItem.Barcode = row.Cells["Barcode"].Value.ToString();
            pItem.Price = double.Parse(row.Cells["Price"].Value.ToString());
            pItem.Variant = row.Cells["Variant"].Value.ToString();
            pItem.Brand = row.Cells["UnitCode"].Value.ToString();
            frm = new frmPriceItem(true, pItem);
            frm.ShowDialog();
        }
        private void PriceListDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var currentRow = PriceListDG.CurrentRow;
                switch (PriceListDG.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        ShowPriceItemForm(currentRow);
                        break;
                    case "delete":
                        var result = MessageBox.Show("Do you want to delete selected data?", pmodel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(result == DialogResult.Yes)
                        {
                            int id = int.Parse(currentRow.Cells["id"].Value.ToString());
                            if (pmodel.delete(id))
                            {
                                MessageBox.Show("Selected Data Deleted Successfully.", pmodel.AppName);
                                PriceListDG.Rows.Remove(currentRow);
                            }
                        }
                        break;
                    case "print_barcode":
                        frmPriceItem.Instance.PrintBarcode(currentRow.Cells["Barcode"].Value.ToString(), currentRow.Cells["Price"].Value.ToString(), currentRow.Cells["Variant"].Value.ToString());
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProductPriceList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (product.ProductID == 0)
                return;
            frmUnitGroups ugFrm = new frmUnitGroups(this);
            ugFrm.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if ( _UnitCode == "")
            {
                MessageBox.Show("Please set Product Unit First");
                return;
            }
            clear();
        }

        private void cbHasExpire_CheckedChanged(object sender, EventArgs e)
        {
            txtDayBExp.Visible = cbHasExpire.Checked;
        }

        public void EnableAddNewProduct()
        {
            btnAddNew.Visible = true;
        }

        private void frmProduct_Shown(object sender, EventArgs e)
        {
            txtProductName.Focus();
        }
    }
}
