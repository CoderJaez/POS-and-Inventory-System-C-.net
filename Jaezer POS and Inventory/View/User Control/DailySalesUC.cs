using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.Model;
using Jaezer_POS_and_Inventory.View.Forms;
using Microsoft.Reporting.WinForms;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class DailySalesUC : UserControl
    {
        SalesTransactionModel stModel = new SalesTransactionModel();
        UserModel uModel = new UserModel();
        CompanyProfileModel pmodel = new CompanyProfileModel();
        private frmMain main;
        public DailySalesUC(frmMain _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void UserList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserID");
            dt.Columns.Add("Uname");
            dt.Rows.Add("", "");
            cbUserID.DisplayMember = "Uname";
            cbUserID.ValueMember = "UserID";
            foreach (var item in uModel.GetUser(""))
            {
                dt.Rows.Add(item.UserID, $"{item.UserType} | {item.Fullname}");
            }

            cbUserID.DataSource = dt;
        }

        public void SoldItemList()
        {
            string dFrom = Convert.ToDateTime(datePFrom.Value).ToString("yyyy-MM-dd");
            string dTo = Convert.ToDateTime(datePTo.Value).AddDays(1).ToString("yyyy-MM-dd");
            decimal TotalSales = 0;
            decimal TotalDiscount = 0;
            decimal TotalProfit = 0;
            int TotalQty = 0;
            SoldItemsDG.Rows.Clear();
            foreach (var item in stModel.SoldItems(dFrom, dTo, cbUserID.SelectedValue.ToString(),""))
            {
                item.ProductName += item.IsSale ? " SALE" : "";
                SoldItemsDG.Rows.Add(item.CartID, item.Invoice, item.ProductName, item.Price,item.SPrice, item.Qty, item.UnitCode, item.Discount, item.Total,item.Total - (item.Price * item.Qty),item.SDate,item.User);
                TotalQty += item.Qty;
                TotalDiscount += item.Discount;
                TotalSales += item.Total;
                TotalProfit += item.Total - (item.Price * item.Qty);
            }

            SoldItemsDG.Rows.Add("","","","","TOTAL",TotalQty,"",TotalDiscount,TotalSales,TotalProfit);
            SoldItemsDG.Rows[SoldItemsDG.RowCount - 1].DefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void DailySalesUC_Load(object sender, EventArgs e)
        {
            UserList();
            SoldItemList();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SoldItemList(); 
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            SalesPrintPreview();
        }

        private void SalesPrintPreview()
        {
            var list = new List<ProductCart>();
            var Profile = pmodel.getBusinessProfile();
            foreach (DataGridViewRow item in SoldItemsDG.Rows)
            {
                if (item.Cells["invoice"].Value.ToString() != "")
                {
                    list.Add(new ProductCart()
                    {
                        Invoice = item.Cells["invoice"].Value.ToString(),
                        ProductName = item.Cells["ProdName"].Value.ToString(),
                        Qty = int.Parse(item.Cells["qty"].Value.ToString()),
                        Price = decimal.Parse(item.Cells["CostPrice"].Value.ToString()),
                        SPrice = decimal.Parse(item.Cells["Price"].Value.ToString()),
                        Discount = decimal.Parse(item.Cells["discount"].Value.ToString()),
                        UnitCode = item.Cells["unit"].Value.ToString(),
                        Total = decimal.Parse(item.Cells["total"].Value.ToString()),
                        SDate = item.Cells["sdate"].Value.ToString(),
                        Profit = decimal.Parse(item.Cells["Profit"].Value.ToString())
                    });
                }
               
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
            frmPrintPreview frm = new frmPrintPreview(rs,rdlc, p);
            
            frm.ShowDialog();

        }

        private void SoldItemsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SoldItemsDG.Columns[e.ColumnIndex].Name == "cancel" && e.RowIndex != SoldItemsDG.RowCount)
                {
                    if (SoldItemsDG.CurrentRow.Cells["CatID"].Value.ToString() != "")
                    {
                        int id = (int)SoldItemsDG.CurrentRow.Cells["CatID"].Value;
                        frmCancelOrder frm = new frmCancelOrder(id, main.UserInfo.UserID, main.UserInfo.Fullname, false, this);
                        frm.ShowDialog();
                    }

                }
            }
        }
    }
}
