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
using System.IO;

namespace Jaezer_POS_and_Inventory.View.User_Control
{
    public partial class CompanyProfileUC : UserControl
    {
        CompanyProfileModel pmodel = new CompanyProfileModel();
        public CompanyProfileUC()
        {
            InitializeComponent();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png) | *.jpg; *.jpeg; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgLogo.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supObjt = new Supplier();
            MemoryStream mstream = new MemoryStream();

            supObjt.BusinessName = txtCompanyName.Text;
            supObjt.ContactNo = txtContact.Text;
            supObjt.brgy.BrgyDesc = txtBrgy.Text;
            supObjt.StreetAddress = txtStreetAdd.Text;
            supObjt.citymun.CityMunDesc = txtCity.Text;
            supObjt.prov.ProvDesc = txtProv.Text;
            imgLogo.Image.Save(mstream, imgLogo.Image.RawFormat);
            supObjt.logo  = mstream.GetBuffer();
            mstream.Close();
            if (pmodel.update(supObjt))
            {
                MessageBox.Show("Setup is now complete.");

            }
        }

        private void CompanyProfile()
        {
            var obj = pmodel.getBusinessProfile();
            txtCompanyName.Text = obj.BusinessName;
            txtContact.Text = obj.ContactNo;
            txtBrgy.Text = obj.brgy.BrgyDesc;
            txtCity.Text = obj.citymun.CityMunDesc;
            txtProv.Text = obj.prov.ProvDesc;
            txtStreetAdd.Text = obj.StreetAddress;
            try
            {
                byte[] img = (byte[])obj.logo;
                MemoryStream ms = new MemoryStream(img);
                imgLogo.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }
        }

        private void CompanyProfileUC_Load(object sender, EventArgs e)
        {
            CompanyProfile();
            txtVat.Text = (pmodel.getVal() * 100).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtVat.Enabled = txtVat.Enabled ? false : true;
        }

        private void btnSaveVat_Click(object sender, EventArgs e)
        {
            if (txtVat.Text == "")
                return;
            decimal vat = decimal.Parse(txtVat.Text) / 100;
            if(pmodel.updateVat(vat))
            {
                MessageBox.Show("Vat value is now set!");
                txtVat.Enabled = false;
            }
        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
