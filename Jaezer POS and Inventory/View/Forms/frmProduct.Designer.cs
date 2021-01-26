namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUnitCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbHasExpire = new MetroFramework.Controls.MetroCheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDayBExp = new MetroFramework.Controls.MetroTextBox();
            this.txtReOrderLvl = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbBrand = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.PriceListDG = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewPrice = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceListDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 30);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnClose.Location = new System.Drawing.Point(420, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUnitCode);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.cbHasExpire);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDayBExp);
            this.groupBox1.Controls.Add(this.txtReOrderLvl);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.cbBrand);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 265);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnitCode.Location = new System.Drawing.Point(145, 179);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(261, 23);
            this.lblUnitCode.TabIndex = 29;
            this.lblUnitCode.Text = "Not Set";
            this.lblUnitCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Base Unit:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.LightGray;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNew.Location = new System.Drawing.Point(316, 217);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 25);
            this.btnAddNew.TabIndex = 27;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Visible = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(55, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "&Unit Of Measure";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Location = new System.Drawing.Point(145, 88);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(261, 29);
            this.cbCategory.TabIndex = 18;
            this.cbCategory.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 98);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Category:";
            // 
            // cbHasExpire
            // 
            this.cbHasExpire.AutoSize = true;
            this.cbHasExpire.Location = new System.Drawing.Point(145, 155);
            this.cbHasExpire.Name = "cbHasExpire";
            this.cbHasExpire.Size = new System.Drawing.Size(109, 15);
            this.cbHasExpire.TabIndex = 24;
            this.cbHasExpire.Text = "With Expiry Date";
            this.cbHasExpire.UseSelectable = true;
            this.cbHasExpire.CheckedChanged += new System.EventHandler(this.cbHasExpire_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(200, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 25);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save Product";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDayBExp
            // 
            // 
            // 
            // 
            this.txtDayBExp.CustomButton.Image = null;
            this.txtDayBExp.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtDayBExp.CustomButton.Name = "";
            this.txtDayBExp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDayBExp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDayBExp.CustomButton.TabIndex = 1;
            this.txtDayBExp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDayBExp.CustomButton.UseSelectable = true;
            this.txtDayBExp.CustomButton.Visible = false;
            this.txtDayBExp.Lines = new string[0];
            this.txtDayBExp.Location = new System.Drawing.Point(254, 152);
            this.txtDayBExp.MaxLength = 32767;
            this.txtDayBExp.Name = "txtDayBExp";
            this.txtDayBExp.PasswordChar = '\0';
            this.txtDayBExp.PromptText = "Day Before Expiry Date";
            this.txtDayBExp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDayBExp.SelectedText = "";
            this.txtDayBExp.SelectionLength = 0;
            this.txtDayBExp.SelectionStart = 0;
            this.txtDayBExp.ShortcutsEnabled = true;
            this.txtDayBExp.Size = new System.Drawing.Size(152, 23);
            this.txtDayBExp.TabIndex = 21;
            this.txtDayBExp.UseSelectable = true;
            this.txtDayBExp.Visible = false;
            this.txtDayBExp.WaterMark = "Day Before Expiry Date";
            this.txtDayBExp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDayBExp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReOrderLvl
            // 
            // 
            // 
            // 
            this.txtReOrderLvl.CustomButton.Image = null;
            this.txtReOrderLvl.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtReOrderLvl.CustomButton.Name = "";
            this.txtReOrderLvl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReOrderLvl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReOrderLvl.CustomButton.TabIndex = 1;
            this.txtReOrderLvl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReOrderLvl.CustomButton.UseSelectable = true;
            this.txtReOrderLvl.CustomButton.Visible = false;
            this.txtReOrderLvl.Lines = new string[0];
            this.txtReOrderLvl.Location = new System.Drawing.Point(145, 123);
            this.txtReOrderLvl.MaxLength = 32767;
            this.txtReOrderLvl.Name = "txtReOrderLvl";
            this.txtReOrderLvl.PasswordChar = '\0';
            this.txtReOrderLvl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReOrderLvl.SelectedText = "";
            this.txtReOrderLvl.SelectionLength = 0;
            this.txtReOrderLvl.SelectionStart = 0;
            this.txtReOrderLvl.ShortcutsEnabled = true;
            this.txtReOrderLvl.Size = new System.Drawing.Size(261, 23);
            this.txtReOrderLvl.TabIndex = 21;
            this.txtReOrderLvl.UseSelectable = true;
            this.txtReOrderLvl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReOrderLvl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Re-Order Level:";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.ItemHeight = 23;
            this.cbBrand.Location = new System.Drawing.Point(145, 53);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(261, 29);
            this.cbBrand.TabIndex = 16;
            this.cbBrand.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Brand";
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(145, 24);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(261, 23);
            this.txtProductName.TabIndex = 15;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Product Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.PriceListDG);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 268);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price List";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(387, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PriceListDG
            // 
            this.PriceListDG.AllowUserToAddRows = false;
            this.PriceListDG.AllowUserToResizeColumns = false;
            this.PriceListDG.AllowUserToResizeRows = false;
            this.PriceListDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceListDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceListDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceListDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PriceListDG.ColumnHeadersHeight = 30;
            this.PriceListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PriceListDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Barcode,
            this.Variant,
            this.Price,
            this.UnitCode,
            this.edit,
            this.delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PriceListDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.PriceListDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceListDG.EnableHeadersVisualStyles = false;
            this.PriceListDG.Location = new System.Drawing.Point(3, 21);
            this.PriceListDG.Name = "PriceListDG";
            this.PriceListDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceListDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PriceListDG.RowHeadersVisible = false;
            this.PriceListDG.RowHeadersWidth = 40;
            this.PriceListDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PriceListDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PriceListDG.Size = new System.Drawing.Size(419, 209);
            this.PriceListDG.TabIndex = 10;
            this.PriceListDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PriceListDG_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            // 
            // Variant
            // 
            this.Variant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Variant.HeaderText = "Variant Code";
            this.Variant.Name = "Variant";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // UnitCode
            // 
            this.UnitCode.HeaderText = "Unit";
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.Width = 50;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_edit_16;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 17;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_remove_16;
            this.delete.Name = "delete";
            this.delete.Width = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 35);
            this.panel2.TabIndex = 11;
            // 
            // btnNewPrice
            // 
            this.btnNewPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNewPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnNewPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewPrice.Location = new System.Drawing.Point(275, 6);
            this.btnNewPrice.Name = "btnNewPrice";
            this.btnNewPrice.Size = new System.Drawing.Size(131, 25);
            this.btnNewPrice.TabIndex = 25;
            this.btnNewPrice.Text = "&Add New Price";
            this.btnNewPrice.UseVisualStyleBackColor = false;
            this.btnNewPrice.Click += new System.EventHandler(this.btnNewPrice_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_edit_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_remove_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(451, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProduct";
            this.Shown += new System.EventHandler(this.frmProduct_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceListDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox cbHasExpire;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtReOrderLvl;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbBrand;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PriceListDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewPrice;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCode;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddNew;
        private MetroFramework.Controls.MetroLabel lblUnitCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDayBExp;
    }
}