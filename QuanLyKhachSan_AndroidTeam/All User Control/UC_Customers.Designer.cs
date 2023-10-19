namespace QuanLyKhachSan_AndroidTeam.All_User_Control
{
    partial class UC_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddressCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.txtGmailCustomer = new System.Windows.Forms.TextBox();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCustomersID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerID,
            this.colCustomerName,
            this.colPhoneCustomer,
            this.colEmailCustomer,
            this.colAddressCustomer});
            this.dataGridView1.Location = new System.Drawing.Point(28, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 597);
            this.dataGridView1.TabIndex = 46;
            // 
            // colCustomerID
            // 
            this.colCustomerID.HeaderText = "Mã Khách Hàng";
            this.colCustomerID.MinimumWidth = 7;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "Họ Tên";
            this.colCustomerName.MinimumWidth = 7;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colPhoneCustomer
            // 
            this.colPhoneCustomer.HeaderText = "Số Điện Thoại";
            this.colPhoneCustomer.MinimumWidth = 7;
            this.colPhoneCustomer.Name = "colPhoneCustomer";
            this.colPhoneCustomer.ReadOnly = true;
            // 
            // colEmailCustomer
            // 
            this.colEmailCustomer.HeaderText = "Email";
            this.colEmailCustomer.MinimumWidth = 7;
            this.colEmailCustomer.Name = "colEmailCustomer";
            this.colEmailCustomer.ReadOnly = true;
            // 
            // colAddressCustomer
            // 
            this.colAddressCustomer.HeaderText = "Địa Chỉ";
            this.colAddressCustomer.MinimumWidth = 7;
            this.colAddressCustomer.Name = "colAddressCustomer";
            this.colAddressCustomer.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnThemCustomer);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.btnUpdateCustomer);
            this.panel1.Controls.Add(this.txtAddressCustomer);
            this.panel1.Controls.Add(this.txtGmailCustomer);
            this.panel1.Controls.Add(this.txtPhoneCustomer);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.txtCustomersID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(917, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 597);
            this.panel1.TabIndex = 45;
            // 
            // btnThemCustomer
            // 
            this.btnThemCustomer.BorderRadius = 18;
            this.btnThemCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemCustomer.FillColor = System.Drawing.Color.Silver;
            this.btnThemCustomer.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThemCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnThemCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCustomer.Image")));
            this.btnThemCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemCustomer.Location = new System.Drawing.Point(26, 465);
            this.btnThemCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCustomer.Name = "btnThemCustomer";
            this.btnThemCustomer.Size = new System.Drawing.Size(158, 45);
            this.btnThemCustomer.TabIndex = 43;
            this.btnThemCustomer.Text = "   Thêm KH";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BorderRadius = 18;
            this.btnDeleteCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCustomer.FillColor = System.Drawing.Color.Silver;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Image")));
            this.btnDeleteCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(197, 465);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(158, 45);
            this.btnDeleteCustomer.TabIndex = 43;
            this.btnDeleteCustomer.Text = "   Xóa KH";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BorderRadius = 18;
            this.btnUpdateCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateCustomer.FillColor = System.Drawing.Color.Silver;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.Image")));
            this.btnUpdateCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(26, 533);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(158, 45);
            this.btnUpdateCustomer.TabIndex = 43;
            this.btnUpdateCustomer.Text = "   Sửa KH";
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Location = new System.Drawing.Point(26, 411);
            this.txtAddressCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(315, 22);
            this.txtAddressCustomer.TabIndex = 42;
            // 
            // txtGmailCustomer
            // 
            this.txtGmailCustomer.Location = new System.Drawing.Point(27, 327);
            this.txtGmailCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGmailCustomer.Name = "txtGmailCustomer";
            this.txtGmailCustomer.Size = new System.Drawing.Size(315, 22);
            this.txtGmailCustomer.TabIndex = 41;
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Location = new System.Drawing.Point(26, 233);
            this.txtPhoneCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(315, 22);
            this.txtPhoneCustomer.TabIndex = 40;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(26, 143);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(315, 22);
            this.txtFullName.TabIndex = 39;
            // 
            // txtCustomersID
            // 
            this.txtCustomersID.Location = new System.Drawing.Point(26, 60);
            this.txtCustomersID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomersID.Name = "txtCustomersID";
            this.txtCustomersID.Size = new System.Drawing.Size(315, 22);
            this.txtCustomersID.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = " Khách Hàng";
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
            this.btnExit.Location = new System.Drawing.Point(197, 533);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 45);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "   Thoát";
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(1321, 673);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddressCustomer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnThemCustomer;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCustomer;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.TextBox txtGmailCustomer;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCustomersID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;

        //xoa khach hang
        public void removeCustomers()
        {
            //goi ham gif

        }
    }

    

}
