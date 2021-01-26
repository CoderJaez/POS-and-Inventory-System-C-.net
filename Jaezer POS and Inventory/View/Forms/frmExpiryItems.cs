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
namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmExpiryItems : Form
    {
        InventoryModel model = new InventoryModel();

        public frmExpiryItems()
        {
            InitializeComponent();
            ExpiryItemsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ExpiryItemsList()
        {
            ExpiryItemsDG.Rows.Clear();
            int i = 0;
            foreach (var item in model.ExpiryItems().ProductList)
            {
                ExpiryItemsDG.Rows.Add(++i,item.ProductID, item.ReferenceNo, item.ProductName, item.DateArrival, item.DateExpiry, item.DayBeforeExpiry, item.Onhand, item.UnitCode,item.StockID);
            }
        }

        private void ExpiryItemsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(ExpiryItemsDG.Columns[e.ColumnIndex].Name == "delete")
                {
                    var result = MessageBox.Show("Do you want to delete selected row?","Removed From Stocks", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        StockIn obj = new StockIn
                        {
                            StockID = int.Parse(ExpiryItemsDG.CurrentRow.Cells["StockID"].Value.ToString()),
                            ProductID = int.Parse(ExpiryItemsDG.CurrentRow.Cells["ProdID"].Value.ToString()),
                            ReferenceNo = ExpiryItemsDG.CurrentRow.Cells["ReferenceNo"].Value.ToString(),
                            Qty = int.Parse(ExpiryItemsDG.CurrentRow.Cells["Onhand"].Value.ToString()),
                            remarksVal = 3,
                            Remarks = "Expired",
                            DateStockin = DateTime.Today.ToString("yyyy-MM-dd"),
                            Action = "Remove From Stocks",
                            UserID = Properties.Settings.Default.UserID
                            
                        };
                        if(model.StockQtyAdjustment(obj))
                        {
                            MessageBox.Show("Item is now removed from stocks");
                            ExpiryItemsDG.Rows.Remove(ExpiryItemsDG.CurrentRow);
                            int n = 1;
                            foreach (DataGridViewRow item in ExpiryItemsDG.Rows)
                                item.Cells["n"].Value = n++;
                        }
                    }
                   
                }
            }
        }
    }
}
