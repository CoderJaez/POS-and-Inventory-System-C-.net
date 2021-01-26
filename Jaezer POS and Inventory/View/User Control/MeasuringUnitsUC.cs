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
    public partial class MeasuringUnitsUC : UserControl
    {
        private frmUnitCollection frm;
        private FormModal modal;
        private UnitMeasureModel unitModel = new UnitMeasureModel();
        private UnitMeasurement obj;
        private List<int> _ids = new List<int>();
        private List<DataGridViewRow> _rows = new List<DataGridViewRow>();
        private UnitMCollection unitColl;
        public MeasuringUnitsUC()
        {
            InitializeComponent();
        }

        private void ShowModal(bool update)
        {
            frm = new frmUnitCollection(this, false, unitColl);
            modal = new FormModal(this, frm);
            modal.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            unitColl = new UnitMCollection();
            ShowModal(false);
        }

        public void UnitMList()
        {
            UnitsDG.Rows.Clear();
            foreach (var _obj in unitModel.getUnitMList(SearchTxt.Text))
            {
                UnitsDG.Rows.Add(_obj.id, false, _obj.UnitCode, _obj.Description);
            }
        }

     

        private void MeasuringUnitsUC_Load(object sender, EventArgs e)
        {
            UnitMList();
        }

        private void UnitsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
                switch (UnitsDG.Columns[e.ColumnIndex].Name)
                {
                    case "check":
                        UnitsDG.CurrentCell.Value = (bool)UnitsDG.CurrentCell.Value ? false : true;
                        if ((bool)UnitsDG.CurrentCell.Value)
                        {
                            _ids.Add(Convert.ToInt32(UnitsDG.CurrentRow.Cells["id"].Value.ToString()));
                            _rows.Add(UnitsDG.CurrentRow);
                        } else
                        {
                            _ids.Remove(Convert.ToInt32(UnitsDG.CurrentRow.Cells["id"].Value.ToString()));
                            _rows.Remove(UnitsDG.CurrentRow);
                        }
                        break;
                    case "edit":
                        obj = new UnitMeasurement();
                        unitColl = new UnitMCollection();
                        obj.id = Convert.ToInt32(UnitsDG.CurrentRow.Cells["id"].Value.ToString());
                        obj.UnitCode = UnitsDG.CurrentRow.Cells["UnitCode"].Value.ToString();
                        obj.Description = UnitsDG.CurrentRow.Cells["Description"].Value.ToString();
                        unitColl.units.Clear();
                        unitColl.units.Add(obj);
                        frm = new frmUnitCollection(this, true, unitColl);
                        modal = new FormModal(this, frm);
                        modal.Show();
                        break;
                    case "delete":
                        int id = Convert.ToInt32(UnitsDG.CurrentRow.Cells["id"].Value.ToString());
                        deleteUnits(id, UnitsDG.CurrentRow);
                        break;
                }
        }

        private void deleteUnits(int id, DataGridViewRow row)
        {
            var result = MessageBox.Show("Do you want to delete selected data? ", unitModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (unitModel.delete(id,"tbl_unit"))
                {
                    MessageBox.Show("Data deleted succesful.", unitModel.AppName);
                    UnitsDG.Rows.Remove(row);

                }
            }
        }

        private void deleteUnits()
        {
           
            if(_ids.Count > 0)
            {
                var result = MessageBox.Show("Do you want to delete selected data? ", unitModel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if(unitModel.delete(_ids))
                    {
                        MessageBox.Show("Data deleted succesful.", unitModel.AppName);
                        foreach (var item in _rows)
                        {
                            UnitsDG.Rows.Remove(item);
                        }
                    }

                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(_rows.Count > 0)
            {
                unitColl = new UnitMCollection();
                foreach (var row in _rows)
                {
                    obj = new UnitMeasurement();
                    obj.id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                    obj.UnitCode = row.Cells["UnitCode"].Value.ToString();
                    obj.Description = row.Cells["Description"].Value.ToString();
                    unitColl.units.Add(obj);

                }
                frm = new frmUnitCollection(this, true, unitColl);
                modal = new FormModal(this, frm);
                modal.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteUnits();
        }
    }
}
