namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ProductCartDG = new System.Windows.Forms.DataGridView();
            this.prID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasExpiry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewImageColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.SearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblVatSales = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCancelTransact = new System.Windows.Forms.Button();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnProductInq = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCartDG)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 69);
            this.panel1.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(731, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblTotal.Size = new System.Drawing.Size(367, 69);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(55, 31);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "POS and Inventory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(222, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jaezer Tech";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 72);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1098, 532);
            this.MainPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblTransactionNo);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.ProductCartDG);
            this.panel4.Controls.Add(this.SearchTxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel4.Size = new System.Drawing.Size(833, 362);
            this.panel4.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "[F1] Barcode Search";
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Location = new System.Drawing.Point(128, 15);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(85, 17);
            this.lblTransactionNo.TabIndex = 9;
            this.lblTransactionNo.Text = "00000000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Transaction No:";
            // 
            // ProductCartDG
            // 
            this.ProductCartDG.AllowUserToAddRows = false;
            this.ProductCartDG.AllowUserToResizeColumns = false;
            this.ProductCartDG.AllowUserToResizeRows = false;
            this.ProductCartDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductCartDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductCartDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductCartDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductCartDG.ColumnHeadersHeight = 30;
            this.ProductCartDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductCartDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prID,
            this.prodID,
            this.n,
            this.productName,
            this.price,
            this.qty,
            this.prUnit,
            this.disc,
            this.total,
            this.prQty,
            this.onhand,
            this.hasExpiry,
            this.isSale,
            this.sub,
            this.add,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductCartDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductCartDG.EnableHeadersVisualStyles = false;
            this.ProductCartDG.Location = new System.Drawing.Point(15, 77);
            this.ProductCartDG.MultiSelect = false;
            this.ProductCartDG.Name = "ProductCartDG";
            this.ProductCartDG.ReadOnly = true;
            this.ProductCartDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductCartDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductCartDG.RowHeadersVisible = false;
            this.ProductCartDG.RowHeadersWidth = 40;
            this.ProductCartDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductCartDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductCartDG.Size = new System.Drawing.Size(803, 272);
            this.ProductCartDG.TabIndex = 3;
            this.ProductCartDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductCartDG_CellContentClick);
            // 
            // prID
            // 
            this.prID.HeaderText = "";
            this.prID.Name = "prID";
            this.prID.ReadOnly = true;
            this.prID.Visible = false;
            // 
            // prodID
            // 
            this.prodID.HeaderText = "prodID";
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            this.prodID.Visible = false;
            // 
            // n
            // 
            this.n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.n.HeaderText = "";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 17;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.productName.DefaultCellStyle = dataGridViewCellStyle2;
            this.productName.HeaderText = "Description";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 50;
            // 
            // prUnit
            // 
            this.prUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.prUnit.HeaderText = "Unit";
            this.prUnit.Name = "prUnit";
            this.prUnit.ReadOnly = true;
            this.prUnit.Width = 55;
            // 
            // disc
            // 
            this.disc.HeaderText = "Discount";
            this.disc.Name = "disc";
            this.disc.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // prQty
            // 
            this.prQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prQty.HeaderText = "";
            this.prQty.Name = "prQty";
            this.prQty.ReadOnly = true;
            this.prQty.Visible = false;
            this.prQty.Width = 19;
            // 
            // onhand
            // 
            this.onhand.HeaderText = "onhand";
            this.onhand.Name = "onhand";
            this.onhand.ReadOnly = true;
            this.onhand.Visible = false;
            // 
            // hasExpiry
            // 
            this.hasExpiry.HeaderText = "Has Expiry";
            this.hasExpiry.Name = "hasExpiry";
            this.hasExpiry.ReadOnly = true;
            this.hasExpiry.Visible = false;
            // 
            // isSale
            // 
            this.isSale.HeaderText = "Has Sale";
            this.isSale.Name = "isSale";
            this.isSale.ReadOnly = true;
            this.isSale.Visible = false;
            // 
            // sub
            // 
            this.sub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sub.HeaderText = "";
            this.sub.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_minus_16;
            this.sub.Name = "sub";
            this.sub.ReadOnly = true;
            this.sub.Width = 5;
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.add.HeaderText = "";
            this.add.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_add_16;
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Width = 5;
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
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.CustomButton.Image = null;
            this.SearchTxt.CustomButton.Location = new System.Drawing.Point(628, 2);
            this.SearchTxt.CustomButton.Name = "";
            this.SearchTxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.SearchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTxt.CustomButton.TabIndex = 1;
            this.SearchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTxt.CustomButton.UseSelectable = true;
            this.SearchTxt.CustomButton.Visible = false;
            this.SearchTxt.DisplayIcon = true;
            this.SearchTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("SearchTxt.Icon")));
            this.SearchTxt.Lines = new string[0];
            this.SearchTxt.Location = new System.Drawing.Point(14, 41);
            this.SearchTxt.MaxLength = 32767;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PromptText = "Search Barcode";
            this.SearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.SelectionLength = 0;
            this.SearchTxt.SelectionStart = 0;
            this.SearchTxt.ShortcutsEnabled = true;
            this.SearchTxt.Size = new System.Drawing.Size(656, 30);
            this.SearchTxt.TabIndex = 7;
            this.SearchTxt.UseSelectable = true;
            this.SearchTxt.WaterMark = "Search Barcode";
            this.SearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblAmountDue);
            this.panel3.Controls.Add(this.lblVatSales);
            this.panel3.Controls.Add(this.lblVat);
            this.panel3.Controls.Add(this.lblDiscount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblTotalSales);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 170);
            this.panel3.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(26, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(185, 47);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "00:00:00 ";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmountDue.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAmountDue.Location = new System.Drawing.Point(644, 130);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(182, 30);
            this.lblAmountDue.TabIndex = 4;
            this.lblAmountDue.Text = "0.00";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVatSales
            // 
            this.lblVatSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVatSales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVatSales.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatSales.Location = new System.Drawing.Point(644, 100);
            this.lblVatSales.Name = "lblVatSales";
            this.lblVatSales.Size = new System.Drawing.Size(182, 30);
            this.lblVatSales.TabIndex = 4;
            this.lblVatSales.Text = "0.00";
            this.lblVatSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVat
            // 
            this.lblVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVat.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(637, 70);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(189, 30);
            this.lblVat.TabIndex = 4;
            this.lblVat.Text = "0.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(637, 40);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(189, 30);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount Due";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalSales.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(630, 10);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(195, 30);
            this.lblTotalSales.TabIndex = 4;
            this.lblTotalSales.Text = "0.00";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vatable Sales";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Discount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cashier:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(115, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(251, 27);
            this.lblName.TabIndex = 0;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(31, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(159, 53);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnChangePass);
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.btnCancelTransact);
            this.panel2.Controls.Add(this.btnSettlePayment);
            this.panel2.Controls.Add(this.btnAddDiscount);
            this.panel2.Controls.Add(this.btnProductInq);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(833, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Size = new System.Drawing.Size(265, 532);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.Location = new System.Drawing.Point(6, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(253, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "[F10] Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChangePass.Location = new System.Drawing.Point(6, 185);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnChangePass.Size = new System.Drawing.Size(253, 36);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "[F7] Change Password";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSales.Location = new System.Drawing.Point(6, 149);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(253, 36);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "[F6] Daily Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCancelTransact
            // 
            this.btnCancelTransact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelTransact.FlatAppearance.BorderSize = 0;
            this.btnCancelTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTransact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTransact.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelTransact.Location = new System.Drawing.Point(6, 113);
            this.btnCancelTransact.Name = "btnCancelTransact";
            this.btnCancelTransact.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnCancelTransact.Size = new System.Drawing.Size(253, 36);
            this.btnCancelTransact.TabIndex = 4;
            this.btnCancelTransact.Text = "[F5] Cancel Transaction ";
            this.btnCancelTransact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelTransact.UseVisualStyleBackColor = true;
            this.btnCancelTransact.Click += new System.EventHandler(this.btnCancelTransact_Click);
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettlePayment.FlatAppearance.BorderSize = 0;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlePayment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSettlePayment.Location = new System.Drawing.Point(6, 77);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnSettlePayment.Size = new System.Drawing.Size(253, 36);
            this.btnSettlePayment.TabIndex = 3;
            this.btnSettlePayment.Text = "[F4] Settle Payment";
            this.btnSettlePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettlePayment.UseVisualStyleBackColor = true;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDiscount.FlatAppearance.BorderSize = 0;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiscount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddDiscount.Location = new System.Drawing.Point(6, 41);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAddDiscount.Size = new System.Drawing.Size(253, 36);
            this.btnAddDiscount.TabIndex = 2;
            this.btnAddDiscount.Text = "[F3] Add Discount";
            this.btnAddDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnProductInq
            // 
            this.btnProductInq.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductInq.FlatAppearance.BorderSize = 0;
            this.btnProductInq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInq.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProductInq.Location = new System.Drawing.Point(6, 5);
            this.btnProductInq.Name = "btnProductInq";
            this.btnProductInq.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnProductInq.Size = new System.Drawing.Size(253, 36);
            this.btnProductInq.TabIndex = 1;
            this.btnProductInq.Text = "[F2] Product Inquiry";
            this.btnProductInq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductInq.UseVisualStyleBackColor = true;
            this.btnProductInq.Click += new System.EventHandler(this.btnProductInq_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_minus_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_add_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_remove_16;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1104, 607);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOS";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.Shown += new System.EventHandler(this.frmPOS_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPOS_KeyDown);
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCartDG)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSettlePayment;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Button btnProductInq;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCancelTransact;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVatSales;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView ProductCartDG;
        private MetroFramework.Controls.MetroTextBox SearchTxt;
        private System.Windows.Forms.Label lblTransactionNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn prUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn prQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn onhand;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn isSale;
        private System.Windows.Forms.DataGridViewImageColumn sub;
        private System.Windows.Forms.DataGridViewImageColumn add;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}