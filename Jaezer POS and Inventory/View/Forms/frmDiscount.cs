using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmDiscount : Form
    {
        frmPOS pos;
        Discount obj = new Discount();
        public frmDiscount(frmPOS _pos)
        {
            InitializeComponent();
            pos = _pos;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ComputeDiscount();
        }

        private void cbPercent_CheckedChanged(object sender, EventArgs e)
        {
            cbAmount.Checked = false;
            obj.Type = (bool)cbPercent.Checked ? cbPercent.Text : ""; 
        }

        private void cbAmount_CheckedChanged(object sender, EventArgs e)
        {
            cbPercent.Checked = false;
            obj.Type = (bool)cbAmount.Checked ? cbAmount.Text : "";
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ComputeDiscount();
        }

        private void ComputeDiscount()
        {
            decimal total = 0;
            obj.Disc = txtDiscount.Text;
            var rules = new DiscountValidator();
            var result = rules.Validate(obj);
            string msg = null;
            decimal discount;
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    msg += $"{item.ErrorMessage} {item.ErrorCode} \n";
                    MessageBox.Show(msg);
                    return;
                }
            }
            discount = decimal.Parse(obj.Disc);
            if (obj.Type == cbPercent.Text)
            {
                total = decimal.Parse(pos.ProductItem.Cells["price"].Value.ToString()) * decimal.Parse(pos.ProductItem.Cells["qty"].Value.ToString());
                pos.ProductItem.Cells["disc"].Value = Math.Round( total * (discount / 100), 2);
            }
            else
            {
                total = decimal.Parse(pos.ProductItem.Cells["price"].Value.ToString()) * decimal.Parse(pos.ProductItem.Cells["qty"].Value.ToString());
                pos.ProductItem.Cells["disc"].Value = Math.Round(discount, 2);
            }
            pos.ProductItem.Cells["total"].Value = total - decimal.Parse(pos.ProductItem.Cells["disc"].Value.ToString());
            pos.ComputePayments();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Discount
    {
        public string Type { get; set; }
        public string Disc { get; set; }
    }


    class DiscountValidator:AbstractValidator<Discount>
    {
        public DiscountValidator()
        {
            RuleFor(type => type.Type)
                .NotEmpty().WithName("Discount Type");
            RuleFor(disc => disc.Disc)
                .NotEmpty().WithName("Discount Value");
        }
    }

}
