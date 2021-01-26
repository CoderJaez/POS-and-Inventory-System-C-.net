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
    public partial class frmProductList : Form
    {
        ProductModel model = new ProductModel();
        StockInUC uc = new StockInUC();
        public frmProductList(StockInUC _uc)
        {
            InitializeComponent();
            uc = _uc;
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        private void ProductList()
        {
            ProductDG.Rows.Clear();
            foreach (var obj in model.getProduct(SearchTxt.Text))
            {
                ProductDG.Rows.Add(obj.ProductID,ProductDG.Rows.Count + 1, obj.ProductName, obj.Brand, obj.Category, obj.UnitCode, obj.ReOrderLevel, obj.HasExpiry,obj.Qty);
            }
        }

      

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(ProductDG.Columns[e.ColumnIndex].Name == "insert")
                {
                    uc.AddToList(ProductDG.CurrentRow);
                }
            }
        }
    }
}
