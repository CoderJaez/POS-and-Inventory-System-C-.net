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
namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class InventoryUC : UserControl
    {
        InventoryModel inv = new InventoryModel();
        ComboBox CategoryCB = new ComboBox();
        ComboBox ItemCB = new ComboBox();
        public InventoryUC()
        {
            InitializeComponent();
            _FiltersInit();
        }

        private void InventoryUC_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private  void LoadInventory()
        {
            InvetoryListDG.Rows.Clear();
            foreach (var item in inv.GetProductInventorySummary().list)
            {
                InvetoryListDG.Rows.Add(item.ProductID,InvetoryListDG.Rows.Count + 1, item.ProductDescription, $"{item.QtyPurchased} {item.Unit}", item.CostPrice, item.TotalPurchased, $"{item.QtySold} {item.Unit}", item.TotalAmntSold, $"{item.QtyOnhand} {item.Unit}", item.Balance);
            }
        }

        private void _Filters()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("type", typeof(string));

            dt.Rows.Add(0, "");
            dt.Rows.Add(1, "Category Item/Products");
            dt.Rows.Add(2, "Category Item");
            dt.Rows.Add(3, "Item");
            cbFilter.ValueMember = "id";
            cbFilter.DisplayMember = "type";
            cbFilter.DataSource = dt;
        }

        private void _FiltersInit()
        {
            _Filters();
            CategoryCB.Name = "CategoryCB";
            ItemCB.Name = "ItemCB";

            CategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemCB.DropDownStyle = ComboBoxStyle.DropDownList;

            CategoryCB.DisplayMember = "Category";
            CategoryCB.ValueMember = "CatID";

           
            ItemCB.DisplayMember = "Product";
            ItemCB.ValueMember = "ProductID";

            CategoryCB.SelectionChangeCommitted += CategoryCB_SelectionChangeCommitted;
            _Category();
            _Items("");
            FilterFL.Controls.Add(CategoryCB);
            FilterFL.Controls.Add(ItemCB);
            CategoryCB.Visible = false;
            ItemCB.Visible = false;

        }
        private void _Category()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CatID");
            dt.Columns.Add("Category");
            dt.Rows.Add("", "ALL Item Categories");
            foreach (var item in new CategoryModel().getCategory(""))
            {
                dt.Rows.Add(item.id, item.category);
            }

            CategoryCB.DataSource = dt;
        }

        private void _Items(string id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("Product");
            dt.Rows.Add("", "ALL Product Items");
            foreach (var item in new ProductModel().getProduct(id))
            {
                dt.Rows.Add(item.ProductID, item.ProductName);
            }
            ItemCB.DataSource = dt;
        }

        private void CategoryCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
