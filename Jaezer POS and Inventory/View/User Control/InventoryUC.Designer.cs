namespace Jaezer_POS_and_Inventory.View.User_Control
{
    partial class InventoryUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilterFL = new System.Windows.Forms.FlowLayoutPanel();
            this.cbFilter = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InvetoryListDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvetoryListDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 128);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(676, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 84);
            this.label4.TabIndex = 1;
            this.label4.Text = "Inventory Summary of items. \r\n- Purchases\r\n- Cost of Goods Sold\r\n- Balances\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilterFL);
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // FilterFL
            // 
            this.FilterFL.Location = new System.Drawing.Point(228, 23);
            this.FilterFL.Name = "FilterFL";
            this.FilterFL.Size = new System.Drawing.Size(408, 48);
            this.FilterFL.TabIndex = 42;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ItemHeight = 23;
            this.cbFilter.Location = new System.Drawing.Point(15, 42);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(207, 29);
            this.cbFilter.TabIndex = 41;
            this.cbFilter.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Filtered By:";
            // 
            // InvetoryListDG
            // 
            this.InvetoryListDG.AllowUserToAddRows = false;
            this.InvetoryListDG.AllowUserToResizeColumns = false;
            this.InvetoryListDG.AllowUserToResizeRows = false;
            this.InvetoryListDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.InvetoryListDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvetoryListDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InvetoryListDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvetoryListDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvetoryListDG.ColumnHeadersHeight = 45;
            this.InvetoryListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InvetoryListDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.n,
            this.Product,
            this.pUnits,
            this.CostPrice,
            this.pTotal,
            this.sQty,
            this.sTotal,
            this.oQty,
            this.oTotal,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvetoryListDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.InvetoryListDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvetoryListDG.EnableHeadersVisualStyles = false;
            this.InvetoryListDG.Location = new System.Drawing.Point(0, 128);
            this.InvetoryListDG.Name = "InvetoryListDG";
            this.InvetoryListDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvetoryListDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InvetoryListDG.RowHeadersVisible = false;
            this.InvetoryListDG.RowHeadersWidth = 40;
            this.InvetoryListDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InvetoryListDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.InvetoryListDG.Size = new System.Drawing.Size(918, 373);
            this.InvetoryListDG.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(310, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchases";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(575, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost of Goods Sold";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(758, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Balances";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // n
            // 
            this.n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.n.HeaderText = "";
            this.n.Name = "n";
            this.n.Width = 17;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product Description";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // pUnits
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pUnits.DefaultCellStyle = dataGridViewCellStyle2;
            this.pUnits.HeaderText = "Qty";
            this.pUnits.Name = "pUnits";
            this.pUnits.Width = 60;
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Price(Avg)";
            this.CostPrice.Name = "CostPrice";
            // 
            // pTotal
            // 
            this.pTotal.HeaderText = "Total";
            this.pTotal.Name = "pTotal";
            this.pTotal.Width = 80;
            // 
            // sQty
            // 
            this.sQty.HeaderText = "Qty";
            this.sQty.Name = "sQty";
            this.sQty.Width = 60;
            // 
            // sTotal
            // 
            this.sTotal.HeaderText = "Total";
            this.sTotal.Name = "sTotal";
            // 
            // oQty
            // 
            this.oQty.HeaderText = "Qty(Onhand)";
            this.oQty.Name = "oQty";
            this.oQty.Width = 60;
            // 
            // oTotal
            // 
            this.oTotal.HeaderText = "Total";
            this.oTotal.Name = "oTotal";
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_curved_arrow_16;
            this.delete.Name = "delete";
            this.delete.Width = 5;
            // 
            // InventoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvetoryListDG);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryUC";
            this.Size = new System.Drawing.Size(918, 501);
            this.Load += new System.EventHandler(this.InventoryUC_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvetoryListDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView InvetoryListDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel FilterFL;
        private MetroFramework.Controls.MetroComboBox cbFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn oQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTotal;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}
