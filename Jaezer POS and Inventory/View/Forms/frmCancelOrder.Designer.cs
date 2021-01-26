namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmCancelOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRemarks = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 30);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(96, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cancel Order Details";
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
            this.btnClose.Location = new System.Drawing.Point(732, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Controls.Add(this.cbRemarks);
            this.MainPanel.Controls.Add(this.txtQty);
            this.MainPanel.Controls.Add(this.btnCancelOrder);
            this.MainPanel.Controls.Add(this.cbNo);
            this.MainPanel.Controls.Add(this.cbYes);
            this.MainPanel.Controls.Add(this.label11);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.lblUser);
            this.MainPanel.Controls.Add(this.lblTotal);
            this.MainPanel.Controls.Add(this.lblDiscount);
            this.MainPanel.Controls.Add(this.lblQty);
            this.MainPanel.Controls.Add(this.lblPrice);
            this.MainPanel.Controls.Add(this.lblProductName);
            this.MainPanel.Controls.Add(this.label21);
            this.MainPanel.Controls.Add(this.label16);
            this.MainPanel.Controls.Add(this.label19);
            this.MainPanel.Controls.Add(this.lblInvoice);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.label14);
            this.MainPanel.Controls.Add(this.label12);
            this.MainPanel.Controls.Add(this.lblBarcode);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(763, 301);
            this.MainPanel.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(516, 175);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(216, 23);
            this.txtQty.TabIndex = 18;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCancelOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelOrder.Location = new System.Drawing.Point(615, 261);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(117, 25);
            this.btnCancelOrder.TabIndex = 17;
            this.btnCancelOrder.Text = "&Cancel Order";
            this.btnCancelOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.Location = new System.Drawing.Point(227, 182);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(46, 21);
            this.cbNo.TabIndex = 2;
            this.cbNo.Text = "No";
            this.cbNo.UseVisualStyleBackColor = true;
            this.cbNo.Click += new System.EventHandler(this.cbNo_Click);
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Location = new System.Drawing.Point(174, 182);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(47, 21);
            this.cbYes.TabIndex = 2;
            this.cbYes.Text = "Yes";
            this.cbYes.UseVisualStyleBackColor = true;
            this.cbYes.Click += new System.EventHandler(this.cbYes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Add To Inventory?";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cancelled By";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descrption";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Location = new System.Drawing.Point(174, 151);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(216, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(516, 132);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(216, 24);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(628, 105);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(104, 24);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQty
            // 
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQty.Location = new System.Drawing.Point(516, 105);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(104, 24);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "0";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(516, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(216, 24);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductName
            // 
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductName.Location = new System.Drawing.Point(174, 79);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(216, 24);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Barcode";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(407, 205);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Remarks";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(407, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Qty|Discount";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(407, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Cancel Qty";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoice
            // 
            this.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice.Location = new System.Drawing.Point(516, 47);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(216, 24);
            this.lblInvoice.TabIndex = 1;
            this.lblInvoice.Text = "202010230415001";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(407, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Price";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(407, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Transaction";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBarcode
            // 
            this.lblBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBarcode.Location = new System.Drawing.Point(174, 51);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(216, 24);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "10001100";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Barcode";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(28, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cancel Item(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sold Item";
            // 
            // cbRemarks
            // 
            this.cbRemarks.FormattingEnabled = true;
            this.cbRemarks.ItemHeight = 23;
            this.cbRemarks.Location = new System.Drawing.Point(516, 205);
            this.cbRemarks.Name = "cbRemarks";
            this.cbRemarks.Size = new System.Drawing.Size(216, 29);
            this.cbRemarks.TabIndex = 19;
            this.cbRemarks.UseSelectable = true;
            // 
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(769, 339);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCancelOrder";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cbRemarks;
    }
}