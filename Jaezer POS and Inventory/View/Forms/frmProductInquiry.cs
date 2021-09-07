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
using System.Text.RegularExpressions;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmProductInquiry : Form
    {
        InventoryModel model = new InventoryModel();
        frmPOS uc; 
        public frmProductInquiry(frmPOS _uc)
        {
            InitializeComponent();
            uc = _uc;
        }

        private void frmProductInquiry_Load(object sender, EventArgs e)
        {
            ProductPriceList();
        }

        private void ProductPriceList()
        {
            ProdPriceDG.Rows.Clear();
            Decimal price = 0;
            foreach (var item in model.ProductInquiryList(SearchTxt.Text))
            {
                price = item.Price;
                if(item.IsSale && (DateTime.ParseExact(item.SDateFrm,"MM-dd-yyyy",null) <= DateTime.Today && DateTime.ParseExact(item.SDateTo,"MM-dd-yyyy",null) >= DateTime.Today))
                {
                    item.ProductName +=  " SALE";
                    price = item.SPrice;
                }

                ProdPriceDG.Rows.Add(item.PriceID,item.ProductID,$"{ProdPriceDG.Rows.Count +1}. " ,$"({item.PriceUnit}) {item.ProductName.ToUpper()}", $"{item.Onhand} {item.ProdUnit}" , price, item.Price - item.SPrice, item.PriceUnit, item.PriceQty, item.HasExpiry,item.IsSale);
                if (item.Onhand <= item.ReOrder)
                    ProdPriceDG.Rows[ProdPriceDG.Rows.Count-1].DefaultCellStyle.BackColor = Color.OrangeRed;
            }
            if(ProdPriceDG.Rows.Count > 0 )
                ProdPriceDG.Rows[0].Selected = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductInquiry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F1)
                SearchTxt.Focus();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            ProductPriceList();
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ProdPriceDG.Focus();
            
        }

        private void ProdPriceDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(ProdPriceDG.Columns[e.ColumnIndex].Name == "add")
                {
                    panelQty.Visible = true;
                    ProdPriceDG.Enabled = false;
                    txtQty.Focus();
                }
            }
        }

        private void ProdPriceDG_KeyDown(object sender, KeyEventArgs e)
        {
            if(ProdPriceDG.Rows.Count > 0)
            {
                if(e.KeyCode == Keys.Enter )
                {
                    e.Handled = true;
                    panelQty.Visible = true;
                    ProdPriceDG.Enabled = false;
                    txtQty.Focus();
                    return;
                }
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQty.Text == "")
                    return;
                int onhand = int.Parse(Regex.Replace(ProdPriceDG.CurrentRow.Cells["Onhand"].Value.ToString(), "[^0-9.]", ""));

                if (int.Parse(txtQty.Text) * (int)ProdPriceDG.CurrentRow.Cells["prQty"].Value > onhand)
                    return;
                var obj = new ProductCart();
                obj.PriceID = (int)ProdPriceDG.CurrentRow.Cells["PriceID"].Value;
                obj.ProductID = (int)ProdPriceDG.CurrentRow.Cells["ProdID"].Value;
                //obj.Variant = ProdPriceDG.CurrentRow.Cells["Variant"].Value.ToString();
                obj.ProductName = ProdPriceDG.CurrentRow.Cells["ProductName"].Value.ToString();
                obj.Price = (decimal)ProdPriceDG.CurrentRow.Cells["Price"].Value;
                obj.UnitCode = ProdPriceDG.CurrentRow.Cells["prUnit"].Value.ToString();
                obj.Qty = int.Parse(txtQty.Text);
                obj.Total = obj.Price * obj.Qty;
                obj.PrQty = (int)ProdPriceDG.CurrentRow.Cells["prQty"].Value;
                obj.Onhand = onhand;
                obj.IsSale = (bool)ProdPriceDG.CurrentRow.Cells["IsSale"].Value;
                obj.HasExpiry = (bool)ProdPriceDG.CurrentRow.Cells["hasExpiry"].Value;
                uc.AddToCart(obj);
                panelQty.Visible = false;
                txtQty.Text = "1";
                ProdPriceDG.Enabled = true;
                ProdPriceDG.Focus();
            }
          
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void frmProductInquiry_Shown(object sender, EventArgs e)
        {
            SearchTxt.Focus();
        }
    }
}
