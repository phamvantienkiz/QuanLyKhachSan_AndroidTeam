namespace QuanLyKhachSan_AndroidTeam.All_User_Control
{
    partial class UC_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Employees));
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPositionEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmailEmployee = new System.Windows.Forms.TextBox();
            this.txtPhoneEmployee = new System.Windows.Forms.TextBox();
            this.txtEmployeeFullName = new System.Windows.Forms.TextBox();
            this.txtEmployeesID = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeID,
            this.colEmployeeFullName,
            this.colPhoneEmployee,
            this.colEmailEmployee,
            this.colPositionEmployee});
            this.dgvEmployee.Location = new System.Drawing.Point(27, 66);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 57;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(885, 597);
            this.dgvEmployee.TabIndex = 34;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.HeaderText = "Mã Nhân Viên";
            this.colEmployeeID.MinimumWidth = 7;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.ReadOnly = true;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.HeaderText = "Họ Tên";
            this.colEmployeeFullName.MinimumWidth = 7;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.ReadOnly = true;
            // 
            // colPhoneEmployee
            // 
            this.colPhoneEmployee.HeaderText = "Số Điện Thoại";
            this.colPhoneEmployee.MinimumWidth = 7;
            this.colPhoneEmployee.Name = "colPhoneEmployee";
            this.colPhoneEmployee.ReadOnly = true;
            // 
            // colEmailEmployee
            // 
            this.colEmailEmployee.HeaderText = "Số Điện Thoại";
            this.colEmailEmployee.MinimumWidth = 7;
            this.colEmailEmployee.Name = "colEmailEmployee";
            this.colEmailEmployee.ReadOnly = true;
            // 
            // colPositionEmployee
            // 
            this.colPositionEmployee.HeaderText = "Chức Vụ";
            this.colPositionEmployee.MinimumWidth = 7;
            this.colPositionEmployee.Name = "colPositionEmployee";
            this.colPositionEmployee.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Controls.Add(this.btnDeleteEmployee);
            this.panel1.Controls.Add(this.btnUpdateEmployee);
            this.panel1.Controls.Add(this.txtEmailEmployee);
            this.panel1.Controls.Add(this.txtPhoneEmployee);
            this.panel1.Controls.Add(this.txtEmployeeFullName);
            this.panel1.Controls.Add(this.txtEmployeesID);
            this.panel1.Controls.Add(this.cmbPosition);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(918, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 597);
            this.panel1.TabIndex = 33;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BorderRadius = 18;
            this.btnAddEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEmployee.FillColor = System.Drawing.Color.Silver;
            this.btnAddEmployee.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddEmployee.Location = new System.Drawing.Point(25, 472);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(158, 45);
            this.btnAddEmployee.TabIndex = 45;
            this.btnAddEmployee.Text = "   Thêm NV";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BorderRadius = 18;
            this.btnDeleteEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteEmployee.FillColor = System.Drawing.Color.Silver;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(204, 472);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(158, 45);
            this.btnDeleteEmployee.TabIndex = 46;
            this.btnDeleteEmployee.Text = "   Xóa NV";
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BorderRadius = 18;
            this.btnUpdateEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateEmployee.FillColor = System.Drawing.Color.Silver;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmployee.Image")));
            this.btnUpdateEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(25, 537);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(158, 45);
            this.btnUpdateEmployee.TabIndex = 47;
            this.btnUpdateEmployee.Text = "   Sửa NV";
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Location = new System.Drawing.Point(34, 339);
            this.txtEmailEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.Size = new System.Drawing.Size(315, 22);
            this.txtEmailEmployee.TabIndex = 27;
            // 
            // txtPhoneEmployee
            // 
            this.txtPhoneEmployee.Location = new System.Drawing.Point(34, 246);
            this.txtPhoneEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneEmployee.Name = "txtPhoneEmployee";
            this.txtPhoneEmployee.Size = new System.Drawing.Size(315, 22);
            this.txtPhoneEmployee.TabIndex = 27;
            // 
            // txtEmployeeFullName
            // 
            this.txtEmployeeFullName.Location = new System.Drawing.Point(35, 154);
            this.txtEmployeeFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeFullName.Name = "txtEmployeeFullName";
            this.txtEmployeeFullName.Size = new System.Drawing.Size(315, 22);
            this.txtEmployeeFullName.TabIndex = 27;
            // 
            // txtEmployeesID
            // 
            this.txtEmployeesID.Location = new System.Drawing.Point(35, 63);
            this.txtEmployeesID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeesID.Name = "txtEmployeesID";
            this.txtEmployeesID.Size = new System.Drawing.Size(315, 22);
            this.txtEmployeesID.TabIndex = 27;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(35, 421);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(315, 24);
            this.cmbPosition.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Chức Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Quản Lý Nhân Viên";
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
            this.btnExit.Location = new System.Drawing.Point(204, 537);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 45);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "   Thoát";
            // 
            // UC_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Employees";
            this.Size = new System.Drawing.Size(1321, 673);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionEmployee;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddEmployee;
        private Guna.UI2.WinForms.Guna2Button btnDeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox txtEmailEmployee;
        private System.Windows.Forms.TextBox txtPhoneEmployee;
        private System.Windows.Forms.TextBox txtEmployeeFullName;
        private System.Windows.Forms.TextBox txtEmployeesID;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
