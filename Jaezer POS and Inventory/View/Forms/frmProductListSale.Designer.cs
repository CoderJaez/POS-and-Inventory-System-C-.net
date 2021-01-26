namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmProductListSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductListSale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.tbnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateETo = new System.Windows.Forms.DateTimePicker();
            this.dateEFrm = new System.Windows.Forms.DateTimePicker();
            this.ProdSaleDG = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ProdPriceDG = new System.Windows.Forms.DataGridView();
            this.PrcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.prID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdSaleDG)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdPriceDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.tbnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateETo);
            this.panel1.Controls.Add(this.dateEFrm);
            this.panel1.Controls.Add(this.ProdSaleDG);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ProdPriceDG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 505);
            this.panel1.TabIndex = 0;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(128, 107);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(148, 21);
            this.txtDiscount.TabIndex = 28;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // tbnSave
            // 
            this.tbnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.tbnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.tbnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnSave.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbnSave.Location = new System.Drawing.Point(282, 105);
            this.tbnSave.Name = "tbnSave";
            this.tbnSave.Size = new System.Drawing.Size(57, 25);
            this.tbnSave.TabIndex = 26;
            this.tbnSave.Text = "&Save";
            this.tbnSave.UseVisualStyleBackColor = false;
            this.tbnSave.Click += new System.EventHandler(this.tbnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Discount (%)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "End Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Effective Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateETo
            // 
            this.dateETo.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateETo.Location = new System.Drawing.Point(128, 78);
            this.dateETo.Name = "dateETo";
            this.dateETo.Size = new System.Drawing.Size(211, 21);
            this.dateETo.TabIndex = 21;
            this.dateETo.Value = new System.DateTime(2020, 11, 10, 0, 0, 0, 0);
            // 
            // dateEFrm
            // 
            this.dateEFrm.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEFrm.Location = new System.Drawing.Point(128, 49);
            this.dateEFrm.Name = "dateEFrm";
            this.dateEFrm.Size = new System.Drawing.Size(211, 21);
            this.dateEFrm.TabIndex = 22;
            this.dateEFrm.Value = new System.DateTime(2020, 11, 10, 2, 12, 33, 0);
            // 
            // ProdSaleDG
            // 
            this.ProdSaleDG.AllowUserToAddRows = false;
            this.ProdSaleDG.AllowUserToResizeColumns = false;
            this.ProdSaleDG.AllowUserToResizeRows = false;
            this.ProdSaleDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProdSaleDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdSaleDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdSaleDG.ColumnHeadersHeight = 30;
            this.ProdSaleDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProdSaleDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prID,
            this.n,
            this.PSName,
            this.UPrice,
            this.SPrice,
            this.Discount,
            this.delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdSaleDG.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProdSaleDG.EnableHeadersVisualStyles = false;
            this.ProdSaleDG.Location = new System.Drawing.Point(12, 145);
            this.ProdSaleDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ProdSaleDG.MultiSelect = false;
            this.ProdSaleDG.Name = "ProdSaleDG";
            this.ProdSaleDG.ReadOnly = true;
            this.ProdSaleDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdSaleDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProdSaleDG.RowHeadersVisible = false;
            this.ProdSaleDG.RowHeadersWidth = 40;
            this.ProdSaleDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProdSaleDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdSaleDG.Size = new System.Drawing.Size(441, 347);
            this.ProdSaleDG.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 30);
            this.panel2.TabIndex = 20;
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
            this.btnClose.Location = new System.Drawing.Point(846, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProdPriceDG
            // 
            this.ProdPriceDG.AllowUserToAddRows = false;
            this.ProdPriceDG.AllowUserToResizeColumns = false;
            this.ProdPriceDG.AllowUserToResizeRows = false;
            this.ProdPriceDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProdPriceDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdPriceDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProdPriceDG.ColumnHeadersHeight = 30;
            this.ProdPriceDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProdPriceDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrcID,
            this.no,
            this.PName,
            this.price,
            this.add});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdPriceDG.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProdPriceDG.EnableHeadersVisualStyles = false;
            this.ProdPriceDG.Location = new System.Drawing.Point(466, 145);
            this.ProdPriceDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ProdPriceDG.MultiSelect = false;
            this.ProdPriceDG.Name = "ProdPriceDG";
            this.ProdPriceDG.ReadOnly = true;
            this.ProdPriceDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdPriceDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ProdPriceDG.RowHeadersVisible = false;
            this.ProdPriceDG.RowHeadersWidth = 40;
            this.ProdPriceDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProdPriceDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdPriceDG.Size = new System.Drawing.Size(401, 347);
            this.ProdPriceDG.TabIndex = 19;
            this.ProdPriceDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdPriceDG_CellContentClick);
            // 
            // PrcID
            // 
            this.PrcID.HeaderText = "";
            this.PrcID.Name = "PrcID";
            this.PrcID.ReadOnly = true;
            this.PrcID.Visible = false;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.no.HeaderText = "";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 17;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PName.DefaultCellStyle = dataGridViewCellStyle7;
            this.PName.HeaderText = "Description";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.add.DefaultCellStyle = dataGridViewCellStyle8;
            this.add.HeaderText = "";
            this.add.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_left_2_16;
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_buy_32;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_left_2_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // prID
            // 
            this.prID.HeaderText = "";
            this.prID.Name = "prID";
            this.prID.ReadOnly = true;
            this.prID.Visible = false;
            // 
            // n
            // 
            this.n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.n.HeaderText = "";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 17;
            // 
            // PSName
            // 
            this.PSName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PSName.DefaultCellStyle = dataGridViewCellStyle2;
            this.PSName.HeaderText = "Description";
            this.PSName.Name = "PSName";
            this.PSName.ReadOnly = true;
            // 
            // UPrice
            // 
            this.UPrice.HeaderText = "";
            this.UPrice.Name = "UPrice";
            this.UPrice.ReadOnly = true;
            this.UPrice.Visible = false;
            // 
            // SPrice
            // 
            this.SPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SPrice.HeaderText = "Discounted Price";
            this.SPrice.Name = "SPrice";
            this.SPrice.ReadOnly = true;
            this.SPrice.Width = 139;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Less";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete.HeaderText = "";
            this.delete.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_remove_16;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 5;
            // 
            // frmProductListSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(883, 513);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductListSale";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmProductListSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdSaleDG)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdPriceDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button tbnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateETo;
        private System.Windows.Forms.DateTimePicker dateEFrm;
        private System.Windows.Forms.DataGridView ProdSaleDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView ProdPriceDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewImageColumn add;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prID;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}