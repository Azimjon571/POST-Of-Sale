namespace POST_Of_Sale
{
    partial class CategoryModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelCa = new System.Windows.Forms.Button();
            this.btnUpdateCa = new System.Windows.Forms.Button();
            this.btnSaveCa = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblIDCa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 59);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(652, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Module";
            // 
            // btnCancelCa
            // 
            this.btnCancelCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelCa.FlatAppearance.BorderSize = 0;
            this.btnCancelCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCa.ForeColor = System.Drawing.Color.Black;
            this.btnCancelCa.Location = new System.Drawing.Point(581, 164);
            this.btnCancelCa.Name = "btnCancelCa";
            this.btnCancelCa.Size = new System.Drawing.Size(99, 37);
            this.btnCancelCa.TabIndex = 7;
            this.btnCancelCa.Text = "Cancel";
            this.btnCancelCa.UseVisualStyleBackColor = false;
            this.btnCancelCa.Click += new System.EventHandler(this.btnCancelCa_Click);
            // 
            // btnUpdateCa
            // 
            this.btnUpdateCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateCa.FlatAppearance.BorderSize = 0;
            this.btnUpdateCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCa.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCa.Location = new System.Drawing.Point(476, 164);
            this.btnUpdateCa.Name = "btnUpdateCa";
            this.btnUpdateCa.Size = new System.Drawing.Size(99, 37);
            this.btnUpdateCa.TabIndex = 8;
            this.btnUpdateCa.Text = "Update";
            this.btnUpdateCa.UseVisualStyleBackColor = false;
            this.btnUpdateCa.Click += new System.EventHandler(this.btnUpdateCa_Click);
            // 
            // btnSaveCa
            // 
            this.btnSaveCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSaveCa.FlatAppearance.BorderSize = 0;
            this.btnSaveCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCa.ForeColor = System.Drawing.Color.White;
            this.btnSaveCa.Location = new System.Drawing.Point(371, 164);
            this.btnSaveCa.Name = "btnSaveCa";
            this.btnSaveCa.Size = new System.Drawing.Size(99, 37);
            this.btnSaveCa.TabIndex = 9;
            this.btnSaveCa.Text = "Save";
            this.btnSaveCa.UseVisualStyleBackColor = false;
            this.btnSaveCa.Click += new System.EventHandler(this.btnSaveCa_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.Location = new System.Drawing.Point(193, 99);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(487, 31);
            this.txtCategory.TabIndex = 6;
            // 
            // lblIDCa
            // 
            this.lblIDCa.AutoSize = true;
            this.lblIDCa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIDCa.Location = new System.Drawing.Point(22, 176);
            this.lblIDCa.Name = "lblIDCa";
            this.lblIDCa.Size = new System.Drawing.Size(29, 22);
            this.lblIDCa.TabIndex = 4;
            this.lblIDCa.Text = "ID";
            this.lblIDCa.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category Name:";
            // 
            // CategoryModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(692, 222);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelCa);
            this.Controls.Add(this.btnUpdateCa);
            this.Controls.Add(this.btnSaveCa);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblIDCa);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CategoryModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryModule";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CategoryModule_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelCa;
        public System.Windows.Forms.Button btnUpdateCa;
        public System.Windows.Forms.Button btnSaveCa;
        public System.Windows.Forms.TextBox txtCategory;
        public System.Windows.Forms.Label lblIDCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}