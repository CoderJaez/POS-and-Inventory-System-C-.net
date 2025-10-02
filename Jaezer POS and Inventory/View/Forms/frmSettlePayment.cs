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
using System.Drawing.Printing;
using System.Threading;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmSettlePayment : Form
    {
        PrintPreviewDialog ppd = new PrintPreviewDialog();
        frmPOS pos;
        SalesTransactionModel smodel = new SalesTransactionModel();
        frmLoadingScreen load = new frmLoadingScreen();
        Supplier sp;
        List<ProductCart> ProdList;
        PaymentTransaction pt;
        private string Header { get; set; }
        private string Body { get; set; }
        private string Footer { get; set; }
        private int prntAreaWidth = 0;
        private string StringToPrnt;
        float leading = 4;
        Font bft = new Font("Arial Narrow", 7);
        Font hft = new Font("Arial Narrow", 7);
        float startX = 0;
        float startY = 0;
        float lineheight12 = 0;
        float lineheight10 = 0;
        Graphics g;
        float offsetY = 0;

        struct DataParams
        {
            public int Process;
            public int Delay;
        }
        private DataParams InputParams;
        public frmSettlePayment(frmPOS _pos)
        {
            InitializeComponent();
            pos = _pos;
            sp = new CompanyProfileModel().getBusinessProfile();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "6";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "0";

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "00";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCashTender.Text = "";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCashTender.Text += "9";

        }

        private void txtCashTender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtCashTender.Text == "") 
            return;

            MakePayment();
        }

        private void frmSettlePayment_Shown(object sender, EventArgs e)
        {
            lblTotal.Text = pos.AmountDue.ToString("N"); 
            txtCashTender.Focus();
        }

        private void MakePayment()
        {
             ProdList = pos.ProductList();
             pt = new PaymentTransaction();
            pt.AmountDue = pos.AmountDue;
            pt.Discount = pos.Discount;
            pt.InvoiceNo = pos.InvoiceNo;
            pt.SDate = pos.SDate;
            pt.SubTotal = pos.SubTotal;
            pt.Total = pos.Total;
            pt.UserID = pos.UserID;
            pt.Vat = pos.Vat;
            pt.CashTendered = decimal.Parse(txtCashTender.Text);
            pt.Change = decimal.Parse(lblChange.Text);
            if(decimal.Parse(txtCashTender.Text) >= pos.AmountDue)
            {
                if(!backgroundWorker.IsBusy)
                {
                    InputParams.Delay = 200;
                    InputParams.Process = ProdList.Count();
                    backgroundWorker.RunWorkerAsync(InputParams);
                    load.ShowDialog();
                }
            }
        }

        private void txtCashTender_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtCashTender.Text == "")
                    return;
                MakePayment();
            }
        }

        private void txtCashTender_TextChanged(object sender, EventArgs e)
        {
            if(txtCashTender.Text != "")
            {
                lblChange.Text = (decimal.Parse(txtCashTender.Text) - pos.AmountDue).ToString("N");
            }
        }

        private void ReceiptDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            startY = leading;
            lineheight12 = hft.GetHeight() + leading;
            lineheight10 = bft.GetHeight() + leading;
            StringFormat formatleft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatleft);
            StringFormat formatRight = new StringFormat(formatleft);
            float offset = 0;
            formatCenter.Alignment = StringAlignment.Center;
            formatRight.Alignment = StringAlignment.Far;
            formatleft.Alignment = StringAlignment.Near;

            SizeF layoutSize = new SizeF(prntAreaWidth - offset * 2, lineheight12);
            RectangleF layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString(sp.BusinessName, hft, new SolidBrush(Color.Black), layout, formatCenter);//Business Name;
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString(sp.CompleteAddress, bft, new SolidBrush(Color.Black), layout, formatCenter); //Address


            offset += lineheight10 + 10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString(sp.ContactNo, bft, new SolidBrush(Color.Black), layout, formatCenter); //Contact No


            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"Date: {DateTime.Now.ToString("MM/dd/yyyy")}", bft, new SolidBrush(Color.Black), layout, formatleft);
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"TRAN#:{ProdList.First().Invoice}", bft, new SolidBrush(Color.Black), layout, formatleft);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("===========================", bft, new SolidBrush(Color.Black), layout, formatCenter);
            foreach (var item in ProdList)
            {
                offset += lineheight10;
                layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
                e.Graphics.DrawString(item.ProductName, bft, new SolidBrush(Color.Black), layout, formatleft);
                e.Graphics.DrawString($"₱{item.Total.ToString("N2")}", bft, new SolidBrush(Color.Black), layout, formatRight);

                offset += lineheight10;
                layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
                e.Graphics.DrawString($"{item.Qty} X ₱{item.Price.ToString("N2")}", bft, new SolidBrush(Color.Black), layout, formatleft);

            }
            offset += lineheight10 + offsetY;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("===========================", bft, new SolidBrush(Color.Black), layout, formatCenter); //Contact No
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"{ProdList.Count} ITEM(S)", bft, new SolidBrush(Color.Black), layout, formatleft);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("TOTAL", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString($"₱{pt.Total.ToString()}", bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("CASH RCVD", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString($"₱{pt.CashTendered.ToString("N2")}", bft, new SolidBrush(Color.Black), layout, formatRight);
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("CHANGE", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString($"₱{pt.Change.ToString("N")}", bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("===========================", bft, new SolidBrush(Color.Black), layout, formatCenter); //Contact No

          
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("THIS IS NOT AN OFFICIAL RECIEPT", bft, new SolidBrush(Color.Black), layout, formatCenter);
            offset += lineheight10*2;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("HAVE A NICE DAY!", bft, new SolidBrush(Color.Black), layout, formatCenter);
        }


        private void PrintReciept()
        {
            ReceiptDoc.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 190, int.MaxValue);
            prntAreaWidth = ReceiptDoc.DefaultPageSettings.PaperSize.Width;


            ReceiptDoc.Print();
            //ppd.Document = ReceiptDoc;
            //ppd.ShowDialog();
        }

        private static string getStrSplit(string x, int length)
        {
            string result = string.Empty;
            if (x.Length <= length)
            {
                return x;
            }
            else
            {
                var sub = x.Substring(0, length);
                result += sub + "\n" + getStrSplit(x.Replace(sub, ""), length);
            }
            return result;
        }

        private string itemFormat(string item, int qty, decimal price, decimal amnt)
        {
            lineheight10 = bft.GetHeight() + leading;
            var outStr = getStrSplit(item, 10);
            var outlst = outStr.Split('\n').ToList();
            string output = string.Empty;
            output += string.Format("{0,-10}{1,10:N2}{2,8:N2}\n", qty +" "+outlst[0], price, " " + amnt);
            if (outlst.Count > 1)
            {
                foreach (var i in outlst.Skip(1))
                {
                    output += string.Format("{0,-10}\n", "   " + i);
                }
            }

            if (outlst.Count > 1 && outlst.Count <= 2)
                offsetY += lineheight10 + 15;
            else if (outlst.Count > 2)
                offsetY += lineheight10 + 32;
            else
                offsetY += lineheight10;
            return output;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParams)e.Argument).Process;
            int delay = ((DataParams)e.Argument).Delay;
            int index = 1;
            try
            {
                foreach (var item in ProdList)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        if(smodel.insert(item))
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
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            load.pb.Value = e.ProgressPercentage;
            load.pb.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pos.ClearTransaction();
            this.Hide();
            this.Close();
            load.Close();
            if(Properties.Settings.Default.enableRP)
                PrintReciept();
            frmChange frm = new frmChange(lblChange.Text);
            frm.ShowDialog();
        }
    }
}
