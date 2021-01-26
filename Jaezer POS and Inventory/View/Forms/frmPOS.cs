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
using FluentValidation.Results;
namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmPOS : Form, IPaymentTransaction
    {
        SalesTransactionModel smodel = new SalesTransactionModel();
        User UserInfo;

        public frmPOS(User _user)
        {
            InitializeComponent();
            UserInfo = _user;
            lblName.Text = UserInfo.Fullname ;
            NewTransaction();
        }

        public DataGridViewRow ProductItem { get { return ProductCartDG.CurrentRow; } }
        public int PaymentID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string InvoiceNo
        {
            get
            {
                return lblTransactionNo.Text;
            }

            set
            {
                lblTransactionNo.Text = value;
            }
        }

        public decimal SubTotal
        {
            get
            {
                return decimal.Parse(lblVatSales.Text);
            }

            set
            {
                lblVatSales.Text = value.ToString();
            }
        }

        public decimal CashTendered { get; set; }
        public decimal Change { get; set; }
        public decimal Vat
        {
            get
            {
                return decimal.Parse(lblVat.Text);
            }

            set
            {
                lblVat.Text = value.ToString();
            }
        }

        public decimal Total
        {
            get { return decimal.Parse(lblTotalSales.Text); } set { lblTotalSales.Text = value.ToString(); }
        }
        public decimal Discount
        {
            get
            {
               return decimal.Parse(lblDiscount.Text);
            }

            set
            {
                lblDiscount.Text = value.ToString();
            }
        }

        public decimal AmountDue
        {
            get
            {
                return decimal.Parse(lblAmountDue.Text);
            }

            set
            {
                lblAmountDue.Text = value.ToString();
            }
        }

        public string SDate
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }
            set { }

            
        }

        public int UserID
        {
            get
            {
                return UserInfo.UserID;
            }
            set { }

          
        }

     


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            closePOS();
        }

        private void closePOS()
        {
            if(UserInfo.UserType == "Admin")
                this.Close();
            else
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F10:
                    closePOS();
                    break;
                case Keys.F1:
                    SearchTxt.Focus();
                    break;
                case Keys.F2:
                    frmProductInquiry frm = new frmProductInquiry(this);
                    frm.ShowDialog();
                    break;
                case Keys.F3:
                    frmDiscount disc = new frmDiscount(this);
                    disc.ShowDialog();
                    break;
                case Keys.F4:
                    SettlePayments();
                    break;
                case Keys.F5:
                    CancelTransaction();
                    break;
                case Keys.F6:
                    ShowDailySales();
                    break;
                case Keys.F7:
                    ChangePassword();
                    break;

            }
    
        }

        private void ChangePassword()
        {
            frmChangePass frm = new frmChangePass(UserInfo,false);
            frm.ShowDialog();
        }

        public List<ProductCart> ProductList()
        {
            var list = new List<ProductCart>();
            foreach(DataGridViewRow item in ProductCartDG.Rows)
            {
                var prod = new ProductCart();
                prod.Invoice = lblTransactionNo.Text;
                prod.ProductID = int.Parse(item.Cells["prodID"].Value.ToString());
                prod.PriceID = int.Parse(item.Cells["prID"].Value.ToString());
                prod.ProductName = item.Cells["productName"].Value.ToString();
                prod.Price = decimal.Parse(item.Cells["price"].Value.ToString());
                prod.Total = decimal.Parse(item.Cells["total"].Value.ToString());
                prod.Discount = decimal.Parse(item.Cells["disc"].Value.ToString());
                prod.Qty = int.Parse(item.Cells["qty"].Value.ToString());
                prod.UnitCode = item.Cells["prUnit"].Value.ToString();
                prod.PrQty = int.Parse(item.Cells["prQty"].Value.ToString()) * prod.Qty;
                prod.HasExpiry = (bool)item.Cells["hasExpiry"].Value;
                prod.IsSale = (bool)item.Cells["isSale"].Value;
                prod.SDate = DateTime.Now.ToString("yyyy-MM-dd");
                prod.UserID = UserID;
                list.Add(prod);
            }
            return list;
        }

        private void btnProductInq_Click(object sender, EventArgs e)
        {
            frmProductInquiry frm = new frmProductInquiry(this);
            frm.ShowDialog();
        }

        private void btnNewTransact_Click(object sender, EventArgs e)
        {
            NewTransaction();
        }


        private void NewTransaction()
        {
            lblTransactionNo.Text = smodel.NewTransaction();
        }
        private void CancelTransaction()
        {
            var result = MessageBox.Show("Cancel Transaction?", smodel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                lblTotal.Text = "0.00";
                lblTotalSales.Text = "0.00";
                lblVat.Text = "0.00";
                lblVatSales.Text = "0.00";
                lblAmountDue.Text = "0.00";
                lblDiscount.Text = "0.00";
                ProductCartDG.Rows.Clear();
            }
            
        }

        public void AddToCart(ProductCart prod)
        {
            bool HasDuplicate = false;
            foreach (DataGridViewRow item in ProductCartDG.Rows)
            {
                if (item.Cells["prID"].Value.ToString() == prod.PriceID.ToString())
                {
                    HasDuplicate = true;
                    if ((int.Parse(item.Cells["qty"].Value.ToString()) + prod.Qty) * int.Parse(item.Cells["prQty"].Value.ToString()) > prod.Onhand)
                    {
                        MessageBox.Show($"The {prod.ProductName} quantity has reached the max stock onhand.");
                        return;
                    }
                    item.Cells["onhand"].Value = prod.Onhand;
                    item.Cells["qty"].Value = int.Parse(item.Cells["qty"].Value.ToString()) + prod.Qty;
                    item.Cells["total"].Value = (decimal.Parse(item.Cells["price"].Value.ToString()) * decimal.Parse(item.Cells["qty"].Value.ToString())) - decimal.Parse(item.Cells["disc"].Value.ToString());
                }
            }
            if(!HasDuplicate)
            {
                ProductCartDG.Rows.Add(prod.PriceID,prod.ProductID,ProductCartDG.RowCount + 1, prod.ProductName,prod.Price,prod.Qty, prod.UnitCode, "0.00", prod.Total, prod.PrQty, prod.Onhand,prod.HasExpiry,prod.IsSale);
            }
            if(ProductCartDG.Rows.Count > 0 )
                ProductCartDG.Rows[0].Selected = false;
            ComputePayments();
        }

        public void ComputePayments()
        {
            Total = 0;
            Discount = 0;
            foreach (DataGridViewRow item in ProductCartDG.Rows)
            {
                Total += decimal.Parse(item.Cells["total"].Value.ToString());
                Discount += decimal.Parse(item.Cells["disc"].Value.ToString());
            }

            decimal _vat = smodel.vat();
            Total = Math.Round(Total, 2);
            AmountDue = Total;
            Vat = Math.Round((AmountDue * _vat) / (decimal)1.12,2);
            SubTotal = Math.Round(AmountDue - Vat,2);
            lblTotal.Text = Total.ToString("N");
        }

        private void SettlePayments()
        {
            if ( AmountDue > 0)
            {
                frmSettlePayment frm = new frmSettlePayment(this);
                frm.ShowDialog();
            }
              
        }


        private void btnCancelTransact_Click(object sender, EventArgs e)
        {
            CancelTransaction();

        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {

            SettlePayments();
        }

        public void ClearTransaction()
        {
            NewTransaction();
            lblTotal.Text = "0.00";
            lblTotalSales.Text = "0.00";
            lblVat.Text = "0.00";
            lblVatSales.Text = "0.00";
            lblDiscount.Text = "0.00";
            lblAmountDue.Text = "0.00";
            ProductCartDG.Rows.Clear();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
           if(SearchTxt.Text != "")
            {
                var model = new InventoryModel();
                var obj = model.getProduct(SearchTxt.Text);
                if (obj.ProductName != null)
                {
                    AddToCart(obj);
                    SearchTxt.Text = "";
                }
            }
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (ProductCartDG.Rows.Count > 0 && ProductCartDG.CurrentRow.Selected)
            {
                frmDiscount disc = new frmDiscount(this);
                disc.ShowDialog();
            }
        }

        
        private void ProductCartDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch(ProductCartDG.Columns[e.ColumnIndex].Name)
                {
                    case "sub":
                        if(int.Parse(ProductCartDG.CurrentRow.Cells["qty"].Value.ToString()) > 1)
                        {
                            ProductCartDG.CurrentRow.Cells["qty"].Value = int.Parse(ProductCartDG.CurrentRow.Cells["qty"].Value.ToString()) - 1;
                            ProductCartDG.CurrentRow.Cells["total"].Value = (decimal.Parse(ProductCartDG.CurrentRow.Cells["price"].Value.ToString()) * decimal.Parse(ProductCartDG.CurrentRow.Cells["qty"].Value.ToString())) - decimal.Parse(ProductCartDG.CurrentRow.Cells["disc"].Value.ToString());
                        } else
                        {
                            ProductCartDG.Rows.Remove(ProductCartDG.CurrentRow);
                        }
                        break;
                    case "add":
                        if((int.Parse(ProductCartDG.CurrentRow.Cells["qty"].Value.ToString()) + 1) * (int)ProductCartDG.CurrentRow.Cells["prQty"].Value > (int)ProductCartDG.CurrentRow.Cells["onhand"].Value)
                        {
                            MessageBox.Show($"The {ProductCartDG.CurrentRow.Cells["productName"].Value.ToString()} quantity has reached the max stock onhand.");
                            return;
                        }
                        ProductCartDG.CurrentRow.Cells["qty"].Value = int.Parse(ProductCartDG.CurrentRow.Cells["qty"].Value.ToString()) + 1;
                        ProductCartDG.CurrentRow.Cells["total"].Value = (decimal.Parse(ProductCartDG.CurrentRow.Cells["price"].Value.ToString()) * decimal.Parse(ProductCartDG.CurrentRow.Cells["qty"].Value.ToString())) - decimal.Parse(ProductCartDG.CurrentRow.Cells["disc"].Value.ToString());
                        break;
                    case "delete":
                        var result = MessageBox.Show("Do you want to delete selected row?",smodel.AppName,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                            ProductCartDG.Rows.Remove(ProductCartDG.CurrentRow);
                        break;

                }
                ComputePayments();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ShowDailySales();
        }

        private void ShowDailySales()
        {
            frmDailySales frm = new frmDailySales(UserInfo.UserID.ToString(),UserInfo.Fullname);
            frm.ShowDialog();
        }

        private void frmPOS_Shown(object sender, EventArgs e)
        {
            SearchTxt.Focus();
        }
    }
}
