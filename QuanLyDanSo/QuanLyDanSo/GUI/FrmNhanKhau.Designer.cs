namespace QuanLyDanSo.GUI
{
    partial class FrmNhanKhau
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
            this.dgvNhanKhau = new System.Windows.Forms.DataGridView();
            this.btnThoatNhanKhau = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenNhanKhau = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuyNhanKhau = new System.Windows.Forms.Button();
            this.btnLuuNhanKhau = new System.Windows.Forms.Button();
            this.btnSuaNhanKhau = new System.Windows.Forms.Button();
            this.btnXoaNhanKhau = new System.Windows.Forms.Button();
            this.btnThemNhanKhau = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSoHoKhau = new System.Windows.Forms.ComboBox();
            this.txtMaNhanKhau = new System.Windows.Forms.TextBox();
            this.cbMaNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cbMaTrinhDo = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanKhau
            // 
            this.dgvNhanKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanKhau.Location = new System.Drawing.Point(16, 444);
            this.dgvNhanKhau.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.Size = new System.Drawing.Size(776, 356);
            this.dgvNhanKhau.TabIndex = 8;
            this.dgvNhanKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanKhau_CellClick);
            // 
            // btnThoatNhanKhau
            // 
            this.btnThoatNhanKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatNhanKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatNhanKhau.Location = new System.Drawing.Point(37, 280);
            this.btnThoatNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatNhanKhau.Name = "btnThoatNhanKhau";
            this.btnThoatNhanKhau.Size = new System.Drawing.Size(139, 59);
            this.btnThoatNhanKhau.TabIndex = 3;
            this.btnThoatNhanKhau.Text = "Thoát";
            this.btnThoatNhanKhau.UseVisualStyleBackColor = true;
            this.btnThoatNhanKhau.Click += new System.EventHandler(this.btnThoatNhanKhau_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(192, 332);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(336, 28);
            this.txtGhiChu.TabIndex = 18;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(192, 185);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.MaxLength = 13;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(336, 28);
            this.txtCMND.TabIndex = 14;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(192, 143);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(336, 28);
            this.dtpNgaySinh.TabIndex = 13;
            this.dtpNgaySinh.Value = new System.DateTime(2000, 12, 24, 15, 41, 0, 0);
            // 
            // txtTenNhanKhau
            // 
            this.txtTenNhanKhau.Location = new System.Drawing.Point(192, 66);
            this.txtTenNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanKhau.Name = "txtTenNhanKhau";
            this.txtTenNhanKhau.Size = new System.Drawing.Size(336, 28);
            this.txtTenNhanKhau.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuyNhanKhau);
            this.groupBox2.Controls.Add(this.btnLuuNhanKhau);
            this.groupBox2.Controls.Add(this.btnThoatNhanKhau);
            this.groupBox2.Controls.Add(this.btnSuaNhanKhau);
            this.groupBox2.Controls.Add(this.btnXoaNhanKhau);
            this.groupBox2.Controls.Add(this.btnThemNhanKhau);
            this.groupBox2.Location = new System.Drawing.Point(592, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(200, 366);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnHuyNhanKhau
            // 
            this.btnHuyNhanKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyNhanKhau.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnHuyNhanKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyNhanKhau.Location = new System.Drawing.Point(37, 163);
            this.btnHuyNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyNhanKhau.Name = "btnHuyNhanKhau";
            this.btnHuyNhanKhau.Size = new System.Drawing.Size(139, 45);
            this.btnHuyNhanKhau.TabIndex = 5;
            this.btnHuyNhanKhau.Text = "Hủy";
            this.btnHuyNhanKhau.UseVisualStyleBackColor = true;
            this.btnHuyNhanKhau.Click += new System.EventHandler(this.btnHuyNhanKhau_Click);
            // 
            // btnLuuNhanKhau
            // 
            this.btnLuuNhanKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNhanKhau.Image = global::QuanLyDanSo.Properties.Resources.Save_32px;
            this.btnLuuNhanKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuNhanKhau.Location = new System.Drawing.Point(37, 217);
            this.btnLuuNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuNhanKhau.Name = "btnLuuNhanKhau";
            this.btnLuuNhanKhau.Size = new System.Drawing.Size(139, 44);
            this.btnLuuNhanKhau.TabIndex = 4;
            this.btnLuuNhanKhau.Text = "Lưu";
            this.btnLuuNhanKhau.UseVisualStyleBackColor = true;
            this.btnLuuNhanKhau.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuaNhanKhau
            // 
            this.btnSuaNhanKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhanKhau.Image = global::QuanLyDanSo.Properties.Resources.Edit_32px;
            this.btnSuaNhanKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNhanKhau.Location = new System.Drawing.Point(37, 114);
            this.btnSuaNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaNhanKhau.Name = "btnSuaNhanKhau";
            this.btnSuaNhanKhau.Size = new System.Drawing.Size(139, 45);
            this.btnSuaNhanKhau.TabIndex = 2;
            this.btnSuaNhanKhau.Text = "Sửa";
            this.btnSuaNhanKhau.UseVisualStyleBackColor = true;
            this.btnSuaNhanKhau.Click += new System.EventHandler(this.btnSuaNhanKhau_Click);
            // 
            // btnXoaNhanKhau
            // 
            this.btnXoaNhanKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanKhau.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnXoaNhanKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNhanKhau.Location = new System.Drawing.Point(37, 69);
            this.btnXoaNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNhanKhau.Name = "btnXoaNhanKhau";
            this.btnXoaNhanKhau.Size = new System.Drawing.Size(139, 41);
            this.btnXoaNhanKhau.TabIndex = 1;
            this.btnXoaNhanKhau.Text = "Xóa";
            this.btnXoaNhanKhau.UseVisualStyleBackColor = true;
            this.btnXoaNhanKhau.Click += new System.EventHandler(this.btnXoaNhanKhau_Click);
            // 
            // btnThemNhanKhau
            // 
            this.btnThemNhanKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanKhau.Image = global::QuanLyDanSo.Properties.Resources.Plus_Math_32px;
            this.btnThemNhanKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhanKhau.Location = new System.Drawing.Point(37, 25);
            this.btnThemNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNhanKhau.Name = "btnThemNhanKhau";
            this.btnThemNhanKhau.Size = new System.Drawing.Size(139, 40);
            this.btnThemNhanKhau.TabIndex = 0;
            this.btnThemNhanKhau.Text = "Thêm";
            this.btnThemNhanKhau.UseVisualStyleBackColor = true;
            this.btnThemNhanKhau.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ghi chú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã ngoại ngữ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã trình độ văn hóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nhân Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSoHoKhau);
            this.groupBox1.Controls.Add(this.txtMaNhanKhau);
            this.groupBox1.Controls.Add(this.cbMaNgoaiNgu);
            this.groupBox1.Controls.Add(this.cbMaTrinhDo);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtTenNhanKhau);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(552, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // cbSoHoKhau
            // 
            this.cbSoHoKhau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoHoKhau.FormattingEnabled = true;
            this.cbSoHoKhau.Location = new System.Drawing.Point(192, 296);
            this.cbSoHoKhau.Name = "cbSoHoKhau";
            this.cbSoHoKhau.Size = new System.Drawing.Size(336, 29);
            this.cbSoHoKhau.TabIndex = 24;
            // 
            // txtMaNhanKhau
            // 
            this.txtMaNhanKhau.Location = new System.Drawing.Point(192, 27);
            this.txtMaNhanKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanKhau.Name = "txtMaNhanKhau";
            this.txtMaNhanKhau.Size = new System.Drawing.Size(336, 28);
            this.txtMaNhanKhau.TabIndex = 23;
            // 
            // cbMaNgoaiNgu
            // 
            this.cbMaNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNgoaiNgu.FormattingEnabled = true;
            this.cbMaNgoaiNgu.Location = new System.Drawing.Point(192, 256);
            this.cbMaNgoaiNgu.Name = "cbMaNgoaiNgu";
            this.cbMaNgoaiNgu.Size = new System.Drawing.Size(336, 29);
            this.cbMaNgoaiNgu.TabIndex = 22;
            // 
            // cbMaTrinhDo
            // 
            this.cbMaTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTrinhDo.FormattingEnabled = true;
            this.cbMaTrinhDo.Location = new System.Drawing.Point(192, 218);
            this.cbMaTrinhDo.Name = "cbMaTrinhDo";
            this.cbMaTrinhDo.Size = new System.Drawing.Size(336, 29);
            this.cbMaTrinhDo.TabIndex = 21;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(192, 108);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(336, 29);
            this.cbGioiTinh.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số sổ hộ khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "NHÂN KHẨU";
            // 
            // FrmNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 837);
            this.Controls.Add(this.dgvNhanKhau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhanKhau";
            this.Text = "FrmNhanKhau";
            this.Load += new System.EventHandler(this.FrmNhanKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanKhau;
        private System.Windows.Forms.Button btnXoaNhanKhau;
        private System.Windows.Forms.Button btnThoatNhanKhau;
        private System.Windows.Forms.Button btnSuaNhanKhau;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTenNhanKhau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemNhanKhau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.ComboBox cbMaNgoaiNgu;
        private System.Windows.Forms.ComboBox cbMaTrinhDo;
        private System.Windows.Forms.TextBox txtMaNhanKhau;
        private System.Windows.Forms.Button btnHuyNhanKhau;
        private System.Windows.Forms.Button btnLuuNhanKhau;
        private System.Windows.Forms.ComboBox cbSoHoKhau;
    }
}