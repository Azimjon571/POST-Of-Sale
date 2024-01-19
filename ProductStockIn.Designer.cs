namespace POST_Of_Sale
{
    partial class ProductStockIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductStockIn));
            this.dgvProStockIn = new System.Windows.Forms.DataGridView();
            this.colListNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCloseLook = new System.Windows.Forms.Button();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProStockIn)).BeginInit();
            this.panelBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProStockIn
            // 
            this.dgvProStockIn.AllowUserToAddRows = false;
            this.dgvProStockIn.BackgroundColor = System.Drawing.Color.White;
            this.dgvProStockIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProStockIn.ColumnHeadersHeight = 30;
            this.dgvProStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colListNo,
            this.colListPCode,
            this.colDes,
            this.colListBrand,
            this.Select});
            this.dgvProStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProStockIn.EnableHeadersVisualStyles = false;
            this.dgvProStockIn.Location = new System.Drawing.Point(0, 0);
            this.dgvProStockIn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvProStockIn.Name = "dgvProStockIn";
            this.dgvProStockIn.RowHeadersVisible = false;
            this.dgvProStockIn.Size = new System.Drawing.Size(984, 561);
            this.dgvProStockIn.TabIndex = 5;
            this.dgvProStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProStockIn_CellContentClick);
            // 
            // colListNo
            // 
            this.colListNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colListNo.HeaderText = "No";
            this.colListNo.Name = "colListNo";
            this.colListNo.Width = 55;
            // 
            // colListPCode
            // 
            this.colListPCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colListPCode.HeaderText = "Pcode";
            this.colListPCode.Name = "colListPCode";
            this.colListPCode.Width = 83;
            // 
            // colDes
            // 
            this.colDes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDes.HeaderText = "Description";
            this.colDes.Name = "colDes";
            // 
            // colListBrand
            // 
            this.colListBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colListBrand.HeaderText = "Qty";
            this.colListBrand.Name = "colListBrand";
            this.colListBrand.Width = 62;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.Width = 5;
            // 
            // btnCloseLook
            // 
            this.btnCloseLook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseLook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseLook.FlatAppearance.BorderSize = 0;
            this.btnCloseLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseLook.ForeColor = System.Drawing.Color.White;
            this.btnCloseLook.Location = new System.Drawing.Point(866, 19);
            this.btnCloseLook.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCloseLook.Name = "btnCloseLook";
            this.btnCloseLook.Size = new System.Drawing.Size(104, 29);
            this.btnCloseLook.TabIndex = 3;
            this.btnCloseLook.Text = "Close";
            this.btnCloseLook.UseVisualStyleBackColor = false;
            this.btnCloseLook.Click += new System.EventHandler(this.btnCloseLook_Click);
            // 
            // panelBrand
            // 
            this.panelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panelBrand.Controls.Add(this.txtSearch);
            this.panelBrand.Controls.Add(this.btnCloseLook);
            this.panelBrand.Controls.Add(this.lblName);
            this.panelBrand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBrand.Location = new System.Drawing.Point(0, 492);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(984, 69);
            this.panelBrand.TabIndex = 6;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(434, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(326, 21);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(458, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(11, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(267, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product Stock In";
            // 
            // ProductStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panelBrand);
            this.Controls.Add(this.dgvProStockIn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ProductStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductStockIn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProStockIn)).EndInit();
            this.panelBrand.ResumeLayout(false);
            this.panelBrand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProStockIn;
        private System.Windows.Forms.Button btnCloseLook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListBrand;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.Panel panelBrand;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Label lblName;
    }
}