namespace QuanLyKhachSan_AndroidTeam.All_User_Control
{
    partial class UC_Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Rooms));
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.colRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPricePerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.cmbIsAvailableRoom = new System.Windows.Forms.ComboBox();
            this.cmbPricePerNight = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomID,
            this.colRoomType,
            this.colPricePerNight,
            this.colIsAvailable});
            this.dgvRoom.Location = new System.Drawing.Point(27, 72);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersWidth = 57;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(886, 597);
            this.dgvRoom.TabIndex = 45;
            // 
            // colRoomID
            // 
            this.colRoomID.HeaderText = "Mã Phòng";
            this.colRoomID.MinimumWidth = 7;
            this.colRoomID.Name = "colRoomID";
            this.colRoomID.ReadOnly = true;
            // 
            // colRoomType
            // 
            this.colRoomType.HeaderText = "Loại Phòng";
            this.colRoomType.MinimumWidth = 7;
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            // 
            // colPricePerNight
            // 
            this.colPricePerNight.HeaderText = "Giá Mỗi Đêm";
            this.colPricePerNight.MinimumWidth = 7;
            this.colPricePerNight.Name = "colPricePerNight";
            this.colPricePerNight.ReadOnly = true;
            // 
            // colIsAvailable
            // 
            this.colIsAvailable.HeaderText = "Trạng Thái";
            this.colIsAvailable.MinimumWidth = 7;
            this.colIsAvailable.Name = "colIsAvailable";
            this.colIsAvailable.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.btnDeleteRoom);
            this.panel1.Controls.Add(this.btnUpdateRoom);
            this.panel1.Controls.Add(this.cmbIsAvailableRoom);
            this.panel1.Controls.Add(this.cmbPricePerNight);
            this.panel1.Controls.Add(this.cmbRoomType);
            this.panel1.Controls.Add(this.txtRoomID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(919, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 597);
            this.panel1.TabIndex = 44;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.Silver;
            this.btnAddRoom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.Location = new System.Drawing.Point(24, 466);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(158, 45);
            this.btnAddRoom.TabIndex = 45;
            this.btnAddRoom.Text = "   Thêm Phòng";
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BorderRadius = 18;
            this.btnDeleteRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteRoom.FillColor = System.Drawing.Color.Silver;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoom.Image")));
            this.btnDeleteRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteRoom.Location = new System.Drawing.Point(201, 466);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(158, 45);
            this.btnDeleteRoom.TabIndex = 46;
            this.btnDeleteRoom.Text = "   Xóa Phòng";
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BorderRadius = 18;
            this.btnUpdateRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRoom.FillColor = System.Drawing.Color.Silver;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRoom.Image")));
            this.btnUpdateRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateRoom.Location = new System.Drawing.Point(24, 533);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(158, 45);
            this.btnUpdateRoom.TabIndex = 47;
            this.btnUpdateRoom.Text = "   Sửa Phòng";
            // 
            // cmbIsAvailableRoom
            // 
            this.cmbIsAvailableRoom.FormattingEnabled = true;
            this.cmbIsAvailableRoom.Location = new System.Drawing.Point(24, 397);
            this.cmbIsAvailableRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIsAvailableRoom.Name = "cmbIsAvailableRoom";
            this.cmbIsAvailableRoom.Size = new System.Drawing.Size(315, 24);
            this.cmbIsAvailableRoom.TabIndex = 38;
            // 
            // cmbPricePerNight
            // 
            this.cmbPricePerNight.FormattingEnabled = true;
            this.cmbPricePerNight.Location = new System.Drawing.Point(24, 287);
            this.cmbPricePerNight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPricePerNight.Name = "cmbPricePerNight";
            this.cmbPricePerNight.Size = new System.Drawing.Size(315, 24);
            this.cmbPricePerNight.TabIndex = 38;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(25, 184);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(315, 24);
            this.cmbRoomType.TabIndex = 38;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(24, 83);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(315, 22);
            this.txtRoomID.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Loại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giá Mỗi Đêm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Trạng Thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Rooms";
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
            this.btnExit.Location = new System.Drawing.Point(201, 533);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 45);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "   Thoát";
            // 
            // UC_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Rooms";
            this.Size = new System.Drawing.Size(1321, 673);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePerNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsAvailable;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRoom;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRoom;
        private System.Windows.Forms.ComboBox cmbIsAvailableRoom;
        private System.Windows.Forms.ComboBox cmbPricePerNight;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
