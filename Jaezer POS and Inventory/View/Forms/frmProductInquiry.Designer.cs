namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmProductInquiry
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductInquiry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelQty = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.ProdPriceDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Onhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasExpiry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsSale = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdPriceDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 30);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(96, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "POS and Inventory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jaezer Tech";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(683, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.panelQty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SearchTxt);
            this.panel2.Controls.Add(this.ProdPriceDG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 499);
            this.panel2.TabIndex = 9;
            // 
            // panelQty
            // 
            this.panelQty.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelQty.Controls.Add(this.txtQty);
            this.panelQty.Location = new System.Drawing.Point(243, 203);
            this.panelQty.Name = "panelQty";
            this.panelQty.Padding = new System.Windows.Forms.Padding(5);
            this.panelQty.Size = new System.Drawing.Size(244, 83);
            this.panelQty.TabIndex = 10;
            this.panelQty.Visible = false;
            // 
            // txtQty
            // 
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(5, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(234, 73);
            this.txtQty.TabIndex = 0;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "[Esc] Close Product Inquiry  [F1] Search Product";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product List ";
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.CustomButton.Image = null;
            this.SearchTxt.CustomButton.Location = new System.Drawing.Point(286, 1);
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
            this.SearchTxt.Location = new System.Drawing.Point(334, 27);
            this.SearchTxt.MaxLength = 32767;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PromptText = "Search here";
            this.SearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.SelectionLength = 0;
            this.SearchTxt.SelectionStart = 0;
            this.SearchTxt.ShortcutsEnabled = true;
            this.SearchTxt.Size = new System.Drawing.Size(308, 23);
            this.SearchTxt.TabIndex = 0;
            this.SearchTxt.UseSelectable = true;
            this.SearchTxt.WaterMark = "Search here";
            this.SearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            this.SearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyDown);
            // 
            // ProdPriceDG
            // 
            this.ProdPriceDG.AllowUserToAddRows = false;
            this.ProdPriceDG.AllowUserToResizeColumns = false;
            this.ProdPriceDG.AllowUserToResizeRows = false;
            this.ProdPriceDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProdPriceDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdPriceDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdPriceDG.ColumnHeadersHeight = 30;
            this.ProdPriceDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProdPriceDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceID,
            this.ProdID,
            this.no,
            this.ProductName,
            this.Onhand,
            this.price,
            this.Discount,
            this.prUnit,
            this.prQty,
            this.hasExpiry,
            this.IsSale,
            this.add});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdPriceDG.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProdPriceDG.EnableHeadersVisualStyles = false;
            this.ProdPriceDG.Location = new System.Drawing.Point(13, 56);
            this.ProdPriceDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ProdPriceDG.MultiSelect = false;
            this.ProdPriceDG.Name = "ProdPriceDG";
            this.ProdPriceDG.ReadOnly = true;
            this.ProdPriceDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdPriceDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProdPriceDG.RowHeadersVisible = false;
            this.ProdPriceDG.RowHeadersWidth = 40;
            this.ProdPriceDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProdPriceDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdPriceDG.Size = new System.Drawing.Size(691, 397);
            this.ProdPriceDG.TabIndex = 4;
            this.ProdPriceDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdPriceDG_CellContentClick);
            this.ProdPriceDG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProdPriceDG_KeyDown);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_buy_32;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // PriceID
            // 
            this.PriceID.HeaderText = "";
            this.PriceID.Name = "PriceID";
            this.PriceID.ReadOnly = true;
            this.PriceID.Visible = false;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "prodID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            this.ProdID.Visible = false;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.no.HeaderText = "";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 17;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductName.HeaderText = "Description";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Onhand
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Onhand.DefaultCellStyle = dataGridViewCellStyle3;
            this.Onhand.HeaderText = "Onhand";
            this.Onhand.Name = "Onhand";
            this.Onhand.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Less";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 80;
            // 
            // prUnit
            // 
            this.prUnit.HeaderText = "PriceUnit";
            this.prUnit.Name = "prUnit";
            this.prUnit.ReadOnly = true;
            this.prUnit.Visible = false;
            // 
            // prQty
            // 
            this.prQty.HeaderText = "PriceQty";
            this.prQty.Name = "prQty";
            this.prQty.ReadOnly = true;
            this.prQty.Visible = false;
            // 
            // hasExpiry
            // 
            this.hasExpiry.HeaderText = "Has Expiry Date";
            this.hasExpiry.Name = "hasExpiry";
            this.hasExpiry.ReadOnly = true;
            this.hasExpiry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hasExpiry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hasExpiry.Visible = false;
            // 
            // IsSale
            // 
            this.IsSale.HeaderText = "Is Prod Sale";
            this.IsSale.Name = "IsSale";
            this.IsSale.ReadOnly = true;
            this.IsSale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsSale.Visible = false;
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.add.DefaultCellStyle = dataGridViewCellStyle4;
            this.add.HeaderText = "";
            this.add.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_buy_32;
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Width = 5;
            // 
            // frmProductInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(720, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductInquiry";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".";
            this.Load += new System.EventHandler(this.frmProductInquiry_Load);
            this.Shown += new System.EventHandler(this.frmProductInquiry_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductInquiry_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelQty.ResumeLayout(false);
            this.panelQty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdPriceDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ProdPriceDG;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox SearchTxt;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Onhand;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn prUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prQty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasExpiry;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSale;
        private System.Windows.Forms.DataGridViewImageColumn add;
    }
}