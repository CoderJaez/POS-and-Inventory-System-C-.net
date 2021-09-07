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
using Jaezer_POS_and_Inventory.View.User_Control;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmCriticalItems : Form
    {
        private frmMain _main;
        public frmCriticalItems(frmMain main)
        {
            InitializeComponent();
            loadCriticalItems();
            _main = main;
        }

        private void loadCriticalItems()
        {
            var imodel = new InventoryModel();
                CriticalItemsDG.Rows.Clear();
            foreach (var items in imodel.GetCriticalItems(txtSearch.Text))
            {
                CriticalItemsDG.Rows.Add( CriticalItemsDG.Rows.Count + 1, items.ProductID, items.ProductName, items.HasExpiry,items.Qty, items.Onhand, items.ReOrderLevel);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CriticalItemsDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CriticalItemsDG.Rows.Count > 0)
                if (CriticalItemsDG.Columns[e.ColumnIndex].Name == "insert")
                    addToList(CriticalItemsDG.CurrentRow);
          
        }

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadCriticalItems();

        }

        private void addToList(DataGridViewRow item)
        {
            bool hasDuplicate = false;
            foreach (DataGridViewRow items in ItemsDG.Rows)
            {
                if(items.Cells["_ProdID"].Value.ToString() == item.Cells["ProdID"].Value.ToString())
                {
                    hasDuplicate = true;
                    break;
                }
            }

            if (!hasDuplicate)
                ItemsDG.Rows.Add(ItemsDG.Rows.Count + 1, item.Cells["ProdID"].Value.ToString(), item.Cells["ProductName"].Value.ToString(), (bool)item.Cells["hasExpiry"].Value, item.Cells["BaseQty"].Value);
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            _main.CriticalItems = Items();
            _main._StockEntry.PerformClick();
            this.Close();
        }

        private DataTable Items()
        {
            var items = new DataTable();
            items.Columns.Add("ProdID");
            items.Columns.Add("BaseQty");
            items.Columns.Add("HasExpiry");
            items.Columns.Add("ProductName");

            foreach (DataGridViewRow item in ItemsDG.Rows)
            {
                items.Rows.Add(item.Cells["_ProdID"].Value.ToString(), item.Cells["_BaseQty"].Value.ToString(), item.Cells["_hasExpiry"].Value, item.Cells["_ProductName"].Value.ToString());
            }
            return items;
        }

        private void ItemsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ItemsDG.Rows.Count > 0 && ItemsDG.Columns[e.ColumnIndex].Name == "itemDelete")
            {
                ItemsDG.Rows.Remove(ItemsDG.CurrentRow);
            }
        }
    }
}
