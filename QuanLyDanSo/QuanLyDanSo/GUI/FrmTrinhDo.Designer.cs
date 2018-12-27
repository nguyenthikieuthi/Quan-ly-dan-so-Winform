namespace QuanLyDanSo.GUI
{
    partial class FrmTrinhDo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaTrinhDo = new System.Windows.Forms.TextBox();
            this.txtTenTrinhDo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuTrinhDo = new System.Windows.Forms.Button();
            this.btnHuyTrinhDo = new System.Windows.Forms.Button();
            this.btnSuaTrinhDoVanHoa = new System.Windows.Forms.Button();
            this.btbSuaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnThemTrinhDo = new System.Windows.Forms.Button();
            this.btnXoaTrinhDo = new System.Windows.Forms.Button();
            this.btnXoaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnaddPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnHuyPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnLuuPhieuDiChuyen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTrinhDo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaTrinhDo);
            this.groupBox1.Controls.Add(this.txtTenTrinhDo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(114, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trình độ ";
            // 
            // txtMaTrinhDo
            // 
            this.txtMaTrinhDo.Location = new System.Drawing.Point(197, 51);
            this.txtMaTrinhDo.Name = "txtMaTrinhDo";
            this.txtMaTrinhDo.Size = new System.Drawing.Size(349, 28);
            this.txtMaTrinhDo.TabIndex = 4;
            // 
            // txtTenTrinhDo
            // 
            this.txtTenTrinhDo.Location = new System.Drawing.Point(197, 104);
            this.txtTenTrinhDo.Name = "txtTenTrinhDo";
            this.txtTenTrinhDo.Size = new System.Drawing.Size(349, 28);
            this.txtTenTrinhDo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên trình độ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trình độ ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuuTrinhDo);
            this.groupBox2.Controls.Add(this.btnHuyTrinhDo);
            this.groupBox2.Controls.Add(this.btnSuaTrinhDoVanHoa);
            this.groupBox2.Controls.Add(this.btbSuaPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnThemTrinhDo);
            this.groupBox2.Controls.Add(this.btnXoaTrinhDo);
            this.groupBox2.Controls.Add(this.btnXoaPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnaddPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnHuyPhieuDiChuyen);
            this.groupBox2.Controls.Add(this.btnLuuPhieuDiChuyen);
            this.groupBox2.Location = new System.Drawing.Point(114, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnLuuTrinhDo
            // 
            this.btnLuuTrinhDo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTrinhDo.Image = global::QuanLyDanSo.Properties.Resources.Save_32px;
            this.btnLuuTrinhDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuTrinhDo.Location = new System.Drawing.Point(539, 35);
            this.btnLuuTrinhDo.Name = "btnLuuTrinhDo";
            this.btnLuuTrinhDo.Size = new System.Drawing.Size(110, 45);
            this.btnLuuTrinhDo.TabIndex = 12;
            this.btnLuuTrinhDo.Text = "Lưu";
            this.btnLuuTrinhDo.UseVisualStyleBackColor = true;
            this.btnLuuTrinhDo.Click += new System.EventHandler(this.btnLuuTrinhDo_Click);
            // 
            // btnHuyTrinhDo
            // 
            this.btnHuyTrinhDo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTrinhDo.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnHuyTrinhDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyTrinhDo.Location = new System.Drawing.Point(423, 35);
            this.btnHuyTrinhDo.Name = "btnHuyTrinhDo";
            this.btnHuyTrinhDo.Size = new System.Drawing.Size(110, 45);
            this.btnHuyTrinhDo.TabIndex = 10;
            this.btnHuyTrinhDo.Text = "Hủy";
            this.btnHuyTrinhDo.UseVisualStyleBackColor = true;
            this.btnHuyTrinhDo.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuaTrinhDoVanHoa
            // 
            this.btnSuaTrinhDoVanHoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTrinhDoVanHoa.Image = global::QuanLyDanSo.Properties.Resources.Edit_32px1;
            this.btnSuaTrinhDoVanHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTrinhDoVanHoa.Location = new System.Drawing.Point(307, 35);
            this.btnSuaTrinhDoVanHoa.Name = "btnSuaTrinhDoVanHoa";
            this.btnSuaTrinhDoVanHoa.Size = new System.Drawing.Size(110, 45);
            this.btnSuaTrinhDoVanHoa.TabIndex = 8;
            this.btnSuaTrinhDoVanHoa.Text = "Sửa";
            this.btnSuaTrinhDoVanHoa.UseVisualStyleBackColor = true;
            this.btnSuaTrinhDoVanHoa.Click += new System.EventHandler(this.btnSuaTrinhDoVanHoa_Click);
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
            // btnThemTrinhDo
            // 
            this.btnThemTrinhDo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTrinhDo.Image = global::QuanLyDanSo.Properties.Resources.Plus_Math_32px1;
            this.btnThemTrinhDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTrinhDo.Location = new System.Drawing.Point(71, 35);
            this.btnThemTrinhDo.Name = "btnThemTrinhDo";
            this.btnThemTrinhDo.Size = new System.Drawing.Size(110, 45);
            this.btnThemTrinhDo.TabIndex = 6;
            this.btnThemTrinhDo.Text = "Thêm";
            this.btnThemTrinhDo.UseVisualStyleBackColor = true;
            this.btnThemTrinhDo.Click += new System.EventHandler(this.btnThemTrinhDo_Click);
            // 
            // btnXoaTrinhDo
            // 
            this.btnXoaTrinhDo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTrinhDo.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px1;
            this.btnXoaTrinhDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTrinhDo.Location = new System.Drawing.Point(191, 35);
            this.btnXoaTrinhDo.Name = "btnXoaTrinhDo";
            this.btnXoaTrinhDo.Size = new System.Drawing.Size(110, 45);
            this.btnXoaTrinhDo.TabIndex = 7;
            this.btnXoaTrinhDo.Text = "Xóa";
            this.btnXoaTrinhDo.UseVisualStyleBackColor = true;
            this.btnXoaTrinhDo.Click += new System.EventHandler(this.btnXoaTrinhDo_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTrinhDo);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(114, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 271);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // dgvTrinhDo
            // 
            this.dgvTrinhDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrinhDo.Location = new System.Drawing.Point(6, 21);
            this.dgvTrinhDo.Name = "dgvTrinhDo";
            this.dgvTrinhDo.RowTemplate.Height = 24;
            this.dgvTrinhDo.Size = new System.Drawing.Size(702, 244);
            this.dgvTrinhDo.TabIndex = 0;
            this.dgvTrinhDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrinhDo_CellClick);
            this.dgvTrinhDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrinhDo_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "TRÌNH ĐỘ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(834, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTrinhDo";
            this.Text = "FrmTrinhDo";
            this.Load += new System.EventHandler(this.FrmTrinhDo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTrinhDo;
        private System.Windows.Forms.TextBox txtTenTrinhDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyTrinhDo;
        private System.Windows.Forms.Button btnSuaTrinhDoVanHoa;
        private System.Windows.Forms.Button btbSuaPhieuDiChuyen;
        private System.Windows.Forms.Button btnXoaTrinhDo;
        private System.Windows.Forms.Button btnXoaPhieuDiChuyen;
        private System.Windows.Forms.Button btnThemTrinhDo;
        private System.Windows.Forms.Button btnaddPhieuDiChuyen;
        private System.Windows.Forms.Button btnHuyPhieuDiChuyen;
        private System.Windows.Forms.Button btnLuuPhieuDiChuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuuTrinhDo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaTrinhDo;
    }
}