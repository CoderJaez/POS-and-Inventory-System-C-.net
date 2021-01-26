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
using Jaezer_POS_and_Inventory.View.Forms;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class CategoryUC : UserControl
    {
        CategoryModel catModel = new CategoryModel();
        Category obj = new Category();
        private frmCategory frm;
        private FormModal modal;
        private List<int> _CatID = new List<int>();
        private List<DataGridViewRow> _Rows = new List<DataGridViewRow>();
        public CategoryUC()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm = new frmCategory(this, false, obj);
            modal = new FormModal(this, frm);
            modal.Show();
        }

        public void CategoryList()
        {
            CategoryDG.Rows.Clear();
            foreach (var obj in catModel.getCategory
                (SearchTxt.Text))
            {
                CategoryDG.Rows.Add(obj.id.ToString(), false, obj.category);
            }
        }

        private void CategoryUC_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void CategoryDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (CategoryDG.Columns[e.ColumnIndex].Name)
                {
                    case "check":
                        CategoryDG.CurrentCell.Value = (bool)CategoryDG.CurrentCell.Value ? false : true;
                        if ((bool)CategoryDG.CurrentCell.Value)
                        {
                            _CatID.Add(Convert.ToInt32(CategoryDG.CurrentRow.Cells["id"].Value.ToString()));
                            _Rows.Add(CategoryDG.CurrentRow);
                        }
                        else
                        {
                            _CatID.Remove(Convert.ToInt32(CategoryDG.CurrentRow.Cells["id"].Value.ToString()));
                            _Rows.Remove(CategoryDG.CurrentRow);
                        }

                        break;
                    case "edit":
                        obj.id = Convert.ToInt32(CategoryDG.CurrentRow.Cells["id"].Value.ToString());
                        obj.category = CategoryDG.CurrentRow.Cells["Category"].Value.ToString();
                        frm = new frmCategory(this, true, obj);
                        modal = new FormModal(this, frm);
                        modal.Show();
                        break;
                    case "delete":
                        if (_delete(Convert.ToInt32(CategoryDG.CurrentRow.Cells["id"].Value.ToString())))
                            CategoryDG.Rows.RemoveAt(e.RowIndex);
                        break;
                }
            }
        }

        private bool _delete(int id)
        {
            var result = MessageBox.Show("Do you want to delete selected row?", catModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                if (catModel.deleteCategory(id))
                {
                    MessageBox.Show("Selected row deleted successfully", catModel.AppName);
                    return true;
                }
            return false;
        }

        private void delete_batch()
        {
            if (_CatID.Count  > 0)
            {
                var result = MessageBox.Show("Do you want to delete selected rows?", catModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    if (catModel.delete_batch(_CatID))
                    {
                        foreach (var index in _Rows)
                        {
                            CategoryDG.Rows.Remove(index);
                        }
                        _CatID.Clear();
                        _Rows.Clear();
                    }
                }
               
            }
        }

        
        private void CatForm(bool isForUpdate)
        {

            Form FormBackground = new Form();
            try
            {
                using (frmCategory frmCat = new frmCategory(this,isForUpdate,obj))
                {
                    FormBackground.StartPosition = FormStartPosition.Manual;
                    FormBackground.FormBorderStyle = FormBorderStyle.None;
                    FormBackground.Opacity = .70d;
                    FormBackground.BackColor = Color.Black;
                    FormBackground.WindowState = FormWindowState.Maximized;
                    //FormBackground.TopMost = true;
                    FormBackground.Location = this.Location;
                    FormBackground.ShowInTaskbar = false;
                    FormBackground.Show();
                    frmCat.Owner = FormBackground;
                    frmCat.ShowDialog();
                    FormBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_batch();
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CategoryList();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text == null)
            {
                CategoryList();
                MessageBox.Show("test");
            }
        }

        private void CheckAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckAllCB.CheckState == CheckState.Checked)
            {
                foreach(DataGridViewRow row in CategoryDG.Rows)
                {
                    row.Cells["check"].Value = true;
                    _CatID.Add(Convert.ToInt32(row.Cells["id"].Value.ToString()));
                    _Rows.Add(row);
                }
            } else
            {
                foreach (DataGridViewRow row in CategoryDG.Rows)
                {
                    row.Cells["check"].Value = false;
                }
                _CatID.Clear();
                _Rows.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
