namespace POST_Of_Sale
{
    partial class DailySale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseBr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSold = new System.Windows.Forms.DataGridView();
            this.colListNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbCashier = new System.Windows.Forms.ComboBox();
            this.txtTransNoFilter = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSold)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.txtTransNoFilter);
            this.panel1.Controls.Add(this.btnCloseBr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 49);
            this.panel1.TabIndex = 4;
            // 
            // btnCloseBr
            // 
            this.btnCloseBr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBr.FlatAppearance.BorderSize = 0;
            this.btnCloseBr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseBr.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseBr.Image")));
            this.btnCloseBr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseBr.Location = new System.Drawing.Point(996, 3);
            this.btnCloseBr.Name = "btnCloseBr";
            this.btnCloseBr.Size = new System.Drawing.Size(37, 39);
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
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Sales";
            // 
            // dgvSold
            // 
            this.dgvSold.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSold.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSold.BackgroundColor = System.Drawing.Color.White;
            this.dgvSold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSold.ColumnHeadersHeight = 30;
            this.dgvSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colListNo,
            this.Column1,
            this.Column2,
            this.colListPCode,
            this.colDes,
            this.colListPrice,
            this.colReOrder,
            this.colDis,
            this.colTotal,
            this.Cancel});
            this.dgvSold.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSold.EnableHeadersVisualStyles = false;
            this.dgvSold.Location = new System.Drawing.Point(0, 49);
            this.dgvSold.Name = "dgvSold";
            this.dgvSold.RowHeadersVisible = false;
            this.dgvSold.Size = new System.Drawing.Size(1036, 448);
            this.dgvSold.TabIndex = 5;
            this.dgvSold.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSold_CellContentClick);
            // 
            // colListNo
            // 
            this.colListNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colListNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colListNo.HeaderText = "No";
            this.colListNo.Name = "colListNo";
            this.colListNo.Width = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Invoice#";
            this.Column2.Name = "Column2";
            this.Column2.Width = 103;
            // 
            // colListPCode
            // 
            this.colListPCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colListPCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.colListPCode.HeaderText = "Pcode";
            this.colListPCode.Name = "colListPCode";
            this.colListPCode.Width = 83;
            // 
            // colDes
            // 
            this.colDes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDes.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDes.HeaderText = "Description";
            this.colDes.Name = "colDes";
            // 
            // colListPrice
            // 
            this.colListPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colListPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.colListPrice.HeaderText = "Price";
            this.colListPrice.Name = "colListPrice";
            this.colListPrice.Width = 70;
            // 
            // colReOrder
            // 
            this.colReOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colReOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.colReOrder.HeaderText = "Qty";
            this.colReOrder.Name = "colReOrder";
            this.colReOrder.Width = 62;
            // 
            // colDis
            // 
            this.colDis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDis.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDis.HeaderText = "Discount";
            this.colDis.Name = "colDis";
            this.colDis.Width = 101;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 72;
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cancel.HeaderText = "";
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.Name = "Cancel";
            this.Cancel.Width = 5;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(209, 518);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(134, 27);
            this.dtFrom.TabIndex = 6;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(403, 518);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(134, 27);
            this.dtTo.TabIndex = 6;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFilter.Location = new System.Drawing.Point(44, 521);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(159, 21);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "FIlter By Date: From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(365, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(775, 521);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(249, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCashier
            // 
            this.cbCashier.FormattingEnabled = true;
            this.cbCashier.Location = new System.Drawing.Point(543, 517);
            this.cbCashier.Name = "cbCashier";
            this.cbCashier.Size = new System.Drawing.Size(127, 29);
            this.cbCashier.TabIndex = 8;
            this.cbCashier.Text = "Select Cashier";
            this.cbCashier.SelectedIndexChanged += new System.EventHandler(this.cbCashier_SelectedIndexChanged);
            // 
            // txtTransNoFilter
            // 
            // 
            // 
            // 
            this.txtTransNoFilter.CustomButton.Image = null;
            this.txtTransNoFilter.CustomButton.Location = new System.Drawing.Point(432, 2);
            this.txtTransNoFilter.CustomButton.Name = "";
            this.txtTransNoFilter.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTransNoFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTransNoFilter.CustomButton.TabIndex = 1;
            this.txtTransNoFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTransNoFilter.CustomButton.UseSelectable = true;
            this.txtTransNoFilter.CustomButton.Visible = false;
            this.txtTransNoFilter.DisplayIcon = true;
            this.txtTransNoFilter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTransNoFilter.Icon = ((System.Drawing.Image)(resources.GetObject("txtTransNoFilter.Icon")));
            this.txtTransNoFilter.Lines = new string[0];
            this.txtTransNoFilter.Location = new System.Drawing.Point(307, 12);
            this.txtTransNoFilter.MaxLength = 32767;
            this.txtTransNoFilter.Multiline = true;
            this.txtTransNoFilter.Name = "txtTransNoFilter";
            this.txtTransNoFilter.PasswordChar = '\0';
            this.txtTransNoFilter.PromptText = "Search here";
            this.txtTransNoFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTransNoFilter.SelectedText = "";
            this.txtTransNoFilter.SelectionLength = 0;
            this.txtTransNoFilter.SelectionStart = 0;
            this.txtTransNoFilter.ShortcutsEnabled = true;
            this.txtTransNoFilter.Size = new System.Drawing.Size(458, 28);
            this.txtTransNoFilter.TabIndex = 9;
            this.txtTransNoFilter.UseSelectable = true;
            this.txtTransNoFilter.WaterMark = "Search here";
            this.txtTransNoFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTransNoFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtTransNoFilter.TabIndexChanged += new System.EventHandler(this.txtSearch_TabIndexChanged);
            // 
            // DailySale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 564);
            this.ControlBox = false;
            this.Controls.Add(this.cbCashier);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dgvSold);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DailySale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailySale";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailySale_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseBr;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewImageColumn Cancel;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbCashier;
        public MetroFramework.Controls.MetroTextBox txtTransNoFilter;
    }
}