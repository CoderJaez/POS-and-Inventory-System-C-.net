namespace Jaezer_POS_and_Inventory.View
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPass = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(373, 30);
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
            this.btnClose.Location = new System.Drawing.Point(342, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtConfirmNewPass);
            this.panel2.Controls.Add(this.txtNewPass);
            this.panel2.Controls.Add(this.txtOldPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 229);
            this.panel2.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(213)))), ((int)(((byte)(254)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(247, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 25);
            this.btnSave.TabIndex = 11;
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
            this.txtConfirmNewPass.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtConfirmNewPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmNewPass.CustomButton.Name = "";
            this.txtConfirmNewPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmNewPass.CustomButton.TabIndex = 1;
            this.txtConfirmNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmNewPass.CustomButton.UseSelectable = true;
            this.txtConfirmNewPass.CustomButton.Visible = false;
            this.txtConfirmNewPass.Lines = new string[0];
            this.txtConfirmNewPass.Location = new System.Drawing.Point(69, 126);
            this.txtConfirmNewPass.MaxLength = 32767;
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '●';
            //this.txtConfirmNewPass.PromptText = "Confirm New Password";
            this.txtConfirmNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmNewPass.SelectedText = "";
            this.txtConfirmNewPass.SelectionLength = 0;
            this.txtConfirmNewPass.SelectionStart = 0;
            this.txtConfirmNewPass.ShortcutsEnabled = true;
            this.txtConfirmNewPass.Size = new System.Drawing.Size(244, 23);
            this.txtConfirmNewPass.TabIndex = 10;
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
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtNewPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(69, 97);
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
            this.txtNewPass.TabIndex = 9;
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
            this.txtOldPass.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtOldPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldPass.CustomButton.Name = "";
            this.txtOldPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPass.CustomButton.TabIndex = 1;
            this.txtOldPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPass.CustomButton.UseSelectable = true;
            this.txtOldPass.CustomButton.Visible = false;
            this.txtOldPass.Lines = new string[0];
            this.txtOldPass.Location = new System.Drawing.Point(69, 68);
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
            this.txtOldPass.TabIndex = 8;
            this.txtOldPass.UseSelectable = true;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.WaterMark = "Old Password";
            this.txtOldPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Change Password";
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(379, 265);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangePass";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtConfirmNewPass;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private MetroFramework.Controls.MetroTextBox txtOldPass;
        private System.Windows.Forms.Label label3;
    }
}