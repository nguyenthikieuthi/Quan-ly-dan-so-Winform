namespace QuanLyDanSo.GUI
{
    partial class FrmNgoaiNgu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNgoaiNgu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuNgoaiNgu = new System.Windows.Forms.Button();
            this.btnHuyNgoaiNgu = new System.Windows.Forms.Button();
            this.btnSuaNgoaiNgu = new System.Windows.Forms.Button();
            this.btbSuaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnThemNgoaiNgu = new System.Windows.Forms.Button();
            this.btnXoaNgoaiNgu = new System.Windows.Forms.Button();
            this.btnXoaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnaddPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnHuyPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnLuuPhieuDiChuyen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNgoaiNgu = new System.Windows.Forms.TextBox();
            this.txtTenNgoaiNgu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoatNgoaiNgu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "NGOẠI NGỮ";
            // 
            // dgvNgoaiNgu
            // 
            this.dgvNgoaiNgu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNgoaiNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgoaiNgu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNgoaiNgu.Location = new System.Drawing.Point(0, 322);
            this.dgvNgoaiNgu.Name = "dgvNgoaiNgu";
            this.dgvNgoaiNgu.RowTemplate.Height = 24;
            this.dgvNgoaiNgu.Size = new System.Drawing.Size(918, 285);
            this.dgvNgoaiNgu.TabIndex = 5;
            this.dgvNgoaiNgu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgoaiNgu_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuuNgoaiNgu);
            this.groupBox2.Controls.Add(this.btnHuyNgoaiNgu);
            this.groupBox2.Controls.Add(this.btnSuaNgoaiNgu);
            this.groupBox2.Controls.Add(this.btbSuaPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnThemNgoaiNgu);
            this.groupBox2.Controls.Add(this.btnXoaNgoaiNgu);
            this.groupBox2.Controls.Add(this.btnXoaPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnaddPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnHuyPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnLuuPhieuDiChuyen);
            this.groupBox2.Location = new System.Drawing.Point(92, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnLuuNgoaiNgu
            // 
            this.btnLuuNgoaiNgu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNgoaiNgu.Image = global::QuanLyDanSo.Properties.Resources.Save_32px;
            this.btnLuuNgoaiNgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuNgoaiNgu.Location = new System.Drawing.Point(540, 35);
            this.btnLuuNgoaiNgu.Name = "btnLuuNgoaiNgu";
            this.btnLuuNgoaiNgu.Size = new System.Drawing.Size(110, 45);
            this.btnLuuNgoaiNgu.TabIndex = 12;
            this.btnLuuNgoaiNgu.Text = "Lưu";
            this.btnLuuNgoaiNgu.UseVisualStyleBackColor = true;
            this.btnLuuNgoaiNgu.Click += new System.EventHandler(this.btnLuuNgoaiNgu_Click);
            // 
            // btnHuyNgoaiNgu
            // 
            this.btnHuyNgoaiNgu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyNgoaiNgu.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnHuyNgoaiNgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyNgoaiNgu.Location = new System.Drawing.Point(424, 35);
            this.btnHuyNgoaiNgu.Name = "btnHuyNgoaiNgu";
            this.btnHuyNgoaiNgu.Size = new System.Drawing.Size(110, 45);
            this.btnHuyNgoaiNgu.TabIndex = 10;
            this.btnHuyNgoaiNgu.Text = "Hủy";
            this.btnHuyNgoaiNgu.UseVisualStyleBackColor = true;
            this.btnHuyNgoaiNgu.Click += new System.EventHandler(this.btnHuyNgoaiNgu_Click);
            // 
            // btnSuaNgoaiNgu
            // 
            this.btnSuaNgoaiNgu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNgoaiNgu.Image = global::QuanLyDanSo.Properties.Resources.Edit_32px1;
            this.btnSuaNgoaiNgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNgoaiNgu.Location = new System.Drawing.Point(308, 35);
            this.btnSuaNgoaiNgu.Name = "btnSuaNgoaiNgu";
            this.btnSuaNgoaiNgu.Size = new System.Drawing.Size(110, 45);
            this.btnSuaNgoaiNgu.TabIndex = 8;
            this.btnSuaNgoaiNgu.Text = "Sửa";
            this.btnSuaNgoaiNgu.UseVisualStyleBackColor = true;
            this.btnSuaNgoaiNgu.Click += new System.EventHandler(this.btnSuaNgoaiNgu_Click);
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
            // btnThemNgoaiNgu
            // 
            this.btnThemNgoaiNgu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNgoaiNgu.Image = global::QuanLyDanSo.Properties.Resources.Plus_Math_32px1;
            this.btnThemNgoaiNgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNgoaiNgu.Location = new System.Drawing.Point(76, 35);
            this.btnThemNgoaiNgu.Name = "btnThemNgoaiNgu";
            this.btnThemNgoaiNgu.Size = new System.Drawing.Size(110, 45);
            this.btnThemNgoaiNgu.TabIndex = 6;
            this.btnThemNgoaiNgu.Text = "Thêm";
            this.btnThemNgoaiNgu.UseVisualStyleBackColor = true;
            this.btnThemNgoaiNgu.Click += new System.EventHandler(this.btnThemNgoaiNgu_Click);
            // 
            // btnXoaNgoaiNgu
            // 
            this.btnXoaNgoaiNgu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNgoaiNgu.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px1;
            this.btnXoaNgoaiNgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNgoaiNgu.Location = new System.Drawing.Point(192, 35);
            this.btnXoaNgoaiNgu.Name = "btnXoaNgoaiNgu";
            this.btnXoaNgoaiNgu.Size = new System.Drawing.Size(110, 45);
            this.btnXoaNgoaiNgu.TabIndex = 7;
            this.btnXoaNgoaiNgu.Text = "Xóa";
            this.btnXoaNgoaiNgu.UseVisualStyleBackColor = true;
            this.btnXoaNgoaiNgu.Click += new System.EventHandler(this.btnXoaNgoaiNgu_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaNgoaiNgu);
            this.groupBox1.Controls.Add(this.txtTenNgoaiNgu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngoại ngữ";
            // 
            // txtMaNgoaiNgu
            // 
            this.txtMaNgoaiNgu.Location = new System.Drawing.Point(235, 44);
            this.txtMaNgoaiNgu.Name = "txtMaNgoaiNgu";
            this.txtMaNgoaiNgu.Size = new System.Drawing.Size(349, 28);
            this.txtMaNgoaiNgu.TabIndex = 4;
            // 
            // txtTenNgoaiNgu
            // 
            this.txtTenNgoaiNgu.Location = new System.Drawing.Point(235, 104);
            this.txtTenNgoaiNgu.Name = "txtTenNgoaiNgu";
            this.txtTenNgoaiNgu.Size = new System.Drawing.Size(349, 28);
            this.txtTenNgoaiNgu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên ngoại ngữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã ngoại ngữ";
            // 
            // btnThoatNgoaiNgu
            // 
            this.btnThoatNgoaiNgu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatNgoaiNgu.Location = new System.Drawing.Point(811, 256);
            this.btnThoatNgoaiNgu.Name = "btnThoatNgoaiNgu";
            this.btnThoatNgoaiNgu.Size = new System.Drawing.Size(107, 57);
            this.btnThoatNgoaiNgu.TabIndex = 8;
            this.btnThoatNgoaiNgu.Text = "Thoát";
            this.btnThoatNgoaiNgu.UseVisualStyleBackColor = true;
            this.btnThoatNgoaiNgu.Click += new System.EventHandler(this.btnThoatNgoaiNgu_Click);
            // 
            // FrmNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 607);
            this.Controls.Add(this.btnThoatNgoaiNgu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNgoaiNgu);
            this.Controls.Add(this.label1);
            this.Name = "FrmNgoaiNgu";
            this.Text = "NgoaiNgu";
            this.Load += new System.EventHandler(this.NgoaiNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNgoaiNgu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuuNgoaiNgu;
        private System.Windows.Forms.Button btnHuyNgoaiNgu;
        private System.Windows.Forms.Button btnSuaNgoaiNgu;
        private System.Windows.Forms.Button btbSuaPhieuDiChuyen;
        private System.Windows.Forms.Button btnThemNgoaiNgu;
        private System.Windows.Forms.Button btnXoaNgoaiNgu;
        private System.Windows.Forms.Button btnXoaPhieuDiChuyen;
        private System.Windows.Forms.Button btnaddPhieuDiChuyen;
        private System.Windows.Forms.Button btnHuyPhieuDiChuyen;
        private System.Windows.Forms.Button btnLuuPhieuDiChuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenNgoaiNgu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoatNgoaiNgu;
        private System.Windows.Forms.TextBox txtMaNgoaiNgu;
    }
}