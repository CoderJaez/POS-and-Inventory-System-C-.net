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
        public frmCriticalItems()
        {
            InitializeComponent();
            loadCriticalItems();
        }

        private void loadCriticalItems()
        {
            var imodel = new InventoryModel();
                CriticalItemsDG.Rows.Clear();
            foreach (var items in imodel.GetCriticalItems(txtSearch.Text))
            {
                CriticalItemsDG.Rows.Add( CriticalItemsDG.Rows.Count + 1, items.ProductID, items.ProductName, items.HasExpiry, items.Onhand, items.ReOrderLevel);
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
                ItemsDG.Rows.Add(ItemsDG.Rows.Count + 1, item.Cells["ProdID"].Value.ToString(),item.Cells["ProductName"].Value.ToString(), item.Cells["hasExpiry"].Value);
        }
    }
}
