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
    public partial class ReportsUC : UserControl
    {
        CompanyProfileModel pmodel = new CompanyProfileModel();
        InventoryModel model = new InventoryModel();
        SalesTransactionModel smodel = new SalesTransactionModel();
        ReportParameter[] p;

        public ReportsUC()
        {
            InitializeComponent();
            _YearList();
        }

        private void btnLDInventory_Click(object sender, EventArgs e)
        {
            InventoryList();
        }

        private void _YearList()
        {
            foreach (var item in model.YearList())
            {
                cbYearIS.Items.Add(item);
            }
        }


        private void InventoryList()
        {
            InventoryDG.Rows.Clear();
            int i = 0;
            foreach (var item in model.GetProductInventory("").ProductList)
            {
                InventoryDG.Rows.Add(i + 1, item.ProductName, item.Brand, item.Category, item.ReOrderLevel, item.Onhand, item.UnitCode);
                if (item.ReOrderLevel >= item.Onhand)
                    InventoryDG.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                i++;
            }
        }

        private void InventoryPrintPreview()
        {

            var list = new StockIn();

            foreach (DataGridViewRow item in InventoryDG.Rows)
            {
                var obj = new StockIn();
                obj.ProductName = item.Cells["ProductName"].Value.ToString();
                obj.Brand = item.Cells["Brand"].Value.ToString();
                obj.Category = item.Cells["Category"].Value.ToString();
                obj.ReOrderLevel = int.Parse(item.Cells["ReOrder"].Value.ToString());
                obj.Onhand = int.Parse(item.Cells["qty"].Value.ToString());
                obj.UnitCode = item.Cells["unit"].Value.ToString();
                list.ProductList.Add(obj);
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "InventoryList";
            rs.Value = list.ProductList;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.InventoryRpt.rdlc";
            ReportParams();
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }

        private void ExpiryItemsList()
        {
            ExpiryItemsDG.Rows.Clear();
            int i = 0;
            foreach (var item in model.ExpiryItems().ProductList)
            {
                ExpiryItemsDG.Rows.Add(++i, item.ReferenceNo, item.ProductName, item.DateArrival, item.DateExpiry, item.DayBeforeExpiry, item.Onhand, item.UnitCode);
            }
        }

        private void ExpiryItemsPrintPrintPreview()
        {
            var list = new StockIn();
            foreach (DataGridViewRow item in ExpiryItemsDG.Rows)
            {
                list.ProductList.Add(new StockIn()
                {
                    ReferenceNo = item.Cells["ReferenceNo"].Value.ToString(),
                    ProductName = item.Cells["_ProductName"].Value.ToString(),
                    DateArrival = item.Cells["DateArrival"].Value.ToString(),
                    DateExpiry = item.Cells["DateExpiry"].Value.ToString(),
                    DayBeforeExpiry = int.Parse(item.Cells["DaysBExp"].Value.ToString()),
                    Onhand = int.Parse(item.Cells["Onhand"].Value.ToString()),
                    UnitCode = item.Cells["_Unit"].Value.ToString()
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "ExpiryItems";
            rs.Value = list.ProductList;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.ExpiryItemsRpt.rdlc";
            ReportParams();
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }

        private void ReportParams()
        {
            var Profile = pmodel.getBusinessProfile();
            p = new ReportParameter[]
            {
                new ReportParameter("BusinessName", Profile.BusinessName),
                new ReportParameter("Address", Profile.CompleteAddress),
                new ReportParameter("ContactNo", Profile.ContactNo),
                new ReportParameter("Logo", Convert.ToBase64String(Profile.logo)),
                new ReportParameter("DateCreatedAt", ""),
            };
        }

        private void TopSellingList()
        {
            string dFrom = datePTSFrom.Value.AddDays(-1).ToString("yyyy-MM-dd");
            string dTo = datePTSTo.Value.AddDays(1).ToString("yyyy-MM-dd");
            if (!cbByQty.Checked && !cbByAmnt.Checked)
                return;
            string order_by = cbByAmnt.Checked ? "totalSales" : "totalQty";
            TopSellingDG.Rows.Clear();
            int i = 0;
            foreach (var item in smodel.GetTopSellingItems(dFrom,dTo,order_by))
            {
                TopSellingDG.Rows.Add(++i, item.ProductName, item.Total, item.Qty,item.UnitCode );
            }
        }

        private void TopSellingPrintPreview()
        {
            var list = new List<ProductCart>();
            string DateCreated = $"From {datePTSFrom.Value.ToString("MM-dd-yyyy")} To {datePTSTo.Value.ToString("MM-dd-yyyy")}";
            foreach (DataGridViewRow item in TopSellingDG.Rows)
            {
                list.Add(new ProductCart() {
                    ProductName = item.Cells["ProductNameTS"].Value.ToString(),
                    Qty = int.Parse(item.Cells["QtyTS"].Value.ToString()),
                    UnitCode = item.Cells["UnitTS"].Value.ToString(),
                    Total = decimal.Parse(item.Cells["SalesTS"].Value.ToString())
                });
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "TopSelling";
            rs.Value = list;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.TopSellingRpt.rdlc";
            ReportParams();
            p[p.Length - 1] = new ReportParameter("DateCreatedAt",DateCreated);
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }

        private void StockInHistory()
        {
            int i = 1;
            string dateFrom = datePSIFrom.Value.AddDays(-1).ToString("yyyy-MM-dd");
            string dateTo = datePSITo.Value.AddDays(1).ToString("yyyy-MM-dd");
            var stockModel = new StockinModel();
            StockInDG.Rows.Clear();
            foreach (var item in stockModel.GetStockInHistory(dateFrom, dateTo, "").ProductList)
            {
                StockInDG.Rows.Add(i++, item.ReferenceNo, item.ProductName, item.DateArrival, item.DateExpiry, item.Price, item.Qty, item.UnitCode, item.TotalPurchase, item.SupplierName, item.UserName);
            }
        }

        private void StockInHistoryPrintPreview()
        {
            var list = new StockIn();
            string DateCreated = $"From {datePSIFrom.Value.ToString("MM-dd-yyyy")} To {datePSITo.Value.ToString("MM-dd-yyyy")}";
            foreach (DataGridViewRow item in StockInDG.Rows)
            {
                list.ProductList.Add(new StockIn() {
                    ReferenceNo = item.Cells["ReferenceNoSI"].Value.ToString(),
                    ProductName = item.Cells["ProductNameSI"].Value.ToString(),
                    DateArrival = item.Cells["datePurchaseSI"].Value.ToString(),
                    DateExpiry = item.Cells["dateExpirySI"].Value.ToString(),
                    Qty = int.Parse(item.Cells["QtySI"].Value.ToString()),
                    BusinessName = item.Cells["SupplierSI"].Value.ToString(),
                    UserName = item.Cells["StockBySI"].Value.ToString(),
                    Price = decimal.Parse(item.Cells["CostPriceSI"].Value.ToString()),
                    TotalPurchase = decimal.Parse(item.Cells["TotalSI"].Value.ToString()),
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "StockIn";
            rs.Value = list.ProductList;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.StockInHistoryRpt.rdlc";
            ReportParams();
            p[p.Length -1] = new ReportParameter("DateCreatedAt", DateCreated);
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }


        private void StockAdjHistory()
        {
            string dateFrom = datePSAFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = datePSATo.Value.AddDays(1).ToString("yyyy-MM-dd");
            int i = 1;
            StockAdjDG.Rows.Clear();
            foreach (var item in model.StockAdjHistory(dateFrom, dateTo).ProductList)
            {
                StockAdjDG.Rows.Add(i++, item.ReferenceNo, item.ProductName, item.Qty, item.DateStockin, item.Action, item.Remarks, item.UserName);
            }
        }

        private void StockAdjHistPrintPreview()
        {
            var list = new StockIn();
            string DateCreated = $" From {datePSAFrom.Value.ToString("MM-dd-yyyy")} To {datePSATo.Value.ToString("MM-dd-yyyy")}";
            foreach (DataGridViewRow item in StockAdjDG.Rows)
            {
                list.ProductList.Add(new StockIn()
                {
                    ReferenceNo = item.Cells["RefNoSA"].Value.ToString(),
                    ProductName = item.Cells["ProdNameSA"].Value.ToString(),
                    DateStockin = item.Cells["dateSA"].Value.ToString(),
                    Qty = int.Parse(item.Cells["QtySA"].Value.ToString()),
                    Action = item.Cells["ActionSA"].Value.ToString(),
                    Remarks = item.Cells["RemarksSA"].Value.ToString(),
                    UserName = item.Cells["UserSA"].Value.ToString()
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "StocksAdjustment";
            rs.Value = list.ProductList;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.StockAdjHistoryRpt.rdlc";
            ReportParams();
            p[p.Length - 1] = new ReportParameter("DateCreatedAt", DateCreated);
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }

        public void SoldItemList()
        {
            string dFrom = Convert.ToDateTime(datePFrom.Value).AddDays(-1).ToString("yyyy-MM-dd");
            string dTo = Convert.ToDateTime(datePTo.Value).AddDays(1).ToString("yyyy-MM-dd");
            int i = 1;
            SoldItemsDG.Rows.Clear();
            foreach (var item in smodel.SoldItems(dFrom, dTo,"",""))
            {
                item.ProductName += item.IsSale ? " SALE" : "";
                SoldItemsDG.Rows.Add(i++,item.ProductName, item.Price,item.SPrice, item.Qty, item.UnitCode, item.Discount, item.Total, item.Total - (item.Price * item.Qty), item.SDate);
            }
        }


        private void SoldItemsPrintPreview()
        {
            var list = new List<ProductCart>();
            var Profile = pmodel.getBusinessProfile();
            string DateCreated = $"From {datePFrom.Value.ToString("MM-dd-yyyy")} To {datePTo.Value.ToString("MM-dd-yyyy")}";
            foreach (DataGridViewRow item in SoldItemsDG.Rows)
            {
                var obj = new ProductCart()
                {
                    ProductName = item.Cells["prodNameST"].Value.ToString(),
                    Qty = int.Parse(item.Cells["qtyST"].Value.ToString()),
                    Price = decimal.Parse(item.Cells["CostPriceST"].Value.ToString()),
                    SPrice = decimal.Parse(item.Cells["priceST"].Value.ToString()),
                    UnitCode = item.Cells["unitST"].Value.ToString(),
                    Discount = decimal.Parse(item.Cells["discST"].Value.ToString()),
                    Total = decimal.Parse(item.Cells["totalST"].Value.ToString()),
                    SDate = item.Cells["sdateST"].Value.ToString(),
                    Profit = decimal.Parse(item.Cells["ProfitST"].Value.ToString())
                };
                list.Add(obj);
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "SoldItems";
            rs.Value = list;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.SoldItemsRpt.rdlc";
            ReportParams();
            p[p.Length -1] = new ReportParameter("DateCreatedAt", DateCreated);
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();

        }


        private void CancelledOrderList()
        {
            string dFrom = datePCOFrom.Value.ToString("yyyy-MM-dd");
            string dTo = datePCOTo.Value.AddDays(1).ToString("yyyy-MM-dd");
            int i = 0;
            CancelledOrderDG.Rows.Clear();
            foreach (var item in model.GetCancelledOrders(dFrom, dTo))
            {
                CancelledOrderDG.Rows.Add(++i, item.Invoice, item.ProductName, item.Qty, item.Price, item.Total, item.SDate, item.Remarks, item.UserName);
            }
        }

        private void CancelledOrderPP()
        {
            var list = new List<CancelOrder>();
            var Profile = pmodel.getBusinessProfile();
            string DateCreated = $"From {datePCOFrom.Value.ToString("MM-dd-yyyy")} To {datePCOTo.Value.ToString("MM-dd-yyyy")}";
            foreach (DataGridViewRow item in CancelledOrderDG.Rows)
            {
                list.Add(new CancelOrder()
                {
                    Invoice = item.Cells["InvoiceCo"].Value.ToString(),
                    ProductName = item.Cells["ProdNameCo"].Value.ToString(),
                    Qty = int.Parse(item.Cells["QtyCo"].Value.ToString()),
                    Price = decimal.Parse(item.Cells["PriceCO"].Value.ToString()),
                    Total = decimal.Parse(item.Cells["totalCO"].Value.ToString()),
                    SDate = item.Cells["DateCO"].Value.ToString(),
                    Remarks = item.Cells["RemarksCO"].Value.ToString(),
                    UserName = item.Cells["UserCO"].Value.ToString()
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "CancelledOrders";
            rs.Value = list;
            string rdlc = "Jaezer_POS_and_Inventory.Reports.CancelledOrderRpt.rdlc";
            ReportParams();
            p[p.Length - 1] = new ReportParameter("DateCreatedAt", DateCreated);
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }

        private void btnPrntPrvInv_Click(object sender, EventArgs e)
        {
            InventoryPrintPreview();
        }

        private void btnLDExpItems_Click(object sender, EventArgs e)
        {
            ExpiryItemsList();
        }

        private void btnPrntPrvExpITems_Click(object sender, EventArgs e)
        {
            ExpiryItemsPrintPrintPreview();
        }

        private void btnLDTopSell_Click(object sender, EventArgs e)
        {
            TopSellingList();
        }

        private void cbByQty_CheckedChanged(object sender, EventArgs e)
        {
            cbByAmnt.Checked = false;
        }

        private void cbByAmnt_CheckedChanged(object sender, EventArgs e)
        {
            cbByQty.Checked = false;
        }

        private void btnTopSellPrntPrv_Click(object sender, EventArgs e)
        {
            TopSellingPrintPreview();
        }

        private void ReportsTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ReportsTC.SelectedIndex)
            {
                case 0:
                    InventoryList();
                    break;
                case 1:
                    ExpiryItemsList();
                    break;
                case 7:

                    break;

            }
        }

        private void btnLDStockin_Click(object sender, EventArgs e)
        {
            StockInHistory();
        }

        private void btnPrintPrvStockin_Click(object sender, EventArgs e)
        {
            StockInHistoryPrintPreview();
        }

        private void btnLoadDataSA_Click(object sender, EventArgs e)
        {
            StockAdjHistory();
        }

        private void btnPrintPrvSA_Click(object sender, EventArgs e)
        {
            StockAdjHistPrintPreview();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SoldItemList();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            SoldItemsPrintPreview();
        }

        private void btnLoadCO_Click(object sender, EventArgs e)
        {
            CancelledOrderList();
        }

        private void btnPrintCO_Click(object sender, EventArgs e)
        {
            CancelledOrderPP();
        }

        private void btnIncmeStmntPP_Click(object sender, EventArgs e)
        {
            if (cbYearIS.Text == string.Empty)
                return;
            string DateCreated = $"For the year end of {cbYearIS.Text}";
            var IncomeStatement = model.GetIncomeStatement(cbYearIS.Text);
            var list = new List<IncomeStatement>();
            list.Add(IncomeStatement);
            ReportDataSource[] rs = new ReportDataSource[] {
                new ReportDataSource { Name = "IncomeStatement", Value = list },
                new ReportDataSource { Name = "Expenses", Value = IncomeStatement.Expenses }
        };
               
           
            string rdlc = "Jaezer_POS_and_Inventory.Reports.IncomeStatementRpt.rdlc";
            ReportParams();
            p[p.Length - 2] = new ReportParameter("DateCreatedAt", DateCreated);
            p[p.Length - 1] = new ReportParameter("Profit", (IncomeStatement.GrossProfit - IncomeStatement.TotalExpenses).ToString("N"));
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }

        private void btnLoadExp_Click(object sender, EventArgs e)
        {
            ExpenseModel _model = new ExpenseModel();
            string dFrm = dpDateFromEx.Value.AddDays(-1).ToString("yyyy-MM-dd");
            string dTo = dpDateToEx.Value.ToString("yyyy-MM-dd");

            ExpensesDG.Rows.Clear();
            foreach (var item in _model.GetAllExpenses(dFrm, dTo))
                ExpensesDG.Rows.Add(ExpensesDG.Rows.Count + 1, item.Description, item.Amount, item.Date, item.UserName);
        }

        private void btnExpensesPP_Click(object sender, EventArgs e)
        {
            var list = new List<Expenses>();
            string DateCreated = $"From {dpDateFromEx.Value} to {dpDateToEx.Value}";
            foreach (DataGridViewRow item in ExpensesDG.Rows)
            {
                list.Add(new Expenses {
                    Description = item.Cells["DescriptionEx"].Value.ToString(),
                    Amount = decimal.Parse(item.Cells["AmountEx"].Value.ToString()),
                    Date = item.Cells["DateEx"].Value.ToString(),
                    UserName = item.Cells["UserEx"].Value.ToString()
                });
            }
            string rdlc = "Jaezer_POS_and_Inventory.Reports.ExpensesRpt.rdlc";
            ReportParams();
            ReportDataSource rs = new ReportDataSource { Name = "Expenses", Value = list };
            p[p.Length - 1] = new ReportParameter("DateCreatedAt", DateCreated);
            frmPrintPreview frm = new frmPrintPreview(rs, rdlc, p);
            frm.ShowDialog();
        }
    }
}
