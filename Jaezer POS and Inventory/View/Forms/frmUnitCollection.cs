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
using FluentValidation.Results;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmUnitCollection : Form
    {
        private UnitMeasureModel uModel = new UnitMeasureModel();
        private UnitMCollection unitColl = new UnitMCollection();
        private MeasuringUnitsUC uc;
        private bool isForUpdate;
        public frmUnitCollection(MeasuringUnitsUC _uc, bool forUpdate, UnitMCollection _unitColl)
        {
            InitializeComponent();
            uc = _uc;
            isForUpdate = forUpdate;
            unitColl.units = _unitColl.units;
            if (forUpdate)
            {
                FillUnitCollectionDG();
                btnAddRow.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UnitCollectionDG.Rows.Count <= 0)
                return;
            unitColl.units = unitList();
            var rules = new CollUnitMeaseurementValidator();
            var result = rules.Validate(unitColl);
            string msg = null;
            if (result.IsValid == false)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(isForUpdate)
            {
                if (uModel.update(unitColl.units))
                {
                    MessageBox.Show("Update successfull", uModel.AppName);
                    UnitCollectionDG.Rows.Clear();
                    this.Close();
                }

            }
            else
            {
                if (uModel.insert(unitColl.units))
                {
                    MessageBox.Show("Registration successfull", uModel.AppName);
                    UnitCollectionDG.Rows.Clear();

                }
            }
                 
            uc.UnitMList();

        }


        public List<UnitMeasurement> unitList()
        {
            List<UnitMeasurement> List = new List<UnitMeasurement>();
            foreach (DataGridViewRow row in UnitCollectionDG.Rows)
            {
                var unit = new UnitMeasurement();
                if (row.Cells["UnitCode"].Value != null)
                    unit.UnitCode = row.Cells["UnitCode"].Value.ToString();
                if (row.Cells["Desc"].Value != null)
                    unit.Description = row.Cells["Desc"].Value.ToString();
                if (row.Cells["id"].Value != null)
                    unit.id = Convert.ToInt32(row.Cells["id"].Value.ToString());

                List.Add(unit);
            }

                //List.RemoveAt(List.Count - 1);
            return List;
        }

        private void UnitCollectionDG_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(qty_KeyPress);
            if (UnitCollectionDG.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                    tb.KeyPress += new KeyPressEventHandler(qty_KeyPress);
            }
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            UnitCollectionDG.Rows.Add();
        }

        private void FillUnitCollectionDG()
        {
            UnitCollectionDG.Rows.Clear();
            foreach(var row in unitColl.units)
            {
                UnitCollectionDG.Rows.Add(row.UnitCode, row.Description, row.Qty, row.id);
            }
        }
    }
}
