namespace Jaezer_POS_and_Inventory.View.User_Control
{
    partial class StockAdjustmentUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAdjustmentUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InventoryDG = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Onhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRemarks = new System.Windows.Forms.ComboBox();
            this.checkRemoveStock = new System.Windows.Forms.CheckBox();
            this.checkAddStock = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblIncharge = new System.Windows.Forms.Label();
            this.SearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReferenceNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.StockInDG = new System.Windows.Forms.DataGridView();
            this.StockinID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStockin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDG)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockInDG)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryDG
            // 
            this.InventoryDG.AllowUserToAddRows = false;
            this.InventoryDG.AllowUserToResizeColumns = false;
            this.InventoryDG.AllowUserToResizeRows = false;
            this.InventoryDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.InventoryDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.InventoryDG.ColumnHeadersHeight = 30;
            this.InventoryDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InventoryDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.n,
            this.ProductName,
            this.Brand,
            this.Category,
            this.reorder,
            this.Onhand,
            this.UnitCode,
            this.view});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryDG.DefaultCellStyle = dataGridViewCellStyle22;
            this.InventoryDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryDG.EnableHeadersVisualStyles = false;
            this.InventoryDG.Location = new System.Drawing.Point(3, 3);
            this.InventoryDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.InventoryDG.Name = "InventoryDG";
            this.InventoryDG.ReadOnly = true;
            this.InventoryDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.InventoryDG.RowHeadersVisible = false;
            this.InventoryDG.RowHeadersWidth = 40;
            this.InventoryDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InventoryDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryDG.Size = new System.Drawing.Size(514, 407);
            this.InventoryDG.TabIndex = 3;
            this.InventoryDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDG_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // n
            // 
            this.n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.n.HeaderText = "";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 17;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Description";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // reorder
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reorder.DefaultCellStyle = dataGridViewCellStyle20;
            this.reorder.HeaderText = "Re Order";
            this.reorder.Name = "reorder";
            this.reorder.ReadOnly = true;
            // 
            // Onhand
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Onhand.DefaultCellStyle = dataGridViewCellStyle21;
            this.Onhand.HeaderText = "Onhand";
            this.Onhand.Name = "Onhand";
            this.Onhand.ReadOnly = true;
            // 
            // UnitCode
            // 
            this.UnitCode.HeaderText = "Base Unit";
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.ReadOnly = true;
            this.UnitCode.Width = 50;
            // 
            // view
            // 
            this.view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.view.HeaderText = "";
            this.view.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_curved_arrow_16;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Width = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbRemarks);
            this.panel1.Controls.Add(this.checkRemoveStock);
            this.panel1.Controls.Add(this.checkAddStock);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblIncharge);
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblReferenceNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 136);
            this.panel1.TabIndex = 4;
            // 
            // cbRemarks
            // 
            this.cbRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemarks.FormattingEnabled = true;
            this.cbRemarks.Location = new System.Drawing.Point(492, 72);
            this.cbRemarks.Name = "cbRemarks";
            this.cbRemarks.Size = new System.Drawing.Size(241, 25);
            this.cbRemarks.TabIndex = 15;
            // 
            // checkRemoveStock
            // 
            this.checkRemoveStock.AutoSize = true;
            this.checkRemoveStock.Location = new System.Drawing.Point(596, 45);
            this.checkRemoveStock.Name = "checkRemoveStock";
            this.checkRemoveStock.Size = new System.Drawing.Size(137, 21);
            this.checkRemoveStock.TabIndex = 14;
            this.checkRemoveStock.Text = "Remove From Stock";
            this.checkRemoveStock.UseVisualStyleBackColor = true;
            this.checkRemoveStock.CheckedChanged += new System.EventHandler(this.checkRemoveStock_CheckedChanged);
            // 
            // checkAddStock
            // 
            this.checkAddStock.AutoSize = true;
            this.checkAddStock.Location = new System.Drawing.Point(492, 45);
            this.checkAddStock.Name = "checkAddStock";
            this.checkAddStock.Size = new System.Drawing.Size(98, 21);
            this.checkAddStock.TabIndex = 13;
            this.checkAddStock.Text = "Add To Stock";
            this.checkAddStock.UseVisualStyleBackColor = true;
            this.checkAddStock.CheckedChanged += new System.EventHandler(this.checkAddStock_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(748, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 25);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblIncharge
            // 
            this.lblIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIncharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIncharge.Location = new System.Drawing.Point(492, 101);
            this.lblIncharge.Name = "lblIncharge";
            this.lblIncharge.Size = new System.Drawing.Size(241, 25);
            this.lblIncharge.TabIndex = 8;
            this.lblIncharge.Text = "Admin";
            this.lblIncharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.CustomButton.Image = null;
            this.SearchTxt.CustomButton.Location = new System.Drawing.Point(232, 1);
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
            this.SearchTxt.Location = new System.Drawing.Point(113, 14);
            this.SearchTxt.MaxLength = 32767;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PromptText = "Search here";
            this.SearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.SelectionLength = 0;
            this.SearchTxt.SelectionStart = 0;
            this.SearchTxt.ShortcutsEnabled = true;
            this.SearchTxt.Size = new System.Drawing.Size(254, 23);
            this.SearchTxt.TabIndex = 6;
            this.SearchTxt.UseSelectable = true;
            this.SearchTxt.WaterMark = "Search here";
            this.SearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Current User:";
            // 
            // lblReferenceNo
            // 
            this.lblReferenceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReferenceNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReferenceNo.Location = new System.Drawing.Point(113, 40);
            this.lblReferenceNo.Name = "lblReferenceNo";
            this.lblReferenceNo.Size = new System.Drawing.Size(254, 25);
            this.lblReferenceNo.TabIndex = 4;
            this.lblReferenceNo.Text = "Reference No";
            this.lblReferenceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Remarks:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(113, 98);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(254, 25);
            this.txtQty.TabIndex = 1;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(818, 57);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(159, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Expired/Near expire";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(818, 14);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Critical/Out Of Stock";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qty:";
            // 
            // lblProductName
            // 
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Location = new System.Drawing.Point(113, 70);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(254, 25);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StockInDG
            // 
            this.StockInDG.AllowUserToAddRows = false;
            this.StockInDG.AllowUserToResizeColumns = false;
            this.StockInDG.AllowUserToResizeRows = false;
            this.StockInDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockInDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockInDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.StockInDG.ColumnHeadersHeight = 40;
            this.StockInDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StockInDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockinID,
            this.ProdID,
            this.n1,
            this.ReferenceNo,
            this.ProdName,
            this.DateStockin,
            this.DateExpire,
            this.qtyP,
            this.costPrice,
            this.qty});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockInDG.DefaultCellStyle = dataGridViewCellStyle26;
            this.StockInDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockInDG.EnableHeadersVisualStyles = false;
            this.StockInDG.Location = new System.Drawing.Point(557, 3);
            this.StockInDG.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.StockInDG.Name = "StockInDG";
            this.StockInDG.ReadOnly = true;
            this.StockInDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockInDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.StockInDG.RowHeadersVisible = false;
            this.StockInDG.RowHeadersWidth = 40;
            this.StockInDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StockInDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockInDG.Size = new System.Drawing.Size(437, 407);
            this.StockInDG.TabIndex = 5;
            this.StockInDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockInDG_CellContentClick);
            // 
            // StockinID
            // 
            this.StockinID.HeaderText = "";
            this.StockinID.Name = "StockinID";
            this.StockinID.ReadOnly = true;
            this.StockinID.Visible = false;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ProductID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            this.ProdID.Visible = false;
            // 
            // n1
            // 
            this.n1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.n1.HeaderText = "";
            this.n1.Name = "n1";
            this.n1.ReadOnly = true;
            this.n1.Width = 17;
            // 
            // ReferenceNo
            // 
            this.ReferenceNo.HeaderText = "Reference #";
            this.ReferenceNo.Name = "ReferenceNo";
            this.ReferenceNo.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.HeaderText = "Description";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // DateStockin
            // 
            this.DateStockin.HeaderText = "Date Stockin";
            this.DateStockin.Name = "DateStockin";
            this.DateStockin.ReadOnly = true;
            // 
            // DateExpire
            // 
            this.DateExpire.HeaderText = "Date Expire";
            this.DateExpire.Name = "DateExpire";
            this.DateExpire.ReadOnly = true;
            // 
            // qtyP
            // 
            this.qtyP.HeaderText = "Qty Purchase";
            this.qtyP.Name = "qtyP";
            this.qtyP.ReadOnly = true;
            this.qtyP.Width = 50;
            // 
            // costPrice
            // 
            this.costPrice.HeaderText = "Price";
            this.costPrice.Name = "costPrice";
            this.costPrice.ReadOnly = true;
            this.costPrice.Width = 80;
            // 
            // qty
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle25;
            this.qty.HeaderText = "Onhand";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_curved_arrow_16;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.9476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.0524F));
            this.tableLayoutPanel1.Controls.Add(this.InventoryDG, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StockInDG, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 136);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 413);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // StockAdjustmentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockAdjustmentUC";
            this.Size = new System.Drawing.Size(997, 549);
            this.Load += new System.EventHandler(this.StockAdjustmentUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockInDG)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryDG;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox SearchTxt;
        private System.Windows.Forms.DataGridView StockInDG;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIncharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReferenceNo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkRemoveStock;
        private System.Windows.Forms.CheckBox checkAddStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Onhand;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCode;
        private System.Windows.Forms.DataGridViewImageColumn view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockinID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStockin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpire;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyP;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
    }
}
