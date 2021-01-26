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
    public partial class frmUnitGroups : Form
    {
        UnitMeasureModel umodel = new UnitMeasureModel();
        frmProduct frm;
        private bool isForUpdate;
        public frmUnitGroups(frmProduct _frm)
        {
            InitializeComponent();
            frm = _frm;
            UnitList();
            ProductUnitList();
        }

        private void UnitProdList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("unit");
            cbUnitCode.DisplayMember = "unit";
            cbUnitCode.ValueMember = "id";
            dt.Rows.Add("", "");
            foreach (var obj in umodel.ProductUnitList(frm.product.ProductID))
                dt.Rows.Add(obj.id, obj.UnitCode);
            cbDefaultUnit.DataSource = dt;
        }

        private void UnitList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("unit");
            cbUnitCode.DisplayMember = "unit";
            cbUnitCode.ValueMember = "id";
            dt.Rows.Add("", "");
            foreach (var obj in umodel.getUnitMList(""))
                dt.Rows.Add(obj.id, obj.UnitCode);
            cbUnitCode.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductUnitList()
        {
            UnitCollectionDG.Rows.Clear();
            foreach (var item in frm.product.UnitList)
            {
                UnitCollectionDG.Rows.Add(item.ugID, item.UnitCode, item.Qty);
            }


            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("unit");
            cbDefaultUnit.DisplayMember = "unit";
            cbDefaultUnit.ValueMember = "id";
            dt.Rows.Add("", "");
            foreach (var obj in frm.product.UnitList)
            {
                dt.Rows.Add(obj.ugID, obj.UnitCode);
                if (obj.DefaultUnit)
                    frm.product.UnitCode = obj.UnitCode;

            }
            cbDefaultUnit.DataSource = dt;
            cbDefaultUnit.Text = frm.product.UnitCode;
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!isForUpdate)
                frm.product.Unit = new UnitMeasurement();
            frm.product.Unit.UnitCode = cbUnitCode.Text;
            frm.product.Unit.id = cbUnitCode.Text != ""? int.Parse(cbUnitCode.SelectedValue.ToString()):0;
            frm.product.Unit.Qty = txtQty.Text !="" ? double.Parse(txtQty.Text):0;
            var rules = new ProductUnitValidator();
            var result = rules.Validate(frm.product);
            string msg = null;

            if (!result.IsValid)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isForUpdate)
            {
                frm.product.Unit.ugID = umodel.insert(frm.product);
                if(frm.product.Unit.ugID != 0)
                {
                    MessageBox.Show("New Unit of Measure Registered Successfully");
                    frm.product.UnitList.Add(frm.product.Unit);
                    ProductUnitList();
                }
            } else
            {
                if(umodel.update(frm.product.Unit))
                {
                    MessageBox.Show("Unit of Measure Updated Successfully");
                    foreach(var item in frm.product.UnitList)
                    {
                        if(item.ugID == frm.product.Unit.ugID)
                        {
                            item.UnitCode = frm.product.Unit.UnitCode;
                            item.Qty = frm.product.Unit.Qty;
                        }
                    }
                    ProductUnitList();
                }
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

       
      

        private void cbDefaultUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
          if(cbDefaultUnit.Text != "")
            {
                var result = MessageBox.Show("Do you to set Default Base of Measure?", umodel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    frm.product.UnitID= int.Parse(cbDefaultUnit.SelectedValue.ToString());
                    frm._UnitCode = cbDefaultUnit.Text;
                    if (umodel.SetProductDefaultUnit(frm.product))
                    {
                        frm._UnitCode = cbDefaultUnit.Text;
                        MessageBox.Show("Deafult Base Unit is Now Set.");
                        frm.product.UnitCode = cbDefaultUnit.Text;
                        frm.EnableAddNewProduct();
                        foreach (var item in frm.product.UnitList)
                        {
                            if (item.ugID == frm.product.Unit.ugID)
                                item.DefaultUnit = true;
                            else
                                item.DefaultUnit = false;
                        }
                    }
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbUnitCode.Text = "";
            txtQty.Text = "";
            isForUpdate = false;
        }

        private void UnitCollectionDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=  0)
            {
                switch (UnitCollectionDG.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        isForUpdate = true;
                        cbUnitCode.Text = UnitCollectionDG.CurrentRow.Cells["unitCode"].Value.ToString();
                        txtQty.Text = UnitCollectionDG.CurrentRow.Cells["qty"].Value.ToString();
                        frm.product.Unit.ugID = int.Parse(UnitCollectionDG.CurrentRow.Cells["ugID"].Value.ToString());
                        break;
                    case "delete":
                        int ugID = int.Parse(UnitCollectionDG.CurrentRow.Cells["ugID"].Value.ToString());
                        var result = MessageBox.Show("Do you want to delete selected row?", umodel.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (umodel.delete(ugID, "tbl_unit_grp"))
                                MessageBox.Show("Selected Row Deleted.");
                            UnitCollectionDG.Rows.Remove(UnitCollectionDG.CurrentRow);
                            frm.product.UnitList.RemoveAll(id => id.ugID == ugID);
                        }

                        break;
                }

            }
        }
    }
}
