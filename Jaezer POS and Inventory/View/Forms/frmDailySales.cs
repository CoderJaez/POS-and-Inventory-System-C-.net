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
using Microsoft.Reporting.WinForms;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmDailySales : Form
    {
        SalesTransactionModel stModel = new SalesTransactionModel();
        CompanyProfileModel pmodel = new CompanyProfileModel();
        string UserID;
        string UserName;
        public frmDailySales(string _UserID, string _Uname)
        {
            InitializeComponent();
            UserID = _UserID;
            UserName = _Uname;
            SoldItemList();
        }
        public void SoldItemList()
        {
            string dFrom = DateTime.Now.ToString("yyyy-MM-dd");
            string dTo = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            decimal total = 0;
            int totalQty = 0;
            decimal totalDisc = 0;
            decimal TotalProfits = 0;
            int i = 1;
            SoldItemsDG.Rows.Clear();
            foreach (var item in stModel.SoldItems(dFrom, dTo, UserID, SearchTxt.Text))
            {
                item.ProductName += item.IsSale ? " SALE" : "";
                SoldItemsDG.Rows.Add(item.CartID, i++,item.Invoice, item.ProductName, item.Price,item.SPrice, item.Qty, item.UnitCode, item.Discount, item.Total, item.Total - (item.Qty * item.Price), item.SDate);
                total += item.Total;
                totalQty += item.Qty;
                totalDisc += item.Discount;
                TotalProfits += item.Total - (item.Qty * item.Price);
            }
            SoldItemsDG.Rows.Add("", "", "","", "", "Total", totalQty, "", totalDisc, total,TotalProfits,"",null);
            SoldItemsDG.Rows[--i].DefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void SalesPrintPreview()
        {
            var list = new List<ProductCart>();
            var Profile = pmodel.getBusinessProfile();
            foreach (DataGridViewRow item in SoldItemsDG.Rows)
            {
                if (item.Cells["invoice"].Value.ToString() == "")
                    continue;
                var obj = new ProductCart()
                {
                    Invoice = item.Cells["invoice"].Value.ToString(),
                    ProductName = item.Cells["ProdName"].Value.ToString(),
                    Qty = int.Parse(item.Cells["qty"].Value.ToString()),
                    Price = decimal.Parse(item.Cells["price"].Value.ToString()),
                    UnitCode = item.Cells["unit"].Value.ToString(),
                    Discount = decimal.Parse(item.Cells["discount"].Value.ToString()),
                    Total = decimal.Parse(item.Cells["total"].Value.ToString()),
                    SDate = item.Cells["sdate"].Value.ToString()
                };
                list.Add(obj);
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "SalesHistory";
            rs.Value = list;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.SalesRprt.rdlc";
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("BusinessName", Profile.BusinessName),
                new ReportParameter("Address", Profile.CompleteAddress),
                new ReportParameter("ContactNo", Profile.ContactNo),
                new ReportParameter("Logo", Convert.ToBase64String(Profile.logo)),
            };
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);

            frm.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            SalesPrintPreview();
        }

        private void SoldItemsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(SoldItemsDG.Columns[e.ColumnIndex].Name == "cancel")
                {
                    if(SoldItemsDG.CurrentRow.Cells["CatID"].Value.ToString() != "")
                    {
                        int id = (int)SoldItemsDG.CurrentRow.Cells["CatID"].Value;
                        frmCancelOrder frm = new frmCancelOrder(id, int.Parse(UserID), UserName,true, this);
                        frm.ShowDialog();
                    }
                    
                }
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            SoldItemList();
        }
    }
}
