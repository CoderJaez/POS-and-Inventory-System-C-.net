namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmDailySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailySales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.SoldItemsDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoldItemsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 30);
            this.panel1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(918, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jaezer Tech | Daily Sales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.SearchTxt);
            this.panel2.Controls.Add(this.btnPrintPreview);
            this.panel2.Controls.Add(this.SoldItemsDG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 503);
            this.panel2.TabIndex = 10;
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
            this.SearchTxt.Location = new System.Drawing.Point(15, 16);
            this.SearchTxt.MaxLength = 32767;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PromptText = "Search Transaction No / Product Description";
            this.SearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.SelectionLength = 0;
            this.SearchTxt.SelectionStart = 0;
            this.SearchTxt.ShortcutsEnabled = true;
            this.SearchTxt.Size = new System.Drawing.Size(656, 30);
            this.SearchTxt.TabIndex = 15;
            this.SearchTxt.UseSelectable = true;
            this.SearchTxt.WaterMark = "Search Transaction No / Product Description";
            this.SearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.Image")));
            this.btnPrintPreview.Location = new System.Drawing.Point(805, 16);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(134, 25);
            this.btnPrintPreview.TabIndex = 14;
            this.btnPrintPreview.Text = "&Print Preview";
            this.btnPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
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
            this.no,
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
            this.cancel});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SoldItemsDG.DefaultCellStyle = dataGridViewCellStyle9;
            this.SoldItemsDG.EnableHeadersVisualStyles = false;
            this.SoldItemsDG.Location = new System.Drawing.Point(15, 52);
            this.SoldItemsDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SoldItemsDG.Name = "SoldItemsDG";
            this.SoldItemsDG.ReadOnly = true;
            this.SoldItemsDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SoldItemsDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.SoldItemsDG.RowHeadersVisible = false;
            this.SoldItemsDG.RowHeadersWidth = 40;
            this.SoldItemsDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SoldItemsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoldItemsDG.Size = new System.Drawing.Size(924, 435);
            this.SoldItemsDG.TabIndex = 13;
            this.SoldItemsDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SoldItemsDG_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_delete_file_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // CatID
            // 
            this.CatID.HeaderText = "";
            this.CatID.Name = "CatID";
            this.CatID.ReadOnly = true;
            this.CatID.Visible = false;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.no.HeaderText = "";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 17;
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
            this.CostPrice.Width = 70;
            // 
            // price
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 70;
            // 
            // qty
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qty.DefaultCellStyle = dataGridViewCellStyle4;
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 60;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.discount.DefaultCellStyle = dataGridViewCellStyle6;
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 80;
            // 
            // total
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle7;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 80;
            // 
            // Profit
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Profit.DefaultCellStyle = dataGridViewCellStyle8;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 70;
            // 
            // sdate
            // 
            this.sdate.HeaderText = "Date";
            this.sdate.Name = "sdate";
            this.sdate.ReadOnly = true;
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
            // frmDailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(955, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDailySales";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoldItemsDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.DataGridView SoldItemsDG;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private MetroFramework.Controls.MetroTextBox SearchTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
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
        private System.Windows.Forms.DataGridViewImageColumn cancel;
    }
}