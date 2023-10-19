namespace QuanLyKhachSan_AndroidTeam.All_User_Control
{
    partial class UC_PayBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PayBills));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.colBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReservationBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceDetailBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateBill = new Guna.UI2.WinForms.Guna2Button();
            this.txtDateBill = new System.Windows.Forms.TextBox();
            this.txtServiceDetailBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToTalBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReservationBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thanh Toán";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillID,
            this.colReservationBill,
            this.colServiceDetailBill,
            this.colBillDate,
            this.colTotalBill});
            this.dgvBill.GridColor = System.Drawing.Color.White;
            this.dgvBill.Location = new System.Drawing.Point(24, 69);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(882, 597);
            this.dgvBill.TabIndex = 8;
            // 
            // colBillID
            // 
            this.colBillID.HeaderText = "Mã Hóa Đơn";
            this.colBillID.MinimumWidth = 7;
            this.colBillID.Name = "colBillID";
            this.colBillID.ReadOnly = true;
            // 
            // colReservationBill
            // 
            this.colReservationBill.HeaderText = "Mã Đặt Phòng";
            this.colReservationBill.MinimumWidth = 7;
            this.colReservationBill.Name = "colReservationBill";
            this.colReservationBill.ReadOnly = true;
            // 
            // colServiceDetailBill
            // 
            this.colServiceDetailBill.HeaderText = "Mã ĐKDV";
            this.colServiceDetailBill.MinimumWidth = 7;
            this.colServiceDetailBill.Name = "colServiceDetailBill";
            this.colServiceDetailBill.ReadOnly = true;
            // 
            // colBillDate
            // 
            this.colBillDate.HeaderText = "Ngày Lập Hóa Đơn";
            this.colBillDate.MinimumWidth = 7;
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.ReadOnly = true;
            // 
            // colTotalBill
            // 
            this.colTotalBill.HeaderText = "Tổng Tiền";
            this.colTotalBill.MinimumWidth = 7;
            this.colTotalBill.Name = "colTotalBill";
            this.colTotalBill.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddBill);
            this.panel1.Controls.Add(this.btnDeleteBill);
            this.panel1.Controls.Add(this.btnUpdateBill);
            this.panel1.Controls.Add(this.txtDateBill);
            this.panel1.Controls.Add(this.txtServiceDetailBill);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtToTalBill);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbDiscount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtReservationBill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBillID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(912, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 597);
            this.panel1.TabIndex = 7;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BorderRadius = 18;
            this.btnAddBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBill.FillColor = System.Drawing.Color.Silver;
            this.btnAddBill.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddBill.ForeColor = System.Drawing.Color.Black;
            this.btnAddBill.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBill.Image")));
            this.btnAddBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddBill.Location = new System.Drawing.Point(19, 465);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(158, 45);
            this.btnAddBill.TabIndex = 51;
            this.btnAddBill.Text = "   Thanh Toán";
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BorderRadius = 18;
            this.btnDeleteBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBill.FillColor = System.Drawing.Color.Silver;
            this.btnDeleteBill.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeleteBill.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteBill.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBill.Image")));
            this.btnDeleteBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteBill.Location = new System.Drawing.Point(201, 465);
            this.btnDeleteBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(158, 45);
            this.btnDeleteBill.TabIndex = 52;
            this.btnDeleteBill.Text = "   Xóa Hóa Đơn";
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BorderRadius = 18;
            this.btnUpdateBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateBill.FillColor = System.Drawing.Color.Silver;
            this.btnUpdateBill.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateBill.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBill.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBill.Image")));
            this.btnUpdateBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateBill.Location = new System.Drawing.Point(19, 530);
            this.btnUpdateBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(158, 45);
            this.btnUpdateBill.TabIndex = 53;
            this.btnUpdateBill.Text = "   Sửa Hóa Đơn";
            // 
            // txtDateBill
            // 
            this.txtDateBill.Location = new System.Drawing.Point(32, 281);
            this.txtDateBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateBill.Name = "txtDateBill";
            this.txtDateBill.Size = new System.Drawing.Size(315, 22);
            this.txtDateBill.TabIndex = 49;
            // 
            // txtServiceDetailBill
            // 
            this.txtServiceDetailBill.Location = new System.Drawing.Point(29, 202);
            this.txtServiceDetailBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServiceDetailBill.Name = "txtServiceDetailBill";
            this.txtServiceDetailBill.Size = new System.Drawing.Size(315, 22);
            this.txtServiceDetailBill.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Mã Đăng Ký Dịch Vụ";
            // 
            // txtToTalBill
            // 
            this.txtToTalBill.Location = new System.Drawing.Point(29, 427);
            this.txtToTalBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToTalBill.Name = "txtToTalBill";
            this.txtToTalBill.Size = new System.Drawing.Size(315, 22);
            this.txtToTalBill.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Thành Tiền";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Location = new System.Drawing.Point(29, 353);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(315, 24);
            this.cmbDiscount.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Khuyến Mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày Lập";
            // 
            // txtReservationBill
            // 
            this.txtReservationBill.Location = new System.Drawing.Point(29, 121);
            this.txtReservationBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReservationBill.Name = "txtReservationBill";
            this.txtReservationBill.Size = new System.Drawing.Size(315, 22);
            this.txtReservationBill.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã Đặt Phòng";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(29, 48);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(315, 22);
            this.txtBillID.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mã Hóa Đơn";
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
            this.btnExit.Location = new System.Drawing.Point(201, 530);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 45);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "   Thoát";
            // 
            // UC_PayBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.panel1);
            this.Name = "UC_PayBills";
            this.Size = new System.Drawing.Size(1321, 673);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReservationBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceDetailBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBill;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddBill;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBill;
        private Guna.UI2.WinForms.Guna2Button btnUpdateBill;
        private System.Windows.Forms.TextBox txtDateBill;
        private System.Windows.Forms.TextBox txtServiceDetailBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToTalBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReservationBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
