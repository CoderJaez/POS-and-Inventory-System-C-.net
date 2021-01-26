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


namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmAddress : Form
    {
        private frmSuplier frm;
        private AddressModel aModel = new AddressModel();
        private string location;
        private string locationCode;
       
        public frmAddress(frmSuplier _frm, string _location, string _LocCode = null)
        {
            InitializeComponent();
            frm = _frm;
            location = _location;
            Address.HeaderText = location.ToUpper();
            locationCode = _LocCode;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddress_Load(object sender, EventArgs e)
        {
            LoadLocation();
        }

        private void LoadLocation()
        {
            switch(location)
            {
                case "province":
                    LoadProvince();
                    break;
                case "city/municipality":
                    LoadCityMun();
                    break;
                case "barangay":
                    LoadBrgy();
                    break;
            }
        }

        private void LoadBrgy()
        {
            LocationDG.Rows.Clear();
            foreach (var row in aModel.GetBrgy(locationCode, SearchTxt.Text))
            {
                LocationDG.Rows.Add(row.BrgyCode.ToString(), row.BrgyDesc.ToUpper());
            }
        }

        private void LoadCityMun()
        {
            LocationDG.Rows.Clear();
            foreach (var row in aModel.GetCityMun(locationCode, SearchTxt.Text))
            {
                LocationDG.Rows.Add(row.CityMunCode.ToString(), row.CityMunDesc.ToUpper());
            }
        }

        private void LoadProvince()
        {
            LocationDG.Rows.Clear();
            foreach (var row in aModel.GetProvince(SearchTxt.Text))
            {
                LocationDG.Rows.Add(row.ProvCode.ToString(), row.ProvDesc.ToUpper());
            }
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadLocation();
        }

        private void LocationDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (location)
                {
                    case "province":
                        frm.obj.prov.ProvCode = LocationDG.CurrentRow.Cells["Code"].Value.ToString();
                        frm.obj.citymun.hasProvince = true;
                        frm.prov = LocationDG.CurrentRow.Cells["Address"].Value.ToString();
                        break;
                    case "city/municipality":
                        frm.obj.citymun.CityMunCode = LocationDG.CurrentRow.Cells["Code"].Value.ToString();
                        frm.obj.brgy.hasCityMunicipality = true;
                        frm.citymun = LocationDG.CurrentRow.Cells["Address"].Value.ToString();
                        break;
                    case "barangay":
                        frm.obj.brgy.BrgyCode = LocationDG.CurrentRow.Cells["Code"].Value.ToString();
                        frm.brgy = LocationDG.CurrentRow.Cells["Address"].Value.ToString();
                        break;
                }
               
                this.Close();
            }
        }
    }
}
