namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmExpiryItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpiryItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ExpiryItemsDG = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysBExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Onhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryItemsDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.ExpiryItemsDG);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(851, 510);
            this.mainPanel.TabIndex = 0;
            // 
            // ExpiryItemsDG
            // 
            this.ExpiryItemsDG.AllowUserToAddRows = false;
            this.ExpiryItemsDG.AllowUserToResizeColumns = false;
            this.ExpiryItemsDG.AllowUserToResizeRows = false;
            this.ExpiryItemsDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpiryItemsDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExpiryItemsDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpiryItemsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpiryItemsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpiryItemsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.ProdID,
            this.ReferenceNo,
            this.ProductName,
            this.DateArrival,
            this.DateExpiry,
            this.DaysBExp,
            this.Onhand,
            this._Unit,
            this.StockID,
            this.delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpiryItemsDG.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExpiryItemsDG.EnableHeadersVisualStyles = false;
            this.ExpiryItemsDG.Location = new System.Drawing.Point(10, 126);
            this.ExpiryItemsDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ExpiryItemsDG.MultiSelect = false;
            this.ExpiryItemsDG.Name = "ExpiryItemsDG";
            this.ExpiryItemsDG.ReadOnly = true;
            this.ExpiryItemsDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpiryItemsDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ExpiryItemsDG.RowHeadersVisible = false;
            this.ExpiryItemsDG.RowHeadersWidth = 40;
            this.ExpiryItemsDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ExpiryItemsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpiryItemsDG.Size = new System.Drawing.Size(831, 367);
            this.ExpiryItemsDG.TabIndex = 16;
            this.ExpiryItemsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpiryItemsDG_CellClick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "The lits of items that are expired or nearly end expiration date.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expiry Items ";
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
            this.panel1.Size = new System.Drawing.Size(851, 30);
            this.panel1.TabIndex = 6;
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
            this.btnClose.Location = new System.Drawing.Point(820, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // n
            // 
            this.n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.n.HeaderText = "";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 5;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ProductID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            this.ProdID.Visible = false;
            // 
            // ReferenceNo
            // 
            this.ReferenceNo.HeaderText = "Reference #";
            this.ReferenceNo.Name = "ReferenceNo";
            this.ReferenceNo.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Description";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // DateArrival
            // 
            this.DateArrival.HeaderText = "Arrival Date";
            this.DateArrival.Name = "DateArrival";
            this.DateArrival.ReadOnly = true;
            this.DateArrival.Width = 80;
            // 
            // DateExpiry
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateExpiry.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateExpiry.HeaderText = "Expiry Date";
            this.DateExpiry.Name = "DateExpiry";
            this.DateExpiry.ReadOnly = true;
            this.DateExpiry.Width = 80;
            // 
            // DaysBExp
            // 
            this.DaysBExp.HeaderText = "Day Bef Exp";
            this.DaysBExp.Name = "DaysBExp";
            this.DaysBExp.ReadOnly = true;
            this.DaysBExp.Width = 50;
            // 
            // Onhand
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Onhand.DefaultCellStyle = dataGridViewCellStyle3;
            this.Onhand.HeaderText = "Qty";
            this.Onhand.Name = "Onhand";
            this.Onhand.ReadOnly = true;
            this.Onhand.Width = 50;
            // 
            // _Unit
            // 
            this._Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this._Unit.DefaultCellStyle = dataGridViewCellStyle4;
            this._Unit.HeaderText = "";
            this._Unit.Name = "_Unit";
            this._Unit.ReadOnly = true;
            this._Unit.Width = 17;
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Stock ID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Visible = false;
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
            // frmExpiryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(857, 518);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExpiryItems";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryItemsDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView ExpiryItemsDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysBExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Onhand;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}