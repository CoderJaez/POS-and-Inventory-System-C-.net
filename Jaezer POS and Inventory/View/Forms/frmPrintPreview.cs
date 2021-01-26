using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmPrintPreview : Form
    {
        ReportDataSource rs;
        ReportDataSource[] rs1;
        private string rdlc;
        ReportParameter[] p;
        public frmPrintPreview(ReportDataSource _rs, string _rdlc,ReportParameter[] _p)
        {
            InitializeComponent();
            rs = _rs;
            rdlc = _rdlc;
            p = _p;
        }

        public frmPrintPreview(ReportDataSource[] _rs, string _rdlc, ReportParameter[] _p)
        {
            InitializeComponent();
            rs1 = _rs;
            rdlc = _rdlc;
            p = _p;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrintPreview_Load(object sender, EventArgs e)
        {

            ReportsRV.LocalReport.DataSources.Clear();
            if(rs != null)
            {
                ReportsRV.LocalReport.DataSources.Add(rs);
            }
            else
            {
                foreach ( ReportDataSource item in rs1)
                {
                    ReportsRV.LocalReport.DataSources.Add(item);
                }
            }
            ReportsRV.LocalReport.ReportEmbeddedResource = rdlc;
            ReportsRV.LocalReport.EnableExternalImages = true;
            ReportsRV.LocalReport.SetParameters(p);
            this.ReportsRV.RefreshReport();
        }
    }
}
