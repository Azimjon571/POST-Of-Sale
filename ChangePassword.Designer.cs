namespace POST_Of_Sale
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseBr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtCurPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConPass = new MetroFramework.Controls.MetroTextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnCloseBr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 44);
            this.panel1.TabIndex = 5;
            // 
            // btnCloseBr
            // 
            this.btnCloseBr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBr.FlatAppearance.BorderSize = 0;
            this.btnCloseBr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseBr.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseBr.Image")));
            this.btnCloseBr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseBr.Location = new System.Drawing.Point(363, 3);
            this.btnCloseBr.Name = "btnCloseBr";
            this.btnCloseBr.Size = new System.Drawing.Size(34, 35);
            this.btnCloseBr.TabIndex = 2;
            this.btnCloseBr.UseVisualStyleBackColor = true;
            this.btnCloseBr.Click += new System.EventHandler(this.btnCloseBr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Your Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(83, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 19);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Username";
            // 
            // txtCurPassword
            // 
            // 
            // 
            // 
            this.txtCurPassword.CustomButton.Image = null;
            this.txtCurPassword.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.txtCurPassword.CustomButton.Name = "";
            this.txtCurPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCurPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurPassword.CustomButton.TabIndex = 1;
            this.txtCurPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurPassword.CustomButton.UseSelectable = true;
            this.txtCurPassword.CustomButton.Visible = false;
            this.txtCurPassword.DisplayIcon = true;
            this.txtCurPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCurPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtCurPassword.Icon")));
            this.txtCurPassword.Lines = new string[0];
            this.txtCurPassword.Location = new System.Drawing.Point(27, 129);
            this.txtCurPassword.MaxLength = 32767;
            this.txtCurPassword.Multiline = true;
            this.txtCurPassword.Name = "txtCurPassword";
            this.txtCurPassword.PasswordChar = '●';
            this.txtCurPassword.PromptText = "Current Password";
            this.txtCurPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurPassword.SelectedText = "";
            this.txtCurPassword.SelectionLength = 0;
            this.txtCurPassword.SelectionStart = 0;
            this.txtCurPassword.ShortcutsEnabled = true;
            this.txtCurPassword.Size = new System.Drawing.Size(349, 28);
            this.txtCurPassword.TabIndex = 14;
            this.txtCurPassword.UseSelectable = true;
            this.txtCurPassword.WaterMark = "Current Password";
            this.txtCurPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(277, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConPass
            // 
            // 
            // 
            // 
            this.txtConPass.CustomButton.Image = null;
            this.txtConPass.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.txtConPass.CustomButton.Name = "";
            this.txtConPass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConPass.CustomButton.TabIndex = 1;
            this.txtConPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConPass.CustomButton.UseSelectable = true;
            this.txtConPass.CustomButton.Visible = false;
            this.txtConPass.DisplayIcon = true;
            this.txtConPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtConPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtConPass.Icon")));
            this.txtConPass.Lines = new string[0];
            this.txtConPass.Location = new System.Drawing.Point(27, 178);
            this.txtConPass.MaxLength = 32767;
            this.txtConPass.Multiline = true;
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '●';
            this.txtConPass.PromptText = "Confirm Password";
            this.txtConPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConPass.SelectedText = "";
            this.txtConPass.SelectionLength = 0;
            this.txtConPass.SelectionStart = 0;
            this.txtConPass.ShortcutsEnabled = true;
            this.txtConPass.Size = new System.Drawing.Size(349, 28);
            this.txtConPass.TabIndex = 14;
            this.txtConPass.UseSelectable = true;
            this.txtConPass.Visible = false;
            this.txtConPass.WaterMark = "Confirm Password";
            this.txtConPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(277, 228);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 32);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.DisplayIcon = true;
            this.txtNewPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtNewPass.Icon")));
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(27, 129);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PromptText = "New Password";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(349, 28);
            this.txtNewPass.TabIndex = 14;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.Visible = false;
            this.txtNewPass.WaterMark = "New Password";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 272);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseBr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private MetroFramework.Controls.MetroTextBox txtCurPassword;
        public System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtConPass;
        public System.Windows.Forms.Button btnNext;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
    }
}