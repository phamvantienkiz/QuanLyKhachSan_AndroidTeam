namespace QuanLyKhachSan_AndroidTeam.All_User_Control
{
    partial class UC_ServiceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ServiceDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegisterService = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteRegister = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRegister = new Guna.UI2.WinForms.Guna2Button();
            this.txtToTalService = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtQuantityService = new System.Windows.Forms.TextBox();
            this.txtServiceRegisterID = new System.Windows.Forms.TextBox();
            this.cmbServiceID = new System.Windows.Forms.ComboBox();
            this.cmbCustomerIDDetail = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServiceDetail = new System.Windows.Forms.DataGridView();
            this.colServiceDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRegisterService);
            this.panel1.Controls.Add(this.btnDeleteRegister);
            this.panel1.Controls.Add(this.btnUpdateRegister);
            this.panel1.Controls.Add(this.txtToTalService);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtQuantityService);
            this.panel1.Controls.Add(this.txtServiceRegisterID);
            this.panel1.Controls.Add(this.cmbServiceID);
            this.panel1.Controls.Add(this.cmbCustomerIDDetail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(921, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 597);
            this.panel1.TabIndex = 37;
            // 
            // btnRegisterService
            // 
            this.btnRegisterService.BorderRadius = 18;
            this.btnRegisterService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisterService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisterService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegisterService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegisterService.FillColor = System.Drawing.Color.Silver;
            this.btnRegisterService.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRegisterService.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterService.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterService.Image")));
            this.btnRegisterService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRegisterService.ImageSize = new System.Drawing.Size(23, 23);
            this.btnRegisterService.Location = new System.Drawing.Point(24, 474);
            this.btnRegisterService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterService.Name = "btnRegisterService";
            this.btnRegisterService.Size = new System.Drawing.Size(158, 45);
            this.btnRegisterService.TabIndex = 45;
            this.btnRegisterService.Text = "   Đăng Ký";
            // 
            // btnDeleteRegister
            // 
            this.btnDeleteRegister.BorderRadius = 18;
            this.btnDeleteRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteRegister.FillColor = System.Drawing.Color.Silver;
            this.btnDeleteRegister.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeleteRegister.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRegister.Image")));
            this.btnDeleteRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteRegister.Location = new System.Drawing.Point(198, 474);
            this.btnDeleteRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRegister.Name = "btnDeleteRegister";
            this.btnDeleteRegister.Size = new System.Drawing.Size(158, 45);
            this.btnDeleteRegister.TabIndex = 46;
            this.btnDeleteRegister.Text = "   Xóa Đăng Ký";
            // 
            // btnUpdateRegister
            // 
            this.btnUpdateRegister.BorderRadius = 18;
            this.btnUpdateRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRegister.FillColor = System.Drawing.Color.Silver;
            this.btnUpdateRegister.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateRegister.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRegister.Image")));
            this.btnUpdateRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateRegister.ImageSize = new System.Drawing.Size(23, 23);
            this.btnUpdateRegister.Location = new System.Drawing.Point(25, 537);
            this.btnUpdateRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateRegister.Name = "btnUpdateRegister";
            this.btnUpdateRegister.Size = new System.Drawing.Size(158, 45);
            this.btnUpdateRegister.TabIndex = 47;
            this.btnUpdateRegister.Text = "   Sửa Đăng Ký";
            // 
            // txtToTalService
            // 
            this.txtToTalService.Location = new System.Drawing.Point(27, 415);
            this.txtToTalService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToTalService.Name = "txtToTalService";
            this.txtToTalService.Size = new System.Drawing.Size(315, 22);
            this.txtToTalService.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 340);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 22);
            this.textBox1.TabIndex = 27;
            // 
            // txtQuantityService
            // 
            this.txtQuantityService.Location = new System.Drawing.Point(25, 276);
            this.txtQuantityService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantityService.Name = "txtQuantityService";
            this.txtQuantityService.Size = new System.Drawing.Size(315, 22);
            this.txtQuantityService.TabIndex = 27;
            // 
            // txtServiceRegisterID
            // 
            this.txtServiceRegisterID.Location = new System.Drawing.Point(25, 57);
            this.txtServiceRegisterID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServiceRegisterID.Name = "txtServiceRegisterID";
            this.txtServiceRegisterID.Size = new System.Drawing.Size(315, 22);
            this.txtServiceRegisterID.TabIndex = 27;
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(25, 212);
            this.cmbServiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(315, 24);
            this.cmbServiceID.TabIndex = 26;
            // 
            // cmbCustomerIDDetail
            // 
            this.cmbCustomerIDDetail.FormattingEnabled = true;
            this.cmbCustomerIDDetail.Location = new System.Drawing.Point(27, 136);
            this.cmbCustomerIDDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCustomerIDDetail.Name = "cmbCustomerIDDetail";
            this.cmbCustomerIDDetail.Size = new System.Drawing.Size(315, 24);
            this.cmbCustomerIDDetail.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã Phiếu ĐKDV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 376);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày Đăng Ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Đăng Ký Dịch Vụ";
            // 
            // dgvServiceDetail
            // 
            this.dgvServiceDetail.AllowUserToAddRows = false;
            this.dgvServiceDetail.AllowUserToDeleteRows = false;
            this.dgvServiceDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvServiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceDetailID,
            this.colCustomerID,
            this.colServiceID,
            this.colQuantityService,
            this.colRegisterDate,
            this.colTotal});
            this.dgvServiceDetail.Location = new System.Drawing.Point(30, 70);
            this.dgvServiceDetail.Name = "dgvServiceDetail";
            this.dgvServiceDetail.ReadOnly = true;
            this.dgvServiceDetail.RowHeadersWidth = 57;
            this.dgvServiceDetail.RowTemplate.Height = 24;
            this.dgvServiceDetail.Size = new System.Drawing.Size(885, 597);
            this.dgvServiceDetail.TabIndex = 35;
            // 
            // colServiceDetailID
            // 
            this.colServiceDetailID.HeaderText = "Mã Phiếu ĐKDV";
            this.colServiceDetailID.MinimumWidth = 7;
            this.colServiceDetailID.Name = "colServiceDetailID";
            this.colServiceDetailID.ReadOnly = true;
            // 
            // colCustomerID
            // 
            this.colCustomerID.HeaderText = "Mã Khách Hàng";
            this.colCustomerID.MinimumWidth = 7;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.ReadOnly = true;
            // 
            // colServiceID
            // 
            this.colServiceID.HeaderText = "Mã Dịch Vụ";
            this.colServiceID.MinimumWidth = 7;
            this.colServiceID.Name = "colServiceID";
            this.colServiceID.ReadOnly = true;
            // 
            // colQuantityService
            // 
            this.colQuantityService.HeaderText = "Số Lượng";
            this.colQuantityService.MinimumWidth = 7;
            this.colQuantityService.Name = "colQuantityService";
            this.colQuantityService.ReadOnly = true;
            // 
            // colRegisterDate
            // 
            this.colRegisterDate.HeaderText = "Ngày Đăng Ký";
            this.colRegisterDate.MinimumWidth = 7;
            this.colRegisterDate.Name = "colRegisterDate";
            this.colRegisterDate.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Giá";
            this.colTotal.MinimumWidth = 7;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
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
            this.btnExit.Location = new System.Drawing.Point(200, 537);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 45);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "   Thoát";
            // 
            // UC_ServiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvServiceDetail);
            this.Name = "UC_ServiceDetail";
            this.Size = new System.Drawing.Size(1321, 673);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnRegisterService;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRegister;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRegister;
        private System.Windows.Forms.TextBox txtToTalService;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtQuantityService;
        private System.Windows.Forms.TextBox txtServiceRegisterID;
        private System.Windows.Forms.ComboBox cmbServiceID;
        private System.Windows.Forms.ComboBox cmbCustomerIDDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
