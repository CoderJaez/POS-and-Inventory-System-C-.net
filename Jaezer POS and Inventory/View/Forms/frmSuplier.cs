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
using MetroFramework.Controls;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmSuplier : Form
    {
        private string msg;
        private frmAddress frm;
        private SupplierUC uc;
        private SupplierModel model = new SupplierModel();
        private bool isForUpdate;
        public Supplier obj = new Supplier();
        public string brgy { set { txtBrgy.Text = value; } get { return txtBrgy.Text; } }
        public string citymun {set { txtCityMun.Text = value; } get { return txtCityMun.Text; } }
        public string prov { set { txtProv.Text = value; } get { return txtProv.Text; } }
        
        public frmSuplier(SupplierUC _uc, int SupplierID, bool forUpdate)
        {
            InitializeComponent();
            uc = _uc;
            isForUpdate = forUpdate;
            if (forUpdate)
                LoadSupplierInfo(SupplierID);
        }

        private void LoadSupplierInfo(int id)
        {
            obj = model.LoadSupplierInfo(id);
            txtCompanyName.Text = obj.BusinessName;
            txtSupplierName.Text = obj.SupplierName;
            txtContactNo.Text = obj.ContactNo;
            txtStreetAdd.Text = obj.StreetAddress;
            brgy = obj.brgy.BrgyDesc;
            citymun = obj.citymun.CityMunDesc;
            prov = obj.prov.ProvDesc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            frm = new frmAddress(this, "province");
            frm.ShowDialog();
        }

        private void btnCityMun_Click(object sender, EventArgs e)
        {
            msg = null;
            var rule = new CityMunValidator();
            var result = rule.Validate(obj.citymun);
            if (!result.IsValid)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frm = new frmAddress(this, "city/municipality",obj.prov.ProvCode);
            frm.ShowDialog();
        }

        private void btnBrgy_Click(object sender, EventArgs e)
        {
            msg = null;
            var rule = new BarangayValidator();
            var result = rule.Validate(obj.brgy);
            if (!result.IsValid)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frm = new frmAddress(this, "barangay",obj.citymun.CityMunCode);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            obj.SupplierName = txtSupplierName.Text;
            obj.BusinessName = txtCompanyName.Text;
            obj.ContactNo = txtContactNo.Text;
            obj.StreetAddress = txtStreetAdd.Text;
            obj.brgy.BrgyDesc = brgy;
            obj.citymun.CityMunDesc = citymun;
            obj.prov.ProvDesc = prov; 

            var rules = new SupplierValidator();
            var result = rules.Validate(obj);
             msg = null;
            if(!result.IsValid)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!isForUpdate)
            {
                if (model.insert(obj))
                {
                    MessageBox.Show("Registration successfull", model.AppName);
                    clear();

                }
            } else
            {
                if (model.update(obj))
                {
                    MessageBox.Show("Update successfull", model.AppName);
                    this.Close();
                }
            }
        }

        private void clear()
        {
            obj.brgy.hasCityMunicipality = false;
            obj.citymun.hasProvince = false;
            foreach(Control obj in groupBox1.Controls)
                if(obj.GetType() == typeof(MetroTextBox))
                    obj.Text = null;
            foreach (Control obj in groupBox2.Controls)
                if (obj.GetType() == typeof(MetroTextBox))
                    obj.Text = null;

        }

    }
}
