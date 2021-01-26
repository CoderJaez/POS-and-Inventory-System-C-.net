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
    public partial class frmLoadingScreen : Form
    {
        public ProgressBar pb { get; set; }
        public frmLoadingScreen()
        {
            InitializeComponent();
            pb = progressBar;
        }
    }
}
