namespace Jaezer_POS_and_Inventory.View.User_Control
{
    partial class UserUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUC));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPass = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.UserDG = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(824, 469);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnSave);
            this.metroTabPage2.Controls.Add(this.txtConfirmNewPass);
            this.metroTabPage2.Controls.Add(this.txtNewPass);
            this.metroTabPage2.Controls.Add(this.txtOldPass);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 3;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(816, 427);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Change Password";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(217, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmNewPass
            // 
            // 
            // 
            // 
            this.txtConfirmNewPass.CustomButton.Image = null;
            this.txtConfirmNewPass.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtConfirmNewPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmNewPass.CustomButton.Name = "";
            this.txtConfirmNewPass.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtConfirmNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmNewPass.CustomButton.TabIndex = 1;
            this.txtConfirmNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmNewPass.CustomButton.UseSelectable = true;
            this.txtConfirmNewPass.CustomButton.Visible = false;
            this.txtConfirmNewPass.Lines = new string[0];
            this.txtConfirmNewPass.Location = new System.Drawing.Point(39, 143);
            this.txtConfirmNewPass.MaxLength = 32767;
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '●';
            this.txtConfirmNewPass.PromptText = "Confirm New Password";
            this.txtConfirmNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmNewPass.SelectedText = "";
            this.txtConfirmNewPass.SelectionLength = 0;
            this.txtConfirmNewPass.SelectionStart = 0;
            this.txtConfirmNewPass.ShortcutsEnabled = true;
            this.txtConfirmNewPass.Size = new System.Drawing.Size(244, 23);
            this.txtConfirmNewPass.TabIndex = 5;
            this.txtConfirmNewPass.UseSelectable = true;
            this.txtConfirmNewPass.UseSystemPasswordChar = true;
            this.txtConfirmNewPass.WaterMark = "Confirm New Password";
            this.txtConfirmNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtNewPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(39, 114);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PromptText = "New Password";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(244, 23);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.WaterMark = "New Password";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOldPass
            // 
            // 
            // 
            // 
            this.txtOldPass.CustomButton.Image = null;
            this.txtOldPass.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtOldPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldPass.CustomButton.Name = "";
            this.txtOldPass.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.txtOldPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPass.CustomButton.TabIndex = 1;
            this.txtOldPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPass.CustomButton.UseSelectable = true;
            this.txtOldPass.CustomButton.Visible = false;
            this.txtOldPass.Lines = new string[0];
            this.txtOldPass.Location = new System.Drawing.Point(39, 85);
            this.txtOldPass.MaxLength = 32767;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '●';
            this.txtOldPass.PromptText = "Old Password";
            this.txtOldPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.SelectionLength = 0;
            this.txtOldPass.SelectionStart = 0;
            this.txtOldPass.ShortcutsEnabled = true;
            this.txtOldPass.Size = new System.Drawing.Size(244, 23);
            this.txtOldPass.TabIndex = 3;
            this.txtOldPass.UseSelectable = true;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.WaterMark = "Old Password";
            this.txtOldPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Password";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.UserDG);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 3;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.metroTabPage1.Size = new System.Drawing.Size(816, 427);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "User Accounts";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 2;
            // 
            // UserDG
            // 
            this.UserDG.AllowUserToAddRows = false;
            this.UserDG.AllowUserToResizeColumns = false;
            this.UserDG.AllowUserToResizeRows = false;
            this.UserDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserDG.ColumnHeadersHeight = 30;
            this.UserDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Username,
            this.Fullname,
            this.Type,
            this.setStatus,
            this.status,
            this.delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDG.DefaultCellStyle = dataGridViewCellStyle5;
            this.UserDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDG.EnableHeadersVisualStyles = false;
            this.UserDG.Location = new System.Drawing.Point(5, 48);
            this.UserDG.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.UserDG.Name = "UserDG";
            this.UserDG.ReadOnly = true;
            this.UserDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserDG.RowHeadersVisible = false;
            this.UserDG.RowHeadersWidth = 40;
            this.UserDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDG.Size = new System.Drawing.Size(806, 374);
            this.UserDG.TabIndex = 4;
            this.UserDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDG_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.HeaderText = "";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.HeaderText = "Full Name";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "User Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // setStatus
            // 
            this.setStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.setStatus.HeaderText = "Status";
            this.setStatus.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_toggle_on_16;
            this.setStatus.Name = "setStatus";
            this.setStatus.ReadOnly = true;
            this.setStatus.Width = 50;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 43);
            this.panel1.TabIndex = 2;
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.CustomButton.Image = null;
            this.SearchTxt.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.SearchTxt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxt.CustomButton.Name = "";
            this.SearchTxt.CustomButton.Size = new System.Drawing.Size(16, 16);
            this.SearchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTxt.CustomButton.TabIndex = 1;
            this.SearchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTxt.CustomButton.UseSelectable = true;
            this.SearchTxt.CustomButton.Visible = false;
            this.SearchTxt.DisplayIcon = true;
            this.SearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("SearchTxt.Icon")));
            this.SearchTxt.Lines = new string[0];
            this.SearchTxt.Location = new System.Drawing.Point(16, 14);
            this.SearchTxt.MaxLength = 32767;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PromptText = "Search";
            this.SearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.SelectionLength = 0;
            this.SearchTxt.SelectionStart = 0;
            this.SearchTxt.ShortcutsEnabled = true;
            this.SearchTxt.Size = new System.Drawing.Size(231, 23);
            this.SearchTxt.TabIndex = 13;
            this.SearchTxt.UseSelectable = true;
            this.SearchTxt.WaterMark = "Search";
            this.SearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(726, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn1.HeaderText = "Status";
            this.dataGridViewImageColumn1.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_toggle_on_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Jaezer_POS_and_Inventory.Properties.Resources.icons8_remove_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // UserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserUC";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(830, 475);
            this.Load += new System.EventHandler(this.UserUC_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView UserDG;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtConfirmNewPass;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private MetroFramework.Controls.MetroTextBox txtOldPass;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox SearchTxt;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewImageColumn setStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}
