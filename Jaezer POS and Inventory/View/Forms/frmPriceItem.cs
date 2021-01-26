using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using Jaezer_POS_and_Inventory.Model;
using Zen.Barcode;
using System.Drawing.Printing;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmPriceItem : Form
    {
        PricingModel model = new PricingModel();
        PriceItem obj = new PriceItem();
        PrintPreviewDialog pd = new PrintPreviewDialog();
        private bool isForUpdate;
        int w = 223;
        int h = 74;
        public frmPriceItem(bool forUpdate, PriceItem _obj)
        {
            InitializeComponent();
            isForUpdate = forUpdate;
            ProdName.Text = $"{_obj.ProductName.ToUpper()} Item Price";
            obj = _obj;
            UnitList();
            if (isForUpdate)
                PriceItemInfo();
        }

        
        private void UnitList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("unit");

            dt.Rows.Add("", "");
            foreach (var item in model.getProduct(obj.ProductID).UnitList)
            {
                dt.Rows.Add(item.ugID, item.UnitCode);
                if (item.DefaultUnit)
                {
                    txtUnit.Text = item.UnitCode;
                    continue;
                }
            }
            cbUnitCode.DataSource = dt;
        }



        private void PriceItemInfo()
        {
            cbUnitCode.Text = obj.Brand;
            txtBarcode.Text = obj.Barcode;
            txtVariant.Text = obj.Variant;
            txtPrice.Text = obj.Price.ToString();
        }
        private void clear()
        {
            txtBarcode.Text = "";
            txtPrice.Text = "";
            txtVariant.Text = "";
            cbUnitCode.Text = "";
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {

            obj.Barcode = txtBarcode.Text;
            obj.Variant = txtVariant.Text;
            obj.Price = (txtPrice.Text != "")? double.Parse(txtPrice.Text):0;
            obj.UnitID = (cbUnitCode.Text != "") ? int.Parse(cbUnitCode.SelectedValue.ToString()):0;
            obj.UnitCode = cbUnitCode.Text;
            var rules = new PriceItemValidator();
            var result = rules.Validate(obj);
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
                if(model.insert(obj))
                {
                    MessageBox.Show("New Price Registration Successfull", model.AppName);
                }
            } else
            {
                if(model.update(obj))
                {
                    MessageBox.Show("Price Update Successfull", model.AppName);
                    this.Close();
                }
            }
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void code128()
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var image = barcode.Draw(txtBarcode.Text, 50);
            var resultImage = new Bitmap(image.Width, image.Height + 20); // 20 is bottom padding, adjust to your text

            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new Font("Consolas", 10))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center, // Also, horizontally centered text, as in your example of the expected output
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(image, 0, 0);
                graphics.DrawString(txtBarcode.Text, font, brush, resultImage.Width / 2, resultImage.Height, format);
            }

            BarcodeImage.Image = resultImage;
          
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            pd.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Legal", 850, 1100);
            pd.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 40, y = 10;
            for (int i = 1; i <= 10; i++)
            {
                x = 50;
                for (int z = 1; z <= 3; z++)
                {
                    e.Graphics.DrawImage(BarcodeImage.Image, x, y, w, h);
                    x = x + w + 40;
                }
                y = y + h + 35;
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
           if(txtBarcode.Text != "")
            {
                code128();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void frmPriceItem_Shown(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }

       
    }
}
