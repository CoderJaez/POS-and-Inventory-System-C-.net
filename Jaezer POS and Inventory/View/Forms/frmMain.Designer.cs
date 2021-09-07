namespace Jaezer_POS_and_Inventory.View
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SidePanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.CompanyLogo = new System.Windows.Forms.PictureBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnStockEntry = new System.Windows.Forms.Button();
            this.btnStockAdjustment = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.btnExpensesSettings = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnInventorySetup = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModuleDesc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SidePanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            this.SettingsPanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(933, 30);
            this.panel1.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(902, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SidePanelMenu
            // 
            this.SidePanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.SidePanelMenu.Controls.Add(this.CompanyLogo);
            this.SidePanelMenu.Controls.Add(this.lblUserType);
            this.SidePanelMenu.Controls.Add(this.lblFullname);
            this.SidePanelMenu.Controls.Add(this.btnDashboard);
            this.SidePanelMenu.Controls.Add(this.btnPOS);
            this.SidePanelMenu.Controls.Add(this.btnSales);
            this.SidePanelMenu.Controls.Add(this.btnDiscount);
            this.SidePanelMenu.Controls.Add(this.btnStockEntry);
            this.SidePanelMenu.Controls.Add(this.btnStockAdjustment);
            this.SidePanelMenu.Controls.Add(this.btnInventory);
            this.SidePanelMenu.Controls.Add(this.btnExpenses);
            this.SidePanelMenu.Controls.Add(this.btnReports);
            this.SidePanelMenu.Controls.Add(this.SettingsPanel);
            this.SidePanelMenu.Controls.Add(this.btnLogout);
            this.SidePanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SidePanelMenu.Location = new System.Drawing.Point(0, 30);
            this.SidePanelMenu.Name = "SidePanelMenu";
            this.SidePanelMenu.Size = new System.Drawing.Size(166, 639);
            this.SidePanelMenu.TabIndex = 1;
            // 
            // CompanyLogo
            // 
            this.CompanyLogo.BackgroundImage = global::Jaezer_POS_and_Inventory.Properties.Resources.AkiNi__1_;
            this.CompanyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CompanyLogo.Location = new System.Drawing.Point(30, 20);
            this.CompanyLogo.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.CompanyLogo.Name = "CompanyLogo";
            this.CompanyLogo.Size = new System.Drawing.Size(108, 79);
            this.CompanyLogo.TabIndex = 0;
            this.CompanyLogo.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserType.Location = new System.Drawing.Point(3, 119);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(162, 16);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "Administrator";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFullname.Location = new System.Drawing.Point(3, 145);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(162, 16);
            this.lblFullname.TabIndex = 9;
            this.lblFullname.Text = "Administrator";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 174);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(162, 30);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Location = new System.Drawing.Point(3, 207);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(162, 30);
            this.btnPOS.TabIndex = 7;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(3, 240);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(162, 30);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(3, 273);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(162, 30);
            this.btnDiscount.TabIndex = 11;
            this.btnDiscount.Text = "Item Discount";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnStockEntry
            // 
            this.btnStockEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnStockEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockEntry.FlatAppearance.BorderSize = 0;
            this.btnStockEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnStockEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnStockEntry.Image")));
            this.btnStockEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockEntry.Location = new System.Drawing.Point(3, 306);
            this.btnStockEntry.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnStockEntry.Name = "btnStockEntry";
            this.btnStockEntry.Size = new System.Drawing.Size(162, 30);
            this.btnStockEntry.TabIndex = 5;
            this.btnStockEntry.Text = "Stock Entry";
            this.btnStockEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockEntry.UseVisualStyleBackColor = false;
            this.btnStockEntry.Click += new System.EventHandler(this.btnStockEntry_Click);
            // 
            // btnStockAdjustment
            // 
            this.btnStockAdjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnStockAdjustment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockAdjustment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockAdjustment.FlatAppearance.BorderSize = 0;
            this.btnStockAdjustment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnStockAdjustment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnStockAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAdjustment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockAdjustment.Image = ((System.Drawing.Image)(resources.GetObject("btnStockAdjustment.Image")));
            this.btnStockAdjustment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockAdjustment.Location = new System.Drawing.Point(3, 339);
            this.btnStockAdjustment.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnStockAdjustment.Name = "btnStockAdjustment";
            this.btnStockAdjustment.Size = new System.Drawing.Size(162, 30);
            this.btnStockAdjustment.TabIndex = 6;
            this.btnStockAdjustment.Text = "Stock Adjustment";
            this.btnStockAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockAdjustment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockAdjustment.UseVisualStyleBackColor = false;
            this.btnStockAdjustment.Click += new System.EventHandler(this.btnStockAdjustment_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(3, 372);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(162, 30);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Visible = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenses.Image")));
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(3, 405);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(162, 30);
            this.btnExpenses.TabIndex = 13;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 438);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(162, 30);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.SettingsPanel.Controls.Add(this.btnExpensesSettings);
            this.SettingsPanel.Controls.Add(this.btnUser);
            this.SettingsPanel.Controls.Add(this.btnCompany);
            this.SettingsPanel.Controls.Add(this.btnInventorySetup);
            this.SettingsPanel.Controls.Add(this.btnSettings);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 468);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.MaximumSize = new System.Drawing.Size(166, 150);
            this.SettingsPanel.MinimumSize = new System.Drawing.Size(166, 30);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(166, 30);
            this.SettingsPanel.TabIndex = 4;
            // 
            // btnExpensesSettings
            // 
            this.btnExpensesSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnExpensesSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpensesSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpensesSettings.FlatAppearance.BorderSize = 0;
            this.btnExpensesSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExpensesSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnExpensesSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpensesSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesSettings.Location = new System.Drawing.Point(0, 120);
            this.btnExpensesSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnExpensesSettings.Name = "btnExpensesSettings";
            this.btnExpensesSettings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExpensesSettings.Size = new System.Drawing.Size(166, 30);
            this.btnExpensesSettings.TabIndex = 14;
            this.btnExpensesSettings.Text = "Expenses";
            this.btnExpensesSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpensesSettings.UseVisualStyleBackColor = false;
            this.btnExpensesSettings.Click += new System.EventHandler(this.btnExpensesSettings_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 90);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(166, 30);
            this.btnUser.TabIndex = 13;
            this.btnUser.Text = "User Settings";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompany.FlatAppearance.BorderSize = 0;
            this.btnCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompany.Location = new System.Drawing.Point(0, 60);
            this.btnCompany.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCompany.Size = new System.Drawing.Size(166, 30);
            this.btnCompany.TabIndex = 10;
            this.btnCompany.Text = "Establishment Profile";
            this.btnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnInventorySetup
            // 
            this.btnInventorySetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnInventorySetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventorySetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventorySetup.FlatAppearance.BorderSize = 0;
            this.btnInventorySetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnInventorySetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnInventorySetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventorySetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInventorySetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventorySetup.Location = new System.Drawing.Point(0, 30);
            this.btnInventorySetup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnInventorySetup.Name = "btnInventorySetup";
            this.btnInventorySetup.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInventorySetup.Size = new System.Drawing.Size(166, 30);
            this.btnInventorySetup.TabIndex = 5;
            this.btnInventorySetup.Text = "Inventory Setup";
            this.btnInventorySetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventorySetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventorySetup.UseVisualStyleBackColor = false;
            this.btnInventorySetup.Click += new System.EventHandler(this.btnInventorySetup_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_collapse_arrow_16;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(166, 30);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 501);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 30);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.Location = new System.Drawing.Point(166, 69);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MainPanel.Size = new System.Drawing.Size(767, 600);
            this.MainPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.ModuleDesc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 39);
            this.panel2.TabIndex = 4;
            // 
            // ModuleDesc
            // 
            this.ModuleDesc.Dock = System.Windows.Forms.DockStyle.Left;
            this.ModuleDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleDesc.Location = new System.Drawing.Point(0, 0);
            this.ModuleDesc.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.ModuleDesc.Name = "ModuleDesc";
            this.ModuleDesc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ModuleDesc.Size = new System.Drawing.Size(227, 39);
            this.ModuleDesc.TabIndex = 3;
            this.ModuleDesc.Text = "Dashboard";
            this.ModuleDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 669);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SidePanelMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.SidePanelMenu.ResumeLayout(false);
            this.SidePanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel SidePanelMenu;
        private System.Windows.Forms.PictureBox CompanyLogo;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnInventorySetup;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ModuleDesc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnStockEntry;
        private System.Windows.Forms.Button btnStockAdjustment;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnExpensesSettings;
        private System.Windows.Forms.Button btnExpenses;
    }
}