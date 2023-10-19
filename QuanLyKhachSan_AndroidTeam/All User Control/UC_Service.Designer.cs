namespace QuanLyKhachSan_AndroidTeam.All_User_Control
{
    partial class UC_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Service));
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.colServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteService = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateService = new Guna.UI2.WinForms.Guna2Button();
            this.cmbPriceService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServiceName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceID,
            this.colServiceName,
            this.colServicePrice});
            this.dgvService.Location = new System.Drawing.Point(30, 70);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersWidth = 57;
            this.dgvService.RowTemplate.Height = 24;
            this.dgvService.Size = new System.Drawing.Size(880, 597);
            this.dgvService.TabIndex = 46;
            // 
            // colServiceID
            // 
            this.colServiceID.HeaderText = "Mã Dịch Vụ";
            this.colServiceID.MinimumWidth = 7;
            this.colServiceID.Name = "colServiceID";
            this.colServiceID.ReadOnly = true;
            // 
            // colServiceName
            // 
            this.colServiceName.HeaderText = "Tên Dịch Vụ";
            this.colServiceName.MinimumWidth = 7;
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            // 
            // colServicePrice
            // 
            this.colServicePrice.HeaderText = "Giá Tiền";
            this.colServicePrice.MinimumWidth = 7;
            this.colServicePrice.Name = "colServicePrice";
            this.colServicePrice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Dịch Vụ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Controls.Add(this.btnDeleteService);
            this.panel1.Controls.Add(this.btnUpdateService);
            this.panel1.Controls.Add(this.cmbPriceService);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbServiceName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtServiceID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(916, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 597);
            this.panel1.TabIndex = 44;
            // 
            // btnAddService
            // 
            this.btnAddService.BorderRadius = 18;
            this.btnAddService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddService.FillColor = System.Drawing.Color.Silver;
            this.btnAddService.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddService.ForeColor = System.Drawing.Color.Black;
            this.btnAddService.Image = ((System.Drawing.Image)(resources.GetObject("btnAddService.Image")));
            this.btnAddService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddService.Location = new System.Drawing.Point(25, 462);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(158, 45);
            this.btnAddService.TabIndex = 49;
            this.btnAddService.Text = "   Thêm DV";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BorderRadius = 18;
            this.btnDeleteService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteService.FillColor = System.Drawing.Color.Silver;
            this.btnDeleteService.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeleteService.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteService.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteService.Image")));
            this.btnDeleteService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteService.Location = new System.Drawing.Point(199, 462);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(158, 45);
            this.btnDeleteService.TabIndex = 50;
            this.btnDeleteService.Text = "   Xóa DV";
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BorderRadius = 18;
            this.btnUpdateService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateService.FillColor = System.Drawing.Color.Silver;
            this.btnUpdateService.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateService.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateService.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateService.Image")));
            this.btnUpdateService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateService.Location = new System.Drawing.Point(25, 532);
            this.btnUpdateService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(158, 45);
            this.btnUpdateService.TabIndex = 51;
            this.btnUpdateService.Text = "   Sửa DV";
            // 
            // cmbPriceService
            // 
            this.cmbPriceService.FormattingEnabled = true;
            this.cmbPriceService.Location = new System.Drawing.Point(28, 379);
            this.cmbPriceService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPriceService.Name = "cmbPriceService";
            this.cmbPriceService.Size = new System.Drawing.Size(315, 24);
            this.cmbPriceService.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Giá Tiền";
            // 
            // cmbServiceName
            // 
            this.cmbServiceName.FormattingEnabled = true;
            this.cmbServiceName.Location = new System.Drawing.Point(27, 244);
            this.cmbServiceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbServiceName.Name = "cmbServiceName";
            this.cmbServiceName.Size = new System.Drawing.Size(315, 24);
            this.cmbServiceName.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(27, 103);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(315, 22);
            this.txtServiceID.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mã Dịch Vụ";
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 18;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.ImageSize = new System.Drawing.Size(23, 23);
            this.btnExit.Location = new System.Drawing.Point(199, 532);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 45);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "   Thoát";
            // 
            // UC_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Service";
            this.Size = new System.Drawing.Size(1321, 673);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Guna.UI2.WinForms.Guna2Button btnDeleteService;
        private Guna.UI2.WinForms.Guna2Button btnUpdateService;
        private System.Windows.Forms.ComboBox cmbPriceService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServiceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
