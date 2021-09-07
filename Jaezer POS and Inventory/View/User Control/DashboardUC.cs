using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.View.Forms;
using Jaezer_POS_and_Inventory.Model;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class DashboardUC : UserControl
    {
        private frmMain _main;
        public DashboardUC(frmMain main)
        {
            InitializeComponent();
            lblExpItems.Click += new EventHandler(ExpiryItems_Clicked);
            pbExpiry.Click += new EventHandler(ExpiryItems_Clicked);
            lblExpiry1.Click += new EventHandler(ExpiryItems_Clicked);
            pbCritItem.Click += new EventHandler(OnhandItems_Clicked);
            lblCriticalItems.Click += new EventHandler(OnhandItems_Clicked);
            lblCritItems.Click += new EventHandler(OnhandItems_Clicked);
            _main = main;
        }

        private void OnhandItems_Clicked(object sender, EventArgs e)
        {
            frmCriticalItems items = new frmCriticalItems(_main);
            items.ShowDialog();
        }

        private void ExpiryItems_Clicked(object sender, EventArgs e)
        {
            frmExpiryItems expItems = new frmExpiryItems();
            expItems.ShowDialog();
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }


        private void LoadSummary()
        {
            
            var sum = new DashboardModel().getSumRpt();
            lblDailySales.Text = sum.Sales.ToString("N");
            lblProdItems.Text = sum.ProdItems.ToString();
            lblExpItems.Text = sum.ExpItems.ToString();
            lblOnhand.Text = sum.Onhand.ToString();
            lblCritItems.Text = sum.CritItems.ToString();

            foreach (var item in sum.Year_sales)
            {
                chart.Series["Sales"].Points.AddXY(item.Year, item.Sales.ToString("N"));
            }

            foreach (var item in sum.MonthlyPurchase)
            {
                chart.Series["Purchases"].Points.AddXY(item.Month, item.Purchases.ToString("N"));
            }

            foreach (var item in sum.MoTopSelling)
            {
                chart.Series["TopSelling"].Points.AddXY(item.Prod, item.Sales.ToString("N"));
            }


            foreach (var item in sum.MonthlySales)
            {
                chart.Series["MonthlySales"].Points.AddXY(item.Month, item.Sales.ToString("N"));
            }

            chart.ChartAreas["YearChart"].AxisX.Interval = 1;
            chart.Titles["Title3"].Text = $"For the Month of {DateTime.Now.ToString("MMMM-yyyy")}";
        }
    }
}
