using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.View.User_Control;
using Jaezer_POS_and_Inventory.View.Forms;
using Jaezer_POS_and_Inventory.Model;
using System.IO;

namespace Jaezer_POS_and_Inventory.View
{
    public partial class frmMain : Form
    {
        private bool isSettingClicked = false;
        public User UserInfo;
        public Button _StockEntry;
        public DataTable CriticalItems;
        private byte[] imageByte;
        public frmMain(User _UserInfo)
        {
            InitializeComponent();
            UserInfo = _UserInfo;
            lblFullname.Text = UserInfo.Fullname;
            lblUserType.Text = UserInfo.UserType;
            var obj = new CompanyProfileModel().getBusinessProfile();
            imageByte = obj.logo;
            try
            {
                MemoryStream ms = new MemoryStream(imageByte);
                CompanyLogo.BackgroundImage = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void ButtonClicked(object sender)
        {
            foreach (Control p in SidePanelMenu.Controls)
            {
                if (p.GetType() == typeof(Button))
                {
                    if (p == sender)
                    {
                        p.BackColor = Color.FromArgb(33, 150, 243);
                    }
                    else
                    {
                        p.BackColor = Color.Transparent;
                    }

                }
            }


            foreach (Control p in SettingsPanel.Controls)
            {
                if (p.GetType() == typeof(Button))
                {
                    if (p == sender)
                    {
                        p.BackColor = Color.FromArgb(33, 150, 243);
                        btnSettings.BackColor = Color.FromArgb(33, 150, 243);
                    }
                    else
                    {
                        p.BackColor = Color.Transparent;
                    }

                }
            }


            

        }
              
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSettingClicked)
            {
                btnSettings.Image = Properties.Resources.icons8_expand_arrow_16;
                if (SettingsPanel.Size == SettingsPanel.MaximumSize)
                {
                    timer1.Stop();
                }
                SettingsPanel.Height += 10;

            }
            else
            {
                btnSettings.Image = Properties.Resources.icons8_collapse_arrow_16;
                if (SettingsPanel.Size == SettingsPanel.MinimumSize)
                {
                    timer1.Stop();
                }
                SettingsPanel.Height -= 10;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isSettingClicked = isSettingClicked ? false:true;
            ButtonClicked(btnSettings);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _StockEntry = btnStockEntry;
            timer1.Start();
            ButtonClicked(btnDashboard);
            isSettingClicked =  false;
            ModuleDesc.Text = "Dashboard";
            DashboardUC uc = new DashboardUC(this);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

     

        private void btnCompany_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnSettings);
            ButtonClicked(btnCompany);
            isSettingClicked = false;
            ModuleDesc.Text = "";
            CompanyProfileUC uc = new CompanyProfileUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

      

     

        private void btnInventorySetup_Click(object sender, EventArgs e)
        {
            frmInventorySettings inv = new frmInventorySettings();
            inv.ShowDialog();
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnStockEntry);
            isSettingClicked = false;
            ModuleDesc.Text = "Stock In";
            StockInUC uc;
            if (CriticalItems == null)
                 uc = new StockInUC();
            else
                 uc = new StockInUC(CriticalItems);

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
            uc.UserInfo(UserInfo);
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnStockAdjustment);
            isSettingClicked = false;
            ModuleDesc.Text = "Stock Adjustment";
            StockAdjustmentUC uc = new StockAdjustmentUC(UserInfo);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS pos = new frmPOS(UserInfo);
            pos.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            timer1.Start();
            ButtonClicked(btnSettings);
            ButtonClicked(btnUser);
            isSettingClicked = false;
            ModuleDesc.Text = "User Accounts";
            UserUC uc = new UserUC(UserInfo);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnSales);
            isSettingClicked = false;
            ModuleDesc.Text = "Sales History";
            DailySalesUC uc = new DailySalesUC(this);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnReports);
            isSettingClicked = false;
            ModuleDesc.Text = "Reports";
            ReportsUC uc = new ReportsUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            isSettingClicked = false;
            ModuleDesc.Text = "Dashboard";
            DashboardUC uc = new DashboardUC(this);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
            _StockEntry = btnStockEntry;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnDiscount);
            isSettingClicked = false;
            ModuleDesc.Text = "Item Sale Discount";
            SaleEventUC uc = new SaleEventUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnInventory);
            isSettingClicked = false;
            ModuleDesc.Text = "Inventory";
            InventoryUC uc = new InventoryUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnExpensesSettings_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnSettings);
            ButtonClicked(btnExpensesSettings);
            isSettingClicked = false;
            ModuleDesc.Text = "Expenses Settings";
            ExpenseCatUC uc = new ExpenseCatUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonClicked(btnExpenses);
            isSettingClicked = false;
            ModuleDesc.Text = "Expenses";
            ExpensesUC uc = new ExpensesUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }
    }
}
