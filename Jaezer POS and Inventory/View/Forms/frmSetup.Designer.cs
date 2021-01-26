namespace Jaezer_POS_and_Inventory.View.Forms
{
    partial class frmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSetup = new MetroFramework.Controls.MetroTabControl();
            this.tpWelcome = new MetroFramework.Controls.MetroTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNextToDB = new System.Windows.Forms.Button();
            this.tpDB = new MetroFramework.Controls.MetroTabPage();
            this.btnNextToAcc = new System.Windows.Forms.Button();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbImportDB = new System.Windows.Forms.CheckBox();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.txtServerPass = new MetroFramework.Controls.MetroTextBox();
            this.txtServerUname = new MetroFramework.Controls.MetroTextBox();
            this.txtSever = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpBusinessSetup = new MetroFramework.Controls.MetroTabPage();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProv = new MetroFramework.Controls.MetroTextBox();
            this.txtCity = new MetroFramework.Controls.MetroTextBox();
            this.txtBrgy = new MetroFramework.Controls.MetroTextBox();
            this.txtStreetAdd = new MetroFramework.Controls.MetroTextBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.txtCompanyName = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinishSetup = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtDatabase = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbSetup.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpDB.SuspendLayout();
            this.tpBusinessSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(599, 30);
            this.panel1.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(568, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.tbSetup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 424);
            this.panel2.TabIndex = 2;
            // 
            // tbSetup
            // 
            this.tbSetup.Controls.Add(this.tpWelcome);
            this.tbSetup.Controls.Add(this.tpDB);
            this.tbSetup.Controls.Add(this.tpBusinessSetup);
            this.tbSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetup.Location = new System.Drawing.Point(0, 0);
            this.tbSetup.Name = "tbSetup";
            this.tbSetup.SelectedIndex = 1;
            this.tbSetup.Size = new System.Drawing.Size(599, 424);
            this.tbSetup.TabIndex = 0;
            this.tbSetup.UseSelectable = true;
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.label3);
            this.tpWelcome.Controls.Add(this.btnNextToDB);
            this.tpWelcome.HorizontalScrollbarBarColor = true;
            this.tpWelcome.HorizontalScrollbarHighlightOnWheel = false;
            this.tpWelcome.HorizontalScrollbarSize = 2;
            this.tpWelcome.Location = new System.Drawing.Point(4, 38);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Size = new System.Drawing.Size(591, 382);
            this.tpWelcome.TabIndex = 0;
            this.tpWelcome.Text = "Welcome";
            this.tpWelcome.VerticalScrollbarBarColor = true;
            this.tpWelcome.VerticalScrollbarHighlightOnWheel = false;
            this.tpWelcome.VerticalScrollbarSize = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome to Jaezer Tech: POS and Inventory";
            // 
            // btnNextToDB
            // 
            this.btnNextToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNextToDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnNextToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextToDB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextToDB.Location = new System.Drawing.Point(500, 342);
            this.btnNextToDB.Name = "btnNextToDB";
            this.btnNextToDB.Size = new System.Drawing.Size(73, 25);
            this.btnNextToDB.TabIndex = 18;
            this.btnNextToDB.Text = " Next";
            this.btnNextToDB.UseVisualStyleBackColor = false;
            this.btnNextToDB.Click += new System.EventHandler(this.btnNextToDB_Click);
            // 
            // tpDB
            // 
            this.tpDB.Controls.Add(this.txtDatabase);
            this.tpDB.Controls.Add(this.btnNextToAcc);
            this.tpDB.Controls.Add(this.btnTestConn);
            this.tpDB.Controls.Add(this.btnAdd);
            this.tpDB.Controls.Add(this.cbImportDB);
            this.tpDB.Controls.Add(this.txtPort);
            this.tpDB.Controls.Add(this.txtServerPass);
            this.tpDB.Controls.Add(this.txtServerUname);
            this.tpDB.Controls.Add(this.txtSever);
            this.tpDB.Controls.Add(this.label4);
            this.tpDB.HorizontalScrollbarBarColor = true;
            this.tpDB.HorizontalScrollbarHighlightOnWheel = false;
            this.tpDB.HorizontalScrollbarSize = 2;
            this.tpDB.Location = new System.Drawing.Point(4, 38);
            this.tpDB.Name = "tpDB";
            this.tpDB.Size = new System.Drawing.Size(591, 382);
            this.tpDB.TabIndex = 2;
            this.tpDB.Text = "Setup Database Connection";
            this.tpDB.VerticalScrollbarBarColor = true;
            this.tpDB.VerticalScrollbarHighlightOnWheel = false;
            this.tpDB.VerticalScrollbarSize = 2;
            // 
            // btnNextToAcc
            // 
            this.btnNextToAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextToAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNextToAcc.Enabled = false;
            this.btnNextToAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnNextToAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextToAcc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextToAcc.Location = new System.Drawing.Point(500, 341);
            this.btnNextToAcc.Name = "btnNextToAcc";
            this.btnNextToAcc.Size = new System.Drawing.Size(73, 25);
            this.btnNextToAcc.TabIndex = 17;
            this.btnNextToAcc.Text = "&Next";
            this.btnNextToAcc.UseVisualStyleBackColor = false;
            this.btnNextToAcc.Click += new System.EventHandler(this.btnNextToAcc_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTestConn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnTestConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTestConn.Location = new System.Drawing.Point(134, 251);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(172, 25);
            this.btnTestConn.TabIndex = 16;
            this.btnTestConn.Text = "&Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = false;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(312, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 25);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Save Config";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbImportDB
            // 
            this.cbImportDB.AutoSize = true;
            this.cbImportDB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbImportDB.Location = new System.Drawing.Point(134, 224);
            this.cbImportDB.Name = "cbImportDB";
            this.cbImportDB.Size = new System.Drawing.Size(253, 21);
            this.cbImportDB.TabIndex = 8;
            this.cbImportDB.Text = "Import Database in this Computer ";
            this.cbImportDB.UseVisualStyleBackColor = false;
            this.cbImportDB.Visible = false;
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtPort.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(134, 163);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PromptText = "Port";
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(290, 23);
            this.txtPort.TabIndex = 6;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMark = "Port";
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtServerPass
            // 
            // 
            // 
            // 
            this.txtServerPass.CustomButton.Image = null;
            this.txtServerPass.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtServerPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerPass.CustomButton.Name = "";
            this.txtServerPass.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtServerPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerPass.CustomButton.TabIndex = 1;
            this.txtServerPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerPass.CustomButton.UseSelectable = true;
            this.txtServerPass.CustomButton.Visible = false;
            this.txtServerPass.Lines = new string[0];
            this.txtServerPass.Location = new System.Drawing.Point(134, 132);
            this.txtServerPass.MaxLength = 32767;
            this.txtServerPass.Name = "txtServerPass";
            this.txtServerPass.PasswordChar = '\0';
            this.txtServerPass.PromptText = "Server Password";
            this.txtServerPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerPass.SelectedText = "";
            this.txtServerPass.SelectionLength = 0;
            this.txtServerPass.SelectionStart = 0;
            this.txtServerPass.ShortcutsEnabled = true;
            this.txtServerPass.Size = new System.Drawing.Size(290, 23);
            this.txtServerPass.TabIndex = 5;
            this.txtServerPass.UseSelectable = true;
            this.txtServerPass.WaterMark = "Server Password";
            this.txtServerPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtServerUname
            // 
            // 
            // 
            // 
            this.txtServerUname.CustomButton.Image = null;
            this.txtServerUname.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtServerUname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerUname.CustomButton.Name = "";
            this.txtServerUname.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtServerUname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerUname.CustomButton.TabIndex = 1;
            this.txtServerUname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerUname.CustomButton.UseSelectable = true;
            this.txtServerUname.CustomButton.Visible = false;
            this.txtServerUname.Lines = new string[0];
            this.txtServerUname.Location = new System.Drawing.Point(134, 103);
            this.txtServerUname.MaxLength = 32767;
            this.txtServerUname.Name = "txtServerUname";
            this.txtServerUname.PasswordChar = '\0';
            this.txtServerUname.PromptText = "Server Username";
            this.txtServerUname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerUname.SelectedText = "";
            this.txtServerUname.SelectionLength = 0;
            this.txtServerUname.SelectionStart = 0;
            this.txtServerUname.ShortcutsEnabled = true;
            this.txtServerUname.Size = new System.Drawing.Size(290, 23);
            this.txtServerUname.TabIndex = 4;
            this.txtServerUname.UseSelectable = true;
            this.txtServerUname.WaterMark = "Server Username";
            this.txtServerUname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerUname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSever
            // 
            // 
            // 
            // 
            this.txtSever.CustomButton.Image = null;
            this.txtSever.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtSever.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSever.CustomButton.Name = "";
            this.txtSever.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtSever.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSever.CustomButton.TabIndex = 1;
            this.txtSever.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSever.CustomButton.UseSelectable = true;
            this.txtSever.CustomButton.Visible = false;
            this.txtSever.Lines = new string[0];
            this.txtSever.Location = new System.Drawing.Point(134, 74);
            this.txtSever.MaxLength = 32767;
            this.txtSever.Name = "txtSever";
            this.txtSever.PasswordChar = '\0';
            this.txtSever.PromptText = "Server Address";
            this.txtSever.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSever.SelectedText = "";
            this.txtSever.SelectionLength = 0;
            this.txtSever.SelectionStart = 0;
            this.txtSever.ShortcutsEnabled = true;
            this.txtSever.Size = new System.Drawing.Size(290, 23);
            this.txtSever.TabIndex = 3;
            this.txtSever.UseSelectable = true;
            this.txtSever.WaterMark = "Server Address";
            this.txtSever.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSever.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Database Configuration Setup";
            // 
            // tpBusinessSetup
            // 
            this.tpBusinessSetup.Controls.Add(this.imgLogo);
            this.tpBusinessSetup.Controls.Add(this.btnSave);
            this.tpBusinessSetup.Controls.Add(this.txtProv);
            this.tpBusinessSetup.Controls.Add(this.txtCity);
            this.tpBusinessSetup.Controls.Add(this.txtBrgy);
            this.tpBusinessSetup.Controls.Add(this.txtStreetAdd);
            this.tpBusinessSetup.Controls.Add(this.txtContact);
            this.tpBusinessSetup.Controls.Add(this.txtCompanyName);
            this.tpBusinessSetup.Controls.Add(this.label7);
            this.tpBusinessSetup.Controls.Add(this.label8);
            this.tpBusinessSetup.Controls.Add(this.btnFinishSetup);
            this.tpBusinessSetup.HorizontalScrollbarBarColor = true;
            this.tpBusinessSetup.HorizontalScrollbarHighlightOnWheel = false;
            this.tpBusinessSetup.HorizontalScrollbarSize = 2;
            this.tpBusinessSetup.Location = new System.Drawing.Point(4, 38);
            this.tpBusinessSetup.Name = "tpBusinessSetup";
            this.tpBusinessSetup.Size = new System.Drawing.Size(591, 382);
            this.tpBusinessSetup.TabIndex = 3;
            this.tpBusinessSetup.Text = "Establishment Setup";
            this.tpBusinessSetup.VerticalScrollbarBarColor = true;
            this.tpBusinessSetup.VerticalScrollbarHighlightOnWheel = false;
            this.tpBusinessSetup.VerticalScrollbarSize = 2;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgLogo.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.add_shopping_cart_96px;
            this.imgLogo.Location = new System.Drawing.Point(316, 99);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(96, 96);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 34;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(40, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(236, 25);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProv
            // 
            // 
            // 
            // 
            this.txtProv.CustomButton.Image = null;
            this.txtProv.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtProv.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv.CustomButton.Name = "";
            this.txtProv.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtProv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProv.CustomButton.TabIndex = 1;
            this.txtProv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProv.CustomButton.UseSelectable = true;
            this.txtProv.CustomButton.Visible = false;
            this.txtProv.Lines = new string[0];
            this.txtProv.Location = new System.Drawing.Point(40, 272);
            this.txtProv.MaxLength = 32767;
            this.txtProv.Name = "txtProv";
            this.txtProv.PasswordChar = '\0';
            this.txtProv.PromptText = "Province";
            this.txtProv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProv.SelectedText = "";
            this.txtProv.SelectionLength = 0;
            this.txtProv.SelectionStart = 0;
            this.txtProv.ShortcutsEnabled = true;
            this.txtProv.Size = new System.Drawing.Size(236, 23);
            this.txtProv.TabIndex = 32;
            this.txtProv.UseSelectable = true;
            this.txtProv.WaterMark = "Province";
            this.txtProv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCity
            // 
            // 
            // 
            // 
            this.txtCity.CustomButton.Image = null;
            this.txtCity.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtCity.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.CustomButton.Name = "";
            this.txtCity.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCity.CustomButton.TabIndex = 1;
            this.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCity.CustomButton.UseSelectable = true;
            this.txtCity.CustomButton.Visible = false;
            this.txtCity.Lines = new string[0];
            this.txtCity.Location = new System.Drawing.Point(40, 243);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PromptText = "City / Municipality";
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.ShortcutsEnabled = true;
            this.txtCity.Size = new System.Drawing.Size(236, 23);
            this.txtCity.TabIndex = 31;
            this.txtCity.UseSelectable = true;
            this.txtCity.WaterMark = "City / Municipality";
            this.txtCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBrgy
            // 
            // 
            // 
            // 
            this.txtBrgy.CustomButton.Image = null;
            this.txtBrgy.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtBrgy.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrgy.CustomButton.Name = "";
            this.txtBrgy.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtBrgy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrgy.CustomButton.TabIndex = 1;
            this.txtBrgy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrgy.CustomButton.UseSelectable = true;
            this.txtBrgy.CustomButton.Visible = false;
            this.txtBrgy.Lines = new string[0];
            this.txtBrgy.Location = new System.Drawing.Point(40, 214);
            this.txtBrgy.MaxLength = 32767;
            this.txtBrgy.Name = "txtBrgy";
            this.txtBrgy.PasswordChar = '\0';
            this.txtBrgy.PromptText = "Barangay";
            this.txtBrgy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBrgy.SelectedText = "";
            this.txtBrgy.SelectionLength = 0;
            this.txtBrgy.SelectionStart = 0;
            this.txtBrgy.ShortcutsEnabled = true;
            this.txtBrgy.Size = new System.Drawing.Size(236, 23);
            this.txtBrgy.TabIndex = 30;
            this.txtBrgy.UseSelectable = true;
            this.txtBrgy.WaterMark = "Barangay";
            this.txtBrgy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBrgy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStreetAdd
            // 
            // 
            // 
            // 
            this.txtStreetAdd.CustomButton.Image = null;
            this.txtStreetAdd.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtStreetAdd.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreetAdd.CustomButton.Name = "";
            this.txtStreetAdd.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtStreetAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStreetAdd.CustomButton.TabIndex = 1;
            this.txtStreetAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStreetAdd.CustomButton.UseSelectable = true;
            this.txtStreetAdd.CustomButton.Visible = false;
            this.txtStreetAdd.Lines = new string[0];
            this.txtStreetAdd.Location = new System.Drawing.Point(40, 157);
            this.txtStreetAdd.MaxLength = 32767;
            this.txtStreetAdd.Multiline = true;
            this.txtStreetAdd.Name = "txtStreetAdd";
            this.txtStreetAdd.PasswordChar = '\0';
            this.txtStreetAdd.PromptText = "Street Address";
            this.txtStreetAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStreetAdd.SelectedText = "";
            this.txtStreetAdd.SelectionLength = 0;
            this.txtStreetAdd.SelectionStart = 0;
            this.txtStreetAdd.ShortcutsEnabled = true;
            this.txtStreetAdd.Size = new System.Drawing.Size(236, 51);
            this.txtStreetAdd.TabIndex = 29;
            this.txtStreetAdd.UseSelectable = true;
            this.txtStreetAdd.WaterMark = "Street Address";
            this.txtStreetAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStreetAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtContact.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(40, 128);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PromptText = "Contact Number";
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(236, 23);
            this.txtContact.TabIndex = 28;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMark = "Contact Number";
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCompanyName
            // 
            // 
            // 
            // 
            this.txtCompanyName.CustomButton.Image = null;
            this.txtCompanyName.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtCompanyName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyName.CustomButton.Name = "";
            this.txtCompanyName.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtCompanyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCompanyName.CustomButton.TabIndex = 1;
            this.txtCompanyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCompanyName.CustomButton.UseSelectable = true;
            this.txtCompanyName.CustomButton.Visible = false;
            this.txtCompanyName.Lines = new string[0];
            this.txtCompanyName.Location = new System.Drawing.Point(40, 99);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PromptText = "Establishment Name";
            this.txtCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(236, 23);
            this.txtCompanyName.TabIndex = 27;
            this.txtCompanyName.UseSelectable = true;
            this.txtCompanyName.WaterMark = "Establishment Name";
            this.txtCompanyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCompanyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(37, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 40);
            this.label7.TabIndex = 26;
            this.label7.Text = "If you have already set your Establihment Information, Please the button (Finish)" +
    " below.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Setup Your Establishment Information";
            // 
            // btnFinishSetup
            // 
            this.btnFinishSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnFinishSetup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnFinishSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishSetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinishSetup.Location = new System.Drawing.Point(503, 345);
            this.btnFinishSetup.Name = "btnFinishSetup";
            this.btnFinishSetup.Size = new System.Drawing.Size(73, 25);
            this.btnFinishSetup.TabIndex = 19;
            this.btnFinishSetup.Text = "&Finish";
            this.btnFinishSetup.UseVisualStyleBackColor = false;
            this.btnFinishSetup.Click += new System.EventHandler(this.btnFinishSetup_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 40);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtDatabase
            // 
            // 
            // 
            // 
            this.txtDatabase.CustomButton.Image = null;
            this.txtDatabase.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtDatabase.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabase.CustomButton.Name = "";
            this.txtDatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDatabase.CustomButton.TabIndex = 1;
            this.txtDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDatabase.CustomButton.UseSelectable = true;
            this.txtDatabase.CustomButton.Visible = false;
            this.txtDatabase.Lines = new string[0];
            this.txtDatabase.Location = new System.Drawing.Point(134, 192);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.PromptText = "Database Name";
            this.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.ShortcutsEnabled = true;
            this.txtDatabase.Size = new System.Drawing.Size(290, 23);
            this.txtDatabase.TabIndex = 7;
            this.txtDatabase.UseSelectable = true;
            this.txtDatabase.WaterMark = "Database Name";
            this.txtDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(605, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSetup";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetup";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbSetup.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            this.tpWelcome.PerformLayout();
            this.tpDB.ResumeLayout(false);
            this.tpDB.PerformLayout();
            this.tpBusinessSetup.ResumeLayout(false);
            this.tpBusinessSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl tbSetup;
        private MetroFramework.Controls.MetroTabPage tpWelcome;
        private MetroFramework.Controls.MetroTabPage tpDB;
        private MetroFramework.Controls.MetroTabPage tpBusinessSetup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbImportDB;
        private MetroFramework.Controls.MetroTextBox txtServerPass;
        private MetroFramework.Controls.MetroTextBox txtServerUname;
        private MetroFramework.Controls.MetroTextBox txtSever;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNextToAcc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNextToDB;
        private System.Windows.Forms.Button btnFinishSetup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtProv;
        private MetroFramework.Controls.MetroTextBox txtCity;
        private MetroFramework.Controls.MetroTextBox txtBrgy;
        private MetroFramework.Controls.MetroTextBox txtStreetAdd;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox txtCompanyName;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private System.Windows.Forms.Button btnTestConn;
        private MetroFramework.Controls.MetroTextBox txtDatabase;
    }
}