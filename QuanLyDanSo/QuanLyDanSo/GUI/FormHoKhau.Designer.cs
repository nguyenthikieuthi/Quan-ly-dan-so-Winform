namespace QuanLyDanSo.GUI
{
    partial class FormHoKhau
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
            this.dgvHoKhau = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPhuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoSoHoKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyHoKhau = new System.Windows.Forms.Button();
            this.btnSuaHoKhau = new System.Windows.Forms.Button();
            this.btnXoaHoKhau = new System.Windows.Forms.Button();
            this.btnThemHoKhau = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuHoKhau = new System.Windows.Forms.Button();
            this.btbSuaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnXoaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnaddPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnHuyPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnLuuPhieuDiChuyen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoKhau)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoKhau
            // 
            this.dgvHoKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoKhau.Location = new System.Drawing.Point(13, 346);
            this.dgvHoKhau.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoKhau.Name = "dgvHoKhau";
            this.dgvHoKhau.Size = new System.Drawing.Size(748, 359);
            this.dgvHoKhau.TabIndex = 0;
            this.dgvHoKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoKhau_CellClick);
            this.dgvHoKhau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoKhau_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPhuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSoSoHoKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(118, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hộ khẩu";
            // 
            // txtMaPhuong
            // 
            this.txtMaPhuong.Location = new System.Drawing.Point(132, 163);
            this.txtMaPhuong.Name = "txtMaPhuong";
            this.txtMaPhuong.Size = new System.Drawing.Size(177, 28);
            this.txtMaPhuong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã phường";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(177, 28);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtSoSoHoKhau
            // 
            this.txtSoSoHoKhau.Location = new System.Drawing.Point(132, 48);
            this.txtSoSoHoKhau.Name = "txtSoSoHoKhau";
            this.txtSoSoHoKhau.Size = new System.Drawing.Size(177, 28);
            this.txtSoSoHoKhau.TabIndex = 2;
            this.txtSoSoHoKhau.TextChanged += new System.EventHandler(this.txtSoSoHoKhau_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số sổ hộ khẩu";
            // 
            // btnHuyHoKhau
            // 
            this.btnHuyHoKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHoKhau.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnHuyHoKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyHoKhau.Location = new System.Drawing.Point(35, 190);
            this.btnHuyHoKhau.Name = "btnHuyHoKhau";
            this.btnHuyHoKhau.Size = new System.Drawing.Size(128, 45);
            this.btnHuyHoKhau.TabIndex = 10;
            this.btnHuyHoKhau.Text = "Hủy";
            this.btnHuyHoKhau.UseVisualStyleBackColor = true;
            this.btnHuyHoKhau.Click += new System.EventHandler(this.btnHuyHoKhau_Click);
            // 
            // btnSuaHoKhau
            // 
            this.btnSuaHoKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHoKhau.Image = global::QuanLyDanSo.Properties.Resources.Edit_32px1;
            this.btnSuaHoKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHoKhau.Location = new System.Drawing.Point(35, 104);
            this.btnSuaHoKhau.Name = "btnSuaHoKhau";
            this.btnSuaHoKhau.Size = new System.Drawing.Size(128, 37);
            this.btnSuaHoKhau.TabIndex = 8;
            this.btnSuaHoKhau.Text = "Sửa";
            this.btnSuaHoKhau.UseVisualStyleBackColor = true;
            this.btnSuaHoKhau.Click += new System.EventHandler(this.btnSuaHoKhau_Click);
            // 
            // btnXoaHoKhau
            // 
            this.btnXoaHoKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHoKhau.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px1;
            this.btnXoaHoKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHoKhau.Location = new System.Drawing.Point(35, 61);
            this.btnXoaHoKhau.Name = "btnXoaHoKhau";
            this.btnXoaHoKhau.Size = new System.Drawing.Size(128, 37);
            this.btnXoaHoKhau.TabIndex = 7;
            this.btnXoaHoKhau.Text = "Xóa";
            this.btnXoaHoKhau.UseVisualStyleBackColor = true;
            this.btnXoaHoKhau.Click += new System.EventHandler(this.btnXoaHoKhau_Click);
            // 
            // btnThemHoKhau
            // 
            this.btnThemHoKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoKhau.Image = global::QuanLyDanSo.Properties.Resources.Plus_Math_32px1;
            this.btnThemHoKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHoKhau.Location = new System.Drawing.Point(35, 18);
            this.btnThemHoKhau.Name = "btnThemHoKhau";
            this.btnThemHoKhau.Size = new System.Drawing.Size(128, 37);
            this.btnThemHoKhau.TabIndex = 6;
            this.btnThemHoKhau.Text = "Thêm";
            this.btnThemHoKhau.UseVisualStyleBackColor = true;
            this.btnThemHoKhau.Click += new System.EventHandler(this.btnThemHoKhau_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuuHoKhau);
            this.groupBox2.Controls.Add(this.btnHuyHoKhau);
            this.groupBox2.Controls.Add(this.btnSuaHoKhau);
            this.groupBox2.Controls.Add(this.btbSuaPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnXoaHoKhau);
            this.groupBox2.Controls.Add(this.btnXoaPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnThemHoKhau);
            this.groupBox2.Controls.Add(this.btnaddPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnHuyPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnLuuPhieuDiChuyen);
            this.groupBox2.Location = new System.Drawing.Point(466, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 242);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnLuuHoKhau
            // 
            this.btnLuuHoKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHoKhau.Image = global::QuanLyDanSo.Properties.Resources.Save_32px;
            this.btnLuuHoKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHoKhau.Location = new System.Drawing.Point(35, 147);
            this.btnLuuHoKhau.Name = "btnLuuHoKhau";
            this.btnLuuHoKhau.Size = new System.Drawing.Size(128, 37);
            this.btnLuuHoKhau.TabIndex = 11;
            this.btnLuuHoKhau.Text = "Lưu";
            this.btnLuuHoKhau.UseVisualStyleBackColor = true;
            this.btnLuuHoKhau.Click += new System.EventHandler(this.btnLuuHoKhau_Click);
            // 
            // btbSuaPhieuDiChuyen
            // 
            this.btbSuaPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSuaPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Edit_32px1;
            this.btbSuaPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbSuaPhieuDiChuyen.Location = new System.Drawing.Point(-189, 71);
            this.btbSuaPhieuDiChuyen.Name = "btbSuaPhieuDiChuyen";
            this.btbSuaPhieuDiChuyen.Size = new System.Drawing.Size(128, 37);
            this.btbSuaPhieuDiChuyen.TabIndex = 8;
            this.btbSuaPhieuDiChuyen.Text = "Sửa";
            this.btbSuaPhieuDiChuyen.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhieuDiChuyen
            // 
            this.btnXoaPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px1;
            this.btnXoaPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieuDiChuyen.Location = new System.Drawing.Point(-189, 17);
            this.btnXoaPhieuDiChuyen.Name = "btnXoaPhieuDiChuyen";
            this.btnXoaPhieuDiChuyen.Size = new System.Drawing.Size(128, 37);
            this.btnXoaPhieuDiChuyen.TabIndex = 7;
            this.btnXoaPhieuDiChuyen.Text = "Xóa";
            this.btnXoaPhieuDiChuyen.UseVisualStyleBackColor = true;
            // 
            // btnaddPhieuDiChuyen
            // 
            this.btnaddPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Plus_Math_32px1;
            this.btnaddPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddPhieuDiChuyen.Location = new System.Drawing.Point(-189, -33);
            this.btnaddPhieuDiChuyen.Name = "btnaddPhieuDiChuyen";
            this.btnaddPhieuDiChuyen.Size = new System.Drawing.Size(128, 37);
            this.btnaddPhieuDiChuyen.TabIndex = 6;
            this.btnaddPhieuDiChuyen.Text = "Thêm";
            this.btnaddPhieuDiChuyen.UseVisualStyleBackColor = true;
            // 
            // btnHuyPhieuDiChuyen
            // 
            this.btnHuyPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnHuyPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyPhieuDiChuyen.Location = new System.Drawing.Point(283, 464);
            this.btnHuyPhieuDiChuyen.Name = "btnHuyPhieuDiChuyen";
            this.btnHuyPhieuDiChuyen.Size = new System.Drawing.Size(106, 45);
            this.btnHuyPhieuDiChuyen.TabIndex = 10;
            this.btnHuyPhieuDiChuyen.Text = "Hủy";
            this.btnHuyPhieuDiChuyen.UseVisualStyleBackColor = true;
            // 
            // btnLuuPhieuDiChuyen
            // 
            this.btnLuuPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Save_32px1;
            this.btnLuuPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPhieuDiChuyen.Location = new System.Drawing.Point(157, 464);
            this.btnLuuPhieuDiChuyen.Name = "btnLuuPhieuDiChuyen";
            this.btnLuuPhieuDiChuyen.Size = new System.Drawing.Size(106, 45);
            this.btnLuuPhieuDiChuyen.TabIndex = 9;
            this.btnLuuPhieuDiChuyen.Text = "Lưu";
            this.btnLuuPhieuDiChuyen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "HỘ KHẨU";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(668, 268);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 57);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 736);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvHoKhau);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHoKhau";
            this.Text = "FormHoKhau";
            this.Load += new System.EventHandler(this.FormHoKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoKhau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPhuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoSoHoKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyHoKhau;
        private System.Windows.Forms.Button btnSuaHoKhau;
        private System.Windows.Forms.Button btnXoaHoKhau;
        private System.Windows.Forms.Button btnThemHoKhau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btbSuaPhieuDiChuyen;
        private System.Windows.Forms.Button btnXoaPhieuDiChuyen;
        private System.Windows.Forms.Button btnaddPhieuDiChuyen;
        private System.Windows.Forms.Button btnHuyPhieuDiChuyen;
        private System.Windows.Forms.Button btnLuuPhieuDiChuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuuHoKhau;
        private System.Windows.Forms.Button btnThoat;
    }
}