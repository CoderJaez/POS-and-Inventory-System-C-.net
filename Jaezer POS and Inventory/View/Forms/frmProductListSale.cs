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

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmProductListSale : Form
    {
        SalesTransactionModel stmodel = new SalesTransactionModel();
        InventoryModel imodel = new InventoryModel();
        SaleEventUC uc;
        public frmProductListSale(SaleEventUC _uc)
        {
            InitializeComponent();
            uc = _uc;
        }

        private void ProductList()
        {
            int i = 0;
            ProdPriceDG.Rows.Clear();
            foreach (var item in imodel.ProductInquiryList(""))
            {
                if (item.IsSale)
                    continue;
                ProdPriceDG.Rows.Add(item.PriceID, ++i, $"{item.ProductName} ({item.PriceUnit})", item.Price);
            }
        }

        private void frmProductListSale_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        public void ProductInfoList(List<ProductPrice> list)
        {
            int i = 0;
            ProdSaleDG.Rows.Clear();
            foreach (var item in list)
            {
                ProdSaleDG.Rows.Add(item.PriceID, ++i, item.ProductName, item.Price, item.SPrice);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProdPriceDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(ProdPriceDG.Columns[e.ColumnIndex].Name == "add")
                {
                    AddToSaleProd(ProdPriceDG.CurrentRow);
                }
            }
        }

        private void AddToSaleProd(DataGridViewRow item)
        {
            bool hasDuplicate = false;
            int i = ProdSaleDG.Rows.Count;
            foreach(DataGridViewRow row in ProdSaleDG.Rows)
            {
                if (row.Cells["prID"].Value.ToString() == item.Cells["PrcID"].Value.ToString())
                {
                    hasDuplicate = true;
                    break;
                }
            }
            if (!hasDuplicate)
            {
                ProdSaleDG.Rows.Add(item.Cells["PrcID"].Value.ToString(), ++i, item.Cells["PName"].Value.ToString(), item.Cells["price"].Value.ToString());
                ComputeDiscount();
            }
        }

        private void ComputeDiscount()
        {
            if (txtDiscount.Text != "" && ProdSaleDG.Rows.Count >= 0)
            {
                decimal discount = decimal.Parse(txtDiscount.Text) / 100;
                int i = 0;
                foreach (DataGridViewRow item in ProdSaleDG.Rows)
                {
                    item.Cells["Discount"].Value = Math.Round(decimal.Parse(item.Cells["UPrice"].Value.ToString()) * discount, 2);
                    item.Cells["SPrice"].Value = Math.Round(decimal.Parse(item.Cells["UPrice"].Value.ToString()) - decimal.Parse(item.Cells["Discount"].Value.ToString()),2);
                }
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            ComputeDiscount();
        }

        private void tbnSave_Click(object sender, EventArgs e)
        {
            if(txtDiscount.Text != "" && ProdSaleDG.RowCount > 0)
            {
                string dFrom = dateEFrm.Value.ToString("yyyy-MM-dd");
                string dTo = dateETo.Value.ToString("yyyy-MM-dd");
                var list = new List<ProductPrice>();
                foreach (DataGridViewRow item in ProdSaleDG.Rows)
                {
                    list.Add(new ProductPrice()
                    {
                        PriceID = int.Parse(item.Cells["prID"].Value.ToString()),
                        IsSale = true,
                        SPrice = decimal.Parse(item.Cells["SPrice"].Value.ToString()),
                        SDateFrm = dFrom,
                        SDateTo = dTo
                    });
                }

                if(stmodel.AddItemDiscSale(list))
                {
                    MessageBox.Show("Success");
                    ProdSaleDG.Rows.Clear();
                    txtDiscount.Text = "";
                    ProductList();
                    uc.DiscountedItems();
                }
            }
        }
    }
}
