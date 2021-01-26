namespace Jaezer_POS_and_Inventory.View.User_Control
{
    partial class DailySalesUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySalesUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SoldItemsDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterGB = new System.Windows.Forms.GroupBox();
            this.cbUserID = new System.Windows.Forms.ComboBox();
            this.datePTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SoldItemsDG)).BeginInit();
            this.FilterGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoldItemsDG
            // 
            this.SoldItemsDG.AllowUserToAddRows = false;
            this.SoldItemsDG.AllowUserToResizeColumns = false;
            this.SoldItemsDG.AllowUserToResizeRows = false;
            this.SoldItemsDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoldItemsDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SoldItemsDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SoldItemsDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SoldItemsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SoldItemsDG.ColumnHeadersHeight = 40;
            this.SoldItemsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SoldItemsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatID,
            this.invoice,
            this.ProdName,
            this.CostPrice,
            this.price,
            this.qty,
            this.unit,
            this.discount,
            this.total,
            this.Profit,
            this.sdate,
            this.user,
            this.cancel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SoldItemsDG.DefaultCellStyle = dataGridViewCellStyle7;
            this.SoldItemsDG.EnableHeadersVisualStyles = false;
            this.SoldItemsDG.Location = new System.Drawing.Point(10, 74);
            this.SoldItemsDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SoldItemsDG.Name = "SoldItemsDG";
            this.SoldItemsDG.ReadOnly = true;
            this.SoldItemsDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SoldItemsDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SoldItemsDG.RowHeadersVisible = false;
            this.SoldItemsDG.RowHeadersWidth = 40;
            this.SoldItemsDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SoldItemsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoldItemsDG.Size = new System.Drawing.Size(851, 394);
            this.SoldItemsDG.TabIndex = 4;
            this.SoldItemsDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SoldItemsDG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilterGB
            // 
            this.FilterGB.Controls.Add(this.cbUserID);
            this.FilterGB.Controls.Add(this.datePTo);
            this.FilterGB.Controls.Add(this.label3);
            this.FilterGB.Controls.Add(this.label2);
            this.FilterGB.Controls.Add(this.datePFrom);
            this.FilterGB.Controls.Add(this.label1);
            this.FilterGB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterGB.Location = new System.Drawing.Point(10, 10);
            this.FilterGB.Name = "FilterGB";
            this.FilterGB.Size = new System.Drawing.Size(576, 48);
            this.FilterGB.TabIndex = 6;
            this.FilterGB.TabStop = false;
            this.FilterGB.Text = "Filter";
            // 
            // cbUserID
            // 
            this.cbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserID.FormattingEnabled = true;
            this.cbUserID.Location = new System.Drawing.Point(325, 18);
            this.cbUserID.Name = "cbUserID";
            this.cbUserID.Size = new System.Drawing.Size(233, 25);
            this.cbUserID.TabIndex = 8;
            // 
            // datePTo
            // 
            this.datePTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePTo.Location = new System.Drawing.Point(186, 22);
            this.datePTo.Name = "datePTo";
            this.datePTo.Size = new System.Drawing.Size(90, 23);
            this.datePTo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "User:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePFrom
            // 
            this.datePFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePFrom.Location = new System.Drawing.Point(56, 23);
            this.datePFrom.Name = "datePFrom";
            this.datePFrom.Size = new System.Drawing.Size(92, 23);
            this.datePFrom.TabIndex = 7;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_delete_file_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.Image")));
            this.btnPrintPreview.Location = new System.Drawing.Point(712, 31);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(120, 25);
            this.btnPrintPreview.TabIndex = 12;
            this.btnPrintPreview.Text = "&Print Preview";
            this.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(617, 31);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 25);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "&Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // CatID
            // 
            this.CatID.HeaderText = "";
            this.CatID.Name = "CatID";
            this.CatID.ReadOnly = true;
            this.CatID.Visible = false;
            // 
            // invoice
            // 
            this.invoice.HeaderText = "Transaction No";
            this.invoice.Name = "invoice";
            this.invoice.ReadOnly = true;
            this.invoice.Width = 120;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.HeaderText = "Description";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // CostPrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CostPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.CostPrice.HeaderText = "Cost Price(avg)";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            // 
            // price
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qty.DefaultCellStyle = dataGridViewCellStyle4;
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 50;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.unit.DefaultCellStyle = dataGridViewCellStyle5;
            this.unit.HeaderText = "";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 17;
            // 
            // discount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.discount.DefaultCellStyle = dataGridViewCellStyle6;
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 80;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 62;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // sdate
            // 
            this.sdate.HeaderText = "Date";
            this.sdate.Name = "sdate";
            this.sdate.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "User";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 120;
            // 
            // cancel
            // 
            this.cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cancel.HeaderText = "";
            this.cancel.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_delete_file_16;
            this.cancel.Name = "cancel";
            this.cancel.ReadOnly = true;
            this.cancel.Width = 5;
            // 
            // DailySalesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.FilterGB);
            this.Controls.Add(this.SoldItemsDG);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailySalesUC";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(871, 478);
            this.Load += new System.EventHandler(this.DailySalesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoldItemsDG)).EndInit();
            this.FilterGB.ResumeLayout(false);
            this.FilterGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SoldItemsDG;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox FilterGB;
        private System.Windows.Forms.ComboBox cbUserID;
        private System.Windows.Forms.DateTimePicker datePTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePFrom;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewImageColumn cancel;
    }
}
