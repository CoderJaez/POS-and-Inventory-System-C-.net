using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jaezer_POS_and_Inventory.View.User_Control;
using Jaezer_POS_and_Inventory.View.Forms;
using System.Drawing;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    class FormModal
    {
        UserControl uc { get; set; }
        Form frm { get; set; }
        public FormModal(ExpensesUC _uc, frmExpenses _frm)
        {
            uc = _uc;
            frm = _frm;
        }
        public FormModal(ExpenseCatUC _uc, frmExpenseCat _frm)
        {
            uc = _uc;
            frm = _frm;
        }
        public FormModal(SupplierUC _uc, frmSuplier _frm)
        {
            uc = _uc;
            frm = _frm;
        }
        public FormModal(BrandUC _uc, frmBrand _frm)
        {
            uc = _uc;
            frm = _frm;
        }

        public FormModal(CategoryUC _uc, frmCategory _frm)
        {
            uc = _uc;
            frm = _frm;
        }

        public FormModal(MeasuringUnitsUC _uc, frmUnitCollection _frm)
        {
            uc = _uc;
            frm = _frm;

        }

        public FormModal(ProductUC _uc, frmProduct _frm)
        {
            uc = _uc;
            frm = _frm;
        }

        public FormModal(StockInUC _uc, frmProductList _frm)
        {
            uc = _uc;
            frm = _frm;
        }
        public FormModal(UserUC _uc, frmUser _frm)
        {
            uc = _uc;
            frm = _frm;
        }




        public void Show()
        {

            Form FormBackground = new Form();
            try
            {
                using ( frm )
                {
                    FormBackground.StartPosition = FormStartPosition.Manual;
                    FormBackground.FormBorderStyle = FormBorderStyle.None;
                    FormBackground.Opacity = .70d;
                    FormBackground.BackColor = Color.Black;
                    FormBackground.WindowState = FormWindowState.Maximized;
                    FormBackground.TopMost = false;
                    FormBackground.Location = uc.Location;
                    FormBackground.ShowInTaskbar = false;
                    FormBackground.Show();
                    frm.Owner = FormBackground;
                    frm.TopMost = false;
                    frm.ShowDialog();
                    FormBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
