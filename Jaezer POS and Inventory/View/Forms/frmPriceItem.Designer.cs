namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmPriceItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPriceItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelEAN13 = new System.Windows.Forms.Label();
            this.btnGenerateBarcode = new MetroFramework.Controls.MetroButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnScanBarcode = new MetroFramework.Controls.MetroButton();
            this.btnPrintPreview = new MetroFramework.Controls.MetroButton();
            this.BarcodeImage = new System.Windows.Forms.PictureBox();
            this.txtUnit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSavePrice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.Label();
            this.txtVariant = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUnitCode = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtBarcode = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 30);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnClose.Location = new System.Drawing.Point(448, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.labelEAN13);
            this.panel2.Controls.Add(this.btnGenerateBarcode);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.btnScanBarcode);
            this.panel2.Controls.Add(this.btnPrintPreview);
            this.panel2.Controls.Add(this.BarcodeImage);
            this.panel2.Controls.Add(this.txtUnit);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSavePrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ProdName);
            this.panel2.Controls.Add(this.txtVariant);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbUnitCode);
            this.panel2.Controls.Add(this.txtBarcode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.barcode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 268);
            this.panel2.TabIndex = 28;
            // 
            // labelEAN13
            // 
            this.labelEAN13.Location = new System.Drawing.Point(320, 60);
            this.labelEAN13.Name = "labelEAN13";
            this.labelEAN13.Size = new System.Drawing.Size(132, 46);
            this.labelEAN13.TabIndex = 43;
            this.labelEAN13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateBarcode
            // 
            this.btnGenerateBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenerateBarcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateBarcode.BackgroundImage")));
            this.btnGenerateBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenerateBarcode.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnGenerateBarcode.Location = new System.Drawing.Point(267, 58);
            this.btnGenerateBarcode.Name = "btnGenerateBarcode";
            this.btnGenerateBarcode.Size = new System.Drawing.Size(20, 17);
            this.btnGenerateBarcode.TabIndex = 42;
            this.btnGenerateBarcode.Tag = "Generate Barcode";
            this.btnGenerateBarcode.UseSelectable = true;
            this.btnGenerateBarcode.Click += new System.EventHandler(this.btnGenerateBarcode_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(88, 112);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(197, 25);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // btnScanBarcode
            // 
            this.btnScanBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnScanBarcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScanBarcode.BackgroundImage")));
            this.btnScanBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnScanBarcode.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnScanBarcode.Location = new System.Drawing.Point(245, 58);
            this.btnScanBarcode.Name = "btnScanBarcode";
            this.btnScanBarcode.Size = new System.Drawing.Size(20, 18);
            this.btnScanBarcode.TabIndex = 41;
            this.btnScanBarcode.Tag = "Scan Barcode";
            this.btnScanBarcode.UseSelectable = true;
            this.btnScanBarcode.Click += new System.EventHandler(this.btnScanBarcode_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintPreview.Location = new System.Drawing.Point(306, 126);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(157, 23);
            this.btnPrintPreview.TabIndex = 41;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseSelectable = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // BarcodeImage
            // 
            this.BarcodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarcodeImage.Location = new System.Drawing.Point(306, 53);
            this.BarcodeImage.Name = "BarcodeImage";
            this.BarcodeImage.Size = new System.Drawing.Size(157, 67);
            this.BarcodeImage.TabIndex = 40;
            this.BarcodeImage.TabStop = false;
            this.BarcodeImage.Visible = false;
            // 
            // txtUnit
            // 
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUnit.Location = new System.Drawing.Point(88, 177);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(197, 26);
            this.txtUnit.TabIndex = 9;
            this.txtUnit.Text = "Unit";
            this.txtUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 48);
            this.label8.TabIndex = 39;
            this.label8.Text = "Base Unit of Measure";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSavePrice
            // 
            this.btnSavePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSavePrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSavePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSavePrice.Location = new System.Drawing.Point(196, 218);
            this.btnSavePrice.Name = "btnSavePrice";
            this.btnSavePrice.Size = new System.Drawing.Size(89, 25);
            this.btnSavePrice.TabIndex = 38;
            this.btnSavePrice.Text = "&Save Price";
            this.btnSavePrice.UseVisualStyleBackColor = false;
            this.btnSavePrice.Click += new System.EventHandler(this.btnSavePrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Price:";
            // 
            // ProdName
            // 
            this.ProdName.AutoSize = true;
            this.ProdName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(12, 19);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(170, 17);
            this.ProdName.TabIndex = 35;
            this.ProdName.Text = "Product Name Item Price\r\n";
            this.ProdName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVariant
            // 
            // 
            // 
            // 
            this.txtVariant.CustomButton.Image = null;
            this.txtVariant.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtVariant.CustomButton.Name = "";
            this.txtVariant.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVariant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVariant.CustomButton.TabIndex = 1;
            this.txtVariant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVariant.CustomButton.UseSelectable = true;
            this.txtVariant.CustomButton.Visible = false;
            this.txtVariant.Lines = new string[0];
            this.txtVariant.Location = new System.Drawing.Point(88, 83);
            this.txtVariant.MaxLength = 32767;
            this.txtVariant.Name = "txtVariant";
            this.txtVariant.PasswordChar = '\0';
            this.txtVariant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVariant.SelectedText = "";
            this.txtVariant.SelectionLength = 0;
            this.txtVariant.SelectionStart = 0;
            this.txtVariant.ShortcutsEnabled = true;
            this.txtVariant.Size = new System.Drawing.Size(197, 23);
            this.txtVariant.TabIndex = 6;
            this.txtVariant.UseSelectable = true;
            this.txtVariant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVariant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Variant Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Unit";
            // 
            // cbUnitCode
            // 
            this.cbUnitCode.DisplayMember = "unit";
            this.cbUnitCode.FormattingEnabled = true;
            this.cbUnitCode.ItemHeight = 23;
            this.cbUnitCode.Location = new System.Drawing.Point(88, 143);
            this.cbUnitCode.Name = "cbUnitCode";
            this.cbUnitCode.Size = new System.Drawing.Size(197, 29);
            this.cbUnitCode.TabIndex = 8;
            this.cbUnitCode.UseSelectable = true;
            this.cbUnitCode.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Barcode:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Location = new System.Drawing.Point(88, 53);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(197, 27);
            this.txtBarcode.TabIndex = 28;
            this.txtBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(88, 53);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(197, 25);
            this.barcode.TabIndex = 44;
            this.barcode.TextChanged += new System.EventHandler(this.barcode_TextChanged);
            // 
            // frmPriceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(485, 304);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPriceItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Shown += new System.EventHandler(this.frmPriceItem_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ProdName;
        private MetroFramework.Controls.MetroTextBox txtVariant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cbUnitCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSavePrice;
        private System.Windows.Forms.PictureBox BarcodeImage;
        private MetroFramework.Controls.MetroButton btnPrintPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtPrice;
        private MetroFramework.Controls.MetroButton btnGenerateBarcode;
        private MetroFramework.Controls.MetroButton btnScanBarcode;
        private System.Windows.Forms.Label labelEAN13;
        private System.Windows.Forms.Label txtBarcode;
        private System.Windows.Forms.TextBox barcode;
    }
}