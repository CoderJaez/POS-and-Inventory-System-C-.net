using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jaezer_POS_and_Inventory.View.Forms;
using Jaezer_POS_and_Inventory.Model;
using System.Windows.Forms;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class BrandUC : UserControl
    {
        BrandModel brandModel = new BrandModel();
        Brand obj = new Brand();
        private FormModal modal;
        private List<int> _CatID = new List<int>();
        private List<DataGridViewRow> _Rows = new List<DataGridViewRow>();
        frmBrand frm;
        public BrandUC()
        {
            InitializeComponent();
        }

        public void BrandList()
        {
            BrandDG.Rows.Clear();
            foreach(var obj in brandModel.getBrandList(SearchTxt.Text))
            {
                BrandDG.Rows.Add(obj.id.ToString(), false, obj.brand);
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            frm = new frmBrand(this, false, obj);
            modal = new FormModal(this, frm);
            modal.Show();
        }

        private void BrandUC_Load(object sender, EventArgs e)
        {
            BrandList();
        }

        private void BrandDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch(BrandDG.Columns[e.ColumnIndex].Name)
                {
                    case "check":
                        BrandDG.CurrentCell.Value = (bool)BrandDG.CurrentCell.Value ? false : true;
                        if ((bool)BrandDG.CurrentCell.Value)
                        {
                            _CatID.Add(Convert.ToInt32(BrandDG.CurrentRow.Cells["id"].Value.ToString()));
                            _Rows.Add(BrandDG.CurrentRow);
                        }
                        else
                        {
                            _CatID.Remove(Convert.ToInt32(BrandDG.CurrentRow.Cells["id"].Value.ToString()));
                            _Rows.Remove(BrandDG.CurrentRow);
                        }

                        break;
                    case "edit":
                        obj.id = Convert.ToInt32(BrandDG.CurrentRow.Cells["id"].Value.ToString());
                        obj.brand = BrandDG.CurrentRow.Cells["Brand"].Value.ToString();
                        frm = new frmBrand(this, true, obj);
                        modal = new FormModal(this, frm);
                        modal.Show();
                        break;
                    case "delete":
                        if (_delete(Convert.ToInt32(BrandDG.CurrentRow.Cells["id"].Value.ToString())))
                            BrandDG.Rows.RemoveAt(e.RowIndex);
                        break;
                }
            }
        }


        private bool _delete(int id)
        {
            var result = MessageBox.Show("Do you want to delete selected row?", brandModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                if (brandModel.delete(id))
                {
                    MessageBox.Show("Selected row deleted successfully", brandModel.AppName);
                    return true;
                }
            return false;
        }

        private void delete_batch()
        {
            if (_CatID.Count > 0)
            {
                var result = MessageBox.Show("Do you want to delete selected rows?", brandModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (brandModel.delete_batch(_CatID))
                    {
                        foreach (var index in _Rows)
                        {
                            BrandDG.Rows.Remove(index);
                        }
                        MessageBox.Show("Selected row deleted successfully", brandModel.AppName);
                        _CatID.Clear();
                        _Rows.Clear();
                    }
                }

            }
        }

        private void CheckAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAllCB.CheckState == CheckState.Checked)
            {
                foreach (DataGridViewRow row in BrandDG.Rows)
                {
                    row.Cells["check"].Value = true;
                    _CatID.Add(Convert.ToInt32(row.Cells["id"].Value.ToString()));
                    _Rows.Add(row);
                }
            }
            else
            {
                foreach (DataGridViewRow row in BrandDG.Rows)
                {
                    row.Cells["check"].Value = false;
                }
                _CatID.Clear();
                _Rows.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_batch();
        }

      
    }
}
