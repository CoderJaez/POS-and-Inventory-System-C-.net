using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using Jaezer_POS_and_Inventory.Model;
using Jaezer_POS_and_Inventory.View.Forms;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class SupplierUC : UserControl
    {
        frmSuplier frm;
        SupplierModel sModel = new SupplierModel();
        private List<int> ids = new List<int>();
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        public SupplierUC()
        {
            InitializeComponent();
        }

        private void CheckAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckAllCB.CheckState == CheckState.Checked)
            {
                foreach (DataGridViewRow row in SupplierDG.Rows)
                {
                    row.Cells["check"].Value = true;
                    ids.Add(Convert.ToInt32(row.Cells["id"].Value.ToString()));
                    rows.Add(row);
                }
            } else
            {
                foreach (DataGridViewRow row in SupplierDG.Rows)
                    row.Cells["check"].Value = false;
                ids.Clear();
                rows.Clear();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm = new frmSuplier(this, 0, false);
            FormModal modal = new FormModal(this, frm);
            modal.Show();
        }

        private void SupplierUC_Load(object sender, EventArgs e)
        {
            SupplierList();
        }

        public void SupplierList()
        {
            SupplierDG.Rows.Clear();
            foreach(var obj in sModel.GetSupplier(SearchTxt.Text))
            {
                SupplierDG.Rows.Add(obj.SupplierID, false, obj.BusinessName.ToUpper(), obj.SupplierName.ToUpper(), obj.ContactNo, obj.CompleteAddress.ToUpper());
            }
        }

        private void SupplierDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch (SupplierDG.Columns[e.ColumnIndex].Name)
                {
                    case "check":
                        SupplierDG.CurrentCell.Value = (bool)SupplierDG.CurrentCell.Value ? false : true;
                        if((bool)SupplierDG.CurrentCell.Value)
                        {
                            ids.Add(Convert.ToInt32(SupplierDG.CurrentRow.Cells["id"].Value.ToString()));
                            rows.Add(SupplierDG.CurrentRow);
                        } else
                        {
                            ids.Remove(Convert.ToInt32(SupplierDG.CurrentRow.Cells["id"].Value.ToString()));
                            rows.Remove(SupplierDG.CurrentRow);
                        }
                        break;
                    case "edit":
                        frm = new frmSuplier(this, Convert.ToInt32(SupplierDG.CurrentRow.Cells["id"].Value.ToString()), true);
                        FormModal modal = new FormModal(this, frm);
                        modal.Show();
                        break;
                    case "delete":
                        deleteSupplier(Convert.ToInt32(SupplierDG.CurrentRow.Cells["id"].Value.ToString()), SupplierDG.CurrentRow);
                        break;

                }
            }

        }

        private void deleteSupplier(int id, DataGridViewRow row)
        {
            var result = MessageBox.Show("Do you want to delete selected data?", sModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                if(sModel.delete(id))
                {
                    MessageBox.Show("Delete selected data successfull.", sModel.AppName);
                    SupplierDG.Rows.Remove(row);
                }
            }

        }

        private void deleteSupplier()
        {
            if (ids.Count > 0)
            {
                var result = MessageBox.Show("Do you want to delete selected data?", sModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    if (sModel.delete(ids))
                    {
                        MessageBox.Show("Delete selected data successfull.", sModel.AppName);
                        foreach (var row in rows)
                            SupplierDG.Rows.Remove(row);

                        rows.Clear();
                        ids.Clear();

                    }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(rows.Count > 0)
            {
                deleteSupplier();
            }
        }
    }
}
