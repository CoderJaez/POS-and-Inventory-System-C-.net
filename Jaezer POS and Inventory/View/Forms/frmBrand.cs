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
    public partial class frmBrand : Form
    {
        private BrandModel brandModel = new BrandModel();
        private Brand obj = new Brand();
        private bool isForUpdate;
        private BrandUC brandUC;
        public frmBrand(BrandUC _brUC, bool ForUpdate, Brand _obj)
        {
            InitializeComponent();
            brandUC = _brUC;
            if (ForUpdate)
            {
                isForUpdate = ForUpdate;
                obj.id = _obj.id;
                BrandTxt.Text = _obj.brand;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = null;
            obj.brand = BrandTxt.Text;
            var rules = new BrandValidator();
            var result = rules.Validate(obj);

            if (result.IsValid == false)
            {
                foreach (ValidationFailure error in result.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (isForUpdate)
            {
                if (brandModel.update(obj))
                { 
                    MessageBox.Show("Update successfull", brandModel.AppName);
                    BrandTxt.Text = null;
                }
            } else
            {
                if(brandModel.insert(obj))
                {
                    MessageBox.Show("Registration Success", brandModel.AppName);
                    BrandTxt.Text = null;
                }
            }
            brandUC.BrandList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrandTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }

        private void frmBrand_Shown(object sender, EventArgs e)
        {
            BrandTxt.Focus();
        }
    }
}
