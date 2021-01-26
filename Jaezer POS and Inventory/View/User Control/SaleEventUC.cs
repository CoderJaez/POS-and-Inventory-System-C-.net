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
    public partial class SaleEventUC : UserControl
    {
        InventoryModel imodel = new InventoryModel();
        SalesTransactionModel stmodel = new SalesTransactionModel();
        public SaleEventUC()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductListSale frm = new frmProductListSale(this);
            frm.ShowDialog(); 
        }

        public void DiscountedItems()
        {
            ProdSaleDG.Rows.Clear();
            int i = 1;
            foreach (var item in imodel.ProductInquiryList(SearchTxt.Text))
            {
                if(item.IsSale)
                    ProdSaleDG.Rows.Add(item.PriceID,  false, i++, $"{item.ProductName} ({item.PriceUnit})", item.Price, item.SPrice, item.SDateFrm, item.SDateTo);
            }
        }

        private void CheckAllCB_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in ProdSaleDG.Rows)
            {
                item.Cells["check"].Value = CheckAllCB.Checked;
            }
        }

        private void SaleEventUC_Load(object sender, EventArgs e)
        {
            DiscountedItems();
        }

        private void ProdSaleDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch (ProdSaleDG.Columns[e.ColumnIndex].Name)
                {
                    case "check":
                        ProdSaleDG.CurrentCell.Value = (bool)ProdSaleDG.CurrentCell.Value ? false : true;
                        break;
                    case "edit":
                        var list = new List<ProductPrice>();
                        list.Add(new ProductPrice() {
                            PriceID = (int)ProdSaleDG.CurrentRow.Cells["prcID"].Value,
                            ProductName = ProdSaleDG.CurrentRow.Cells["ProdName"].Value.ToString(),
                            Price = (decimal)ProdSaleDG.CurrentRow.Cells["UPrice"].Value,
                            SPrice = (decimal)ProdSaleDG.CurrentRow.Cells["SPrice"].Value
                        });
                        frmProductListSale frm = new frmProductListSale(this);
                        frm.ProductInfoList(list);
                        frm.ShowDialog();
                        break;
                    case "delete":
                        var result = MessageBox.Show("Delete Selected Row?", stmodel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var list1 = new List<ProductPrice>();
                            list1.Add(new ProductPrice()
                            {
                                PriceID = (int)ProdSaleDG.CurrentRow.Cells["prcID"].Value,
                                SPrice = 0,
                                SDateFrm = "0000-00-00",
                                SDateTo = "0000-00-00",
                                IsSale = false
                            });
                            if (stmodel.AddItemDiscSale(list1))
                            {
                                ProdSaleDG.Rows.Remove(ProdSaleDG.CurrentRow);
                            }
                        }
                        break;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckAllCB.Checked)
            {
                MessageBox.Show("No Row/s Selected");
                return;
            }
            var list = new List<ProductPrice>();
            foreach (DataGridViewRow item in ProdSaleDG.Rows)
            {
                if((bool)item.Cells["check"].Value)
                {
                    list.Add(new ProductPrice()
                    {
                        PriceID = (int)item.Cells["prcID"].Value,
                        ProductName = item.Cells["ProdName"].Value.ToString(),
                        Price = (decimal)item.Cells["UPrice"].Value,
                        SPrice = (decimal)item.Cells["SPrice"].Value
                    });
                }
            }
            frmProductListSale frm = new frmProductListSale(this);
            frm.ProductInfoList(list);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!CheckAllCB.Checked)
            {
                MessageBox.Show("No Row/s Selected");
                return;
            }

            var list = new List<ProductPrice>();
            foreach (DataGridViewRow item in ProdSaleDG.Rows)
            {
                if ((bool)item.Cells["check"].Value)
                {
                    list.Add(new ProductPrice()
                    {
                        PriceID = (int)ProdSaleDG.CurrentRow.Cells["prcID"].Value,
                        ProductName = ProdSaleDG.CurrentRow.Cells["ProdName"].Value.ToString(),
                        Price = (decimal)ProdSaleDG.CurrentRow.Cells["UPrice"].Value,
                        SPrice = (decimal)ProdSaleDG.CurrentRow.Cells["SPrice"].Value
                    });
                }
            }

            var result = MessageBox.Show("Delete Selected Row?", stmodel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (stmodel.AddItemDiscSale(list))
                {
                    DiscountedItems();
                }
            }
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DiscountedItems();
                CheckAllCB.Checked = false;
            }
        }
    }
}
