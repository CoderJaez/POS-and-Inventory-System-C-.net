using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmChange : Form
    {
        public frmChange(string change)
        {
            InitializeComponent();
            lblChange.Text = change;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Close();
        }
    }
}
