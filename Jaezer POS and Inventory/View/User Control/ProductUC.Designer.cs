namespace Jaezer_POS_and_Inventory.View.User_Control
{
    partial class ProductUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductDG = new System.Windows.Forms.DataGridView();
            this.CheckAllCB = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasExpiry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 51);
            this.panel1.TabIndex = 5;
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.CustomButton.Image = null;
            this.SearchTxt.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.SearchTxt.CustomButton.Name = "";
            this.SearchTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTxt.CustomButton.TabIndex = 1;
            this.SearchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTxt.CustomButton.UseSelectable = true;
            this.SearchTxt.CustomButton.Visible = false;
            this.SearchTxt.DisplayIcon = true;
            this.SearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("SearchTxt.Icon")));
            this.SearchTxt.Lines = new string[0];
            this.SearchTxt.Location = new System.Drawing.Point(4, 20);
            this.SearchTxt.MaxLength = 32767;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PromptText = "Search";
            this.SearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.SelectionLength = 0;
            this.SearchTxt.SelectionStart = 0;
            this.SearchTxt.ShortcutsEnabled = true;
            this.SearchTxt.Size = new System.Drawing.Size(231, 23);
            this.SearchTxt.TabIndex = 5;
            this.SearchTxt.UseSelectable = true;
            this.SearchTxt.WaterMark = "Search";
            this.SearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(52)))), ((int)(((byte)(33)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(822, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(761, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductDG
            // 
            this.ProductDG.AllowUserToAddRows = false;
            this.ProductDG.AllowUserToResizeColumns = false;
            this.ProductDG.AllowUserToResizeRows = false;
            this.ProductDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDG.ColumnHeadersHeight = 30;
            this.ProductDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.check,
            this.ProductName,
            this.Brand,
            this.Category,
            this.ReOrder,
            this.unitCode,
            this.HasExpiry,
            this.edit,
            this.delete});
            this.ProductDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDG.EnableHeadersVisualStyles = false;
            this.ProductDG.Location = new System.Drawing.Point(0, 51);
            this.ProductDG.Name = "ProductDG";
            this.ProductDG.ReadOnly = true;
            this.ProductDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDG.RowHeadersVisible = false;
            this.ProductDG.RowHeadersWidth = 40;
            this.ProductDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDG.Size = new System.Drawing.Size(880, 420);
            this.ProductDG.TabIndex = 6;
            this.ProductDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDG_CellContentClick);
            // 
            // CheckAllCB
            // 
            this.CheckAllCB.AutoSize = true;
            this.CheckAllCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.CheckAllCB.Location = new System.Drawing.Point(4, 60);
            this.CheckAllCB.Name = "CheckAllCB";
            this.CheckAllCB.Size = new System.Drawing.Size(15, 14);
            this.CheckAllCB.TabIndex = 7;
            this.CheckAllCB.UseVisualStyleBackColor = false;
            this.CheckAllCB.CheckedChanged += new System.EventHandler(this.CheckAllCB_CheckedChanged);
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 20;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 5;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 5;
            // 
            // ReOrder
            // 
            this.ReOrder.HeaderText = "Re-Order";
            this.ReOrder.MinimumWidth = 10;
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.ReadOnly = true;
            this.ReOrder.Width = 80;
            // 
            // unitCode
            // 
            this.unitCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitCode.HeaderText = "Unit";
            this.unitCode.Name = "unitCode";
            this.unitCode.ReadOnly = true;
            this.unitCode.Width = 55;
            // 
            // HasExpiry
            // 
            this.HasExpiry.HeaderText = "Expiry";
            this.HasExpiry.MinimumWidth = 10;
            this.HasExpiry.Name = "HasExpiry";
            this.HasExpiry.ReadOnly = true;
            this.HasExpiry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HasExpiry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HasExpiry.Width = 50;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_edit_16;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 5;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_remove_16;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 5;
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.CheckAllCB);
            this.Controls.Add(this.ProductDG);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(880, 471);
            this.Load += new System.EventHandler(this.ProductUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox SearchTxt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ProductDG;
        private System.Windows.Forms.CheckBox CheckAllCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HasExpiry;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}
