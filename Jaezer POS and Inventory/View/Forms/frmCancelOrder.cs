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
    public partial class frmCancelOrder : Form
    {
        SalesTransactionModel smodel = new SalesTransactionModel();
        ProductCart orderedItem;
        CancelOrder obj = new CancelOrder();
        frmDailySales frm;
        DailySalesUC uc;
        private bool FromPos;
        public frmCancelOrder(int _cartID, int _userID, string _uname, bool isFromPos, frmDailySales _frm)
        {
            InitializeComponent();
            obj.UserID = _userID;
            obj.UserName = _uname;
            GetOrderedItem(_cartID);
            FromPos = isFromPos;
            frm = _frm;
            _Remarks();
        }

        private void _Remarks()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("val");
            dt.Columns.Add("remarks");
            dt.Rows.Add("", "");
            dt.Rows.Add(1, "ERRONEOUS ENTRY");
            dt.Rows.Add(2, "DAMAGED");
            cbRemarks.ValueMember = "val";
            cbRemarks.DisplayMember = "remarks";
            cbRemarks.DataSource = dt;
        }
        public frmCancelOrder(int _cartID, int _userID, string _uname, bool isFromPos, DailySalesUC _uc)
        {
            InitializeComponent();
            obj.UserID = _userID;
            obj.UserName = _uname;
            GetOrderedItem(_cartID);
            FromPos = isFromPos;
            uc = _uc;
            _Remarks();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetOrderedItem(int cartID)
        {
            orderedItem = smodel.GetSoldItems(cartID);
            lblBarcode.Text = orderedItem.Barcode;
            lblProductName.Text = orderedItem.ProductName;
            lblInvoice.Text = orderedItem.Invoice;
            lblPrice.Text = orderedItem.Price.ToString("N");
            lblQty.Text = orderedItem.Qty.ToString();
            lblDiscount.Text = orderedItem.Discount.ToString();
            lblTotal.Text = orderedItem.Total.ToString("N");
        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            cbYes.Checked = true;
            cbNo.Checked = false;
        }

        private void cbNo_Click(object sender, EventArgs e)
        {
            cbYes.Checked = false;
            cbNo.Checked = true;
            cbRemarks.Text = "";
            cbRemarks.Enabled = true;
        }

        private void cbYes_Click(object sender, EventArgs e)
        {
            cbYes.Checked = true;
            cbNo.Checked = false;
            cbRemarks.SelectedValue = 1;
            cbRemarks.Enabled = false;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            obj.Qty = txtQty.Text != "" ? int.Parse(txtQty.Text):0;
            obj.Remarks = cbRemarks.Text;
            obj.RemarksVal = int.Parse(cbRemarks.SelectedValue.ToString());
            obj.HasATIcheck = cbNo.Checked || cbYes.Checked ? true : false;
            obj.IsAddToInventory = cbYes.Checked;
            var rules = new CancelOrderValidator(orderedItem.Qty);
            var result = rules.Validate(obj);
            string msg = null;
            if(!result.IsValid)
            {
                foreach (var item in result.Errors)
                    msg += $"{item.ErrorMessage} \n";
                MessageBox.Show(msg);
                return;
            }
            obj.SDate = DateTime.Now.ToString("yyyy-MM-dd");
            obj.Total = orderedItem.Price * (decimal)obj.Qty;
            obj.PrQty = obj.Qty * orderedItem.PrQty;

            if(FromPos)
            {
                frmAdminAccess frm = new frmAdminAccess(this);
                frm.ShowDialog();
            }
            else
            {
                CancelOrder();
            }
           
        }
        public void CancelOrder()
        {
            if (smodel.insertCancelOrder(obj, orderedItem))
            {
                MessageBox.Show("Purchased Item is now Cancelled.");
                this.Close();
                if (FromPos)
                    frm.SoldItemList();
                else
                    uc.SoldItemList();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
