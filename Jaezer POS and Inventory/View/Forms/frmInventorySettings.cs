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
namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmInventorySettings : Form
    {
        public frmInventorySettings()
        {
            InitializeComponent();
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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ModuleDesc.Text = "Category List";
            ButtonClicked(btnCategory);
            CategoryUC uc = new CategoryUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            ModuleDesc.Text = "Brand List";
            ButtonClicked(btnBrand);
            BrandUC uc = new BrandUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ModuleDesc.Text = "Product List";
            ButtonClicked(btnProduct);
            ProductUC uc = new ProductUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnParentChildUnit_Click(object sender, EventArgs e)
        {
            ButtonClicked(btnParentChildUnit);
            ModuleDesc.Text = "Units Measurement List";
            MeasuringUnitsUC uc = new MeasuringUnitsUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ButtonClicked(btnSupplier);
            ModuleDesc.Text = "Supplier List";
            SupplierUC uc = new SupplierUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }

        private void btnPriceItem_Click(object sender, EventArgs e)
        {

           
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ButtonClicked(btnSupplier);
            ModuleDesc.Text = "Expenses Category";
            ExpenseCatUC uc = new ExpenseCatUC();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            uc.Dock = MainPanel.Dock;
        }
    }
}
