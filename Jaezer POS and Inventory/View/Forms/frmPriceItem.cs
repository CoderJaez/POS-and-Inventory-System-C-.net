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
using System.Drawing.Text;
using System.IO;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmPriceItem : Form
    {
        PricingModel model = new PricingModel();
        PriceItem obj = new PriceItem();
        PrintPreviewDialog pd = new PrintPreviewDialog();
        PrivateFontCollection pfc = new PrivateFontCollection();
        ToolTip toolTip;
        private bool isForUpdate;
        int w = 100;
        int h = 50;
        int barcodes = 100;
        int rows = 0;
        int cols = 0;
        int x = 20, y = 10;


        public frmPriceItem(bool forUpdate, PriceItem _obj)
        {
            InitializeComponent();
            isForUpdate = forUpdate;
            ProdName.Text = $"{_obj.ProductName.ToUpper()} Item Price";
            obj = _obj;
            UnitList();
            if (isForUpdate)
                PriceItemInfo();
            toolTip = new ToolTip();
            toolTip.SetToolTip(btnScanBarcode, "Scan Barcode");
            toolTip.SetToolTip(btnGenerateBarcode, "Generate Barcode");
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

        private void ean13()
        {
            string barcode, check12Digits;
            check12Digits = txtBarcode.Text.PadRight(12, '0');
            barcode = EAN13.CODE(check12Digits);
            pfc.AddFontFile(Directory.GetCurrentDirectory() + "/ean13.ttf");
            labelEAN13.Font = new Font(pfc.Families[0], 24);
            labelEAN13.Text = barcode;


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
            rows = barcodes / 6;
            cols = barcodes % 6;
            pd.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Legal", 850, 1100);
            (pd as Form).WindowState = FormWindowState.Maximized;
            pd.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int pageHeight = (int)e.PageSettings.PrintableArea.Height;
            //x = 10;
            //e.Graphics.DrawString(labelEAN13.Text, new Font(pfc.Families[0], 30), new SolidBrush(Color.Black), x, y);
            for (int i = 1; i <= rows; i++)
            {
                //x = 50;
                x = 20;
                for (int z = 1; z <= 6; z++)
                {
                    e.Graphics.DrawString(labelEAN13.Text, new Font(pfc.Families[0], 30), new SolidBrush(Color.Black), x, y);
                    //x = x + w + 25;
                    x += 130;
                }
                //y = y + h + 35;
                y += 60;

                if (y >= pageHeight)
                {
                    e.HasMorePages = true;
                    y = 10;
                    rows -= 13;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }

            }

            if (cols > 1)
            {
                x = 20;
                for (int z = 1; z <= cols; z++)
                {
                    e.Graphics.DrawString(labelEAN13.Text, new Font(pfc.Families[0], 30), new SolidBrush(Color.Black), x, y);
                    //e.Graphics.DrawImage(BarcodeImage.Image, x, y, w, h);
                    //x = x + w + 30;
                    x += 130;
                }
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
           if(txtBarcode.Text != "" && txtBarcode.Text.Length >=12)
            {
                txtBarcode.Text = txtBarcode.Text.Substring(0, 12);
                ean13();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void btnScanBarcode_Click(object sender, EventArgs e)
        {
            barcode.Focus();
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = model.GenerateBarcode();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                 e.Handled = true;
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            txtBarcode.Text = barcode.Text;
        }

        private void frmPriceItem_Shown(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }

       
    }
}
