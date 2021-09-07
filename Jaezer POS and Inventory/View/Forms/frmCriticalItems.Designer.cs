namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmCriticalItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriticalItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnStockin = new System.Windows.Forms.Button();
            this.ItemsDG = new System.Windows.Forms.DataGridView();
            this.CriticalItemsDG = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasExpiry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BaseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this._n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hasExpiry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._BaseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriticalItemsDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.txtSearch);
            this.mainPanel.Controls.Add(this.btnStockin);
            this.mainPanel.Controls.Add(this.ItemsDG);
            this.mainPanel.Controls.Add(this.CriticalItemsDG);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(820, 501);
            this.mainPanel.TabIndex = 0;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(21, 95);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Productname";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(208, 23);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Productname";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnStockin
            // 
            this.btnStockin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnStockin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnStockin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockin.Font = new System.Drawing.Font("Segoe UI Light", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockin.Location = new System.Drawing.Point(694, 93);
            this.btnStockin.Name = "btnStockin";
            this.btnStockin.Size = new System.Drawing.Size(116, 25);
            this.btnStockin.TabIndex = 18;
            this.btnStockin.Text = "&Add Stocks";
            this.btnStockin.UseVisualStyleBackColor = false;
            this.btnStockin.Click += new System.EventHandler(this.btnStockin_Click);
            // 
            // ItemsDG
            // 
            this.ItemsDG.AllowUserToAddRows = false;
            this.ItemsDG.AllowUserToResizeColumns = false;
            this.ItemsDG.AllowUserToResizeRows = false;
            this.ItemsDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._n,
            this._ProdID,
            this._ProductName,
            this._hasExpiry,
            this._BaseQty,
            this.itemDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDG.EnableHeadersVisualStyles = false;
            this.ItemsDG.Location = new System.Drawing.Point(574, 124);
            this.ItemsDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ItemsDG.MultiSelect = false;
            this.ItemsDG.Name = "ItemsDG";
            this.ItemsDG.ReadOnly = true;
            this.ItemsDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDG.RowHeadersVisible = false;
            this.ItemsDG.RowHeadersWidth = 40;
            this.ItemsDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ItemsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDG.Size = new System.Drawing.Size(236, 357);
            this.ItemsDG.TabIndex = 17;
            this.ItemsDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDG_CellContentClick);
            // 
            // CriticalItemsDG
            // 
            this.CriticalItemsDG.AllowUserToAddRows = false;
            this.CriticalItemsDG.AllowUserToResizeColumns = false;
            this.CriticalItemsDG.AllowUserToResizeRows = false;
            this.CriticalItemsDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriticalItemsDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CriticalItemsDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CriticalItemsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CriticalItemsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CriticalItemsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.ProdID,
            this.ProductName,
            this.hasExpiry,
            this.BaseQty,
            this.Qty,
            this.reorder,
            this.insert});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CriticalItemsDG.DefaultCellStyle = dataGridViewCellStyle5;
            this.CriticalItemsDG.EnableHeadersVisualStyles = false;
            this.CriticalItemsDG.Location = new System.Drawing.Point(16, 124);
            this.CriticalItemsDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.CriticalItemsDG.MultiSelect = false;
            this.CriticalItemsDG.Name = "CriticalItemsDG";
            this.CriticalItemsDG.ReadOnly = true;
            this.CriticalItemsDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CriticalItemsDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CriticalItemsDG.RowHeadersVisible = false;
            this.CriticalItemsDG.RowHeadersWidth = 40;
            this.CriticalItemsDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CriticalItemsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CriticalItemsDG.Size = new System.Drawing.Size(545, 357);
            this.CriticalItemsDG.TabIndex = 17;
            this.CriticalItemsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CriticalItemsDG_CellClick);
            // 
            // n
            // 
            this.n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.n.HeaderText = "";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 27;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ProductID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            this.ProdID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Description";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // hasExpiry
            // 
            this.hasExpiry.HeaderText = "Has Expiry";
            this.hasExpiry.Name = "hasExpiry";
            this.hasExpiry.ReadOnly = true;
            this.hasExpiry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hasExpiry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hasExpiry.Visible = false;
            // 
            // BaseQty
            // 
            this.BaseQty.HeaderText = "BaseQty";
            this.BaseQty.Name = "BaseQty";
            this.BaseQty.ReadOnly = true;
            this.BaseQty.Visible = false;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // reorder
            // 
            this.reorder.HeaderText = "Reorder";
            this.reorder.Name = "reorder";
            this.reorder.ReadOnly = true;
            // 
            // insert
            // 
            this.insert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.insert.HeaderText = "";
            this.insert.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_curved_arrow_16;
            this.insert.Name = "insert";
            this.insert.ReadOnly = true;
            this.insert.Width = 11;
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
            this.panel1.Size = new System.Drawing.Size(820, 30);
            this.panel1.TabIndex = 7;
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
            this.btnClose.Location = new System.Drawing.Point(789, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _n
            // 
            this._n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._n.HeaderText = "";
            this._n.Name = "_n";
            this._n.ReadOnly = true;
            this._n.Width = 11;
            // 
            // _ProdID
            // 
            this._ProdID.HeaderText = "ProductID";
            this._ProdID.Name = "_ProdID";
            this._ProdID.ReadOnly = true;
            this._ProdID.Visible = false;
            // 
            // _ProductName
            // 
            this._ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._ProductName.HeaderText = "Product Description";
            this._ProductName.Name = "_ProductName";
            this._ProductName.ReadOnly = true;
            // 
            // _hasExpiry
            // 
            this._hasExpiry.HeaderText = "Has Expiry";
            this._hasExpiry.Name = "_hasExpiry";
            this._hasExpiry.ReadOnly = true;
            this._hasExpiry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._hasExpiry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._hasExpiry.Visible = false;
            // 
            // _BaseQty
            // 
            this._BaseQty.HeaderText = "BaseQty";
            this._BaseQty.Name = "_BaseQty";
            this._BaseQty.ReadOnly = true;
            this._BaseQty.Visible = false;
            // 
            // itemDelete
            // 
            this.itemDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemDelete.HeaderText = "";
            this.itemDelete.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_remove_16;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.ReadOnly = true;
            this.itemDelete.Width = 11;
            // 
            // frmCriticalItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(826, 509);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCriticalItems";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriticalItemsDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView CriticalItemsDG;
        private System.Windows.Forms.Button btnStockin;
        private System.Windows.Forms.DataGridView ItemsDG;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorder;
        private System.Windows.Forms.DataGridViewImageColumn insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn _n;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ProductName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _hasExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn _BaseQty;
        private System.Windows.Forms.DataGridViewImageColumn itemDelete;
    }
}