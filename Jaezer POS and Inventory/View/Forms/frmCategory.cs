using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using Jaezer_POS_and_Inventory.Model;
using Jaezer_POS_and_Inventory.View.User_Control;

namespace Jaezer_POS_and_Inventory.View.Forms
{
    public partial class frmCategory : Form
    {
        private Category cat = new Category();
        private CategoryModel catModel = new CategoryModel();
        private CategoryUC catUC;
        private bool isForUpdate;
        
       
        public frmCategory(CategoryUC _catUC, bool forUpdate,Category _cat)
        {
            InitializeComponent();
            catUC = _catUC;
            if (forUpdate)
            {
                cat.id = _cat.id;
                CategoryTxt.Text = _cat.category;
                isForUpdate = forUpdate;
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = null;
            cat.category = CategoryTxt.Text;
            var rules = new CategoryValidator();
            var results = rules.Validate(cat);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure error in results.Errors)
                    msg += $"{error.ErrorMessage}\n";
                MessageBox.Show(msg, $"{Properties.Settings.Default.appname}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isForUpdate)
            {
                if(catModel.updateCategpry(cat))
                {
                    MessageBox.Show("Update Successfull.", catModel.AppName);
                    this.Close();
                }
            } else
            {
                if (catModel.insertCategory(cat))
                {
                    MessageBox.Show("Registration Success", catModel.AppName);
                    Clear();
                }
            }
            catUC.CategoryList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            CategoryTxt.Text = null;
        }

        private void frmCategory_Shown(object sender, EventArgs e)
        {
            CategoryTxt.Focus();
        }

        private void CategoryTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }

      
    }
}
