namespace QuanLyDanSo.GUI
{
    partial class FrmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPhieuDiChuyen = new System.Windows.Forms.TabPage();
            this.btnHuyPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnLuuPhieuDiChuyen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuDiChuyen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnXoaPhieuDiChuyen = new System.Windows.Forms.Button();
            this.btnaddPhieuDiChuyen = new System.Windows.Forms.Button();
            this.gbPhieuDiChuyen = new System.Windows.Forms.GroupBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.txtDiaChiNoiDen = new System.Windows.Forms.TextBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpChiTietPhieuDiChuyen = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.cbSoPhieuCTdc = new System.Windows.Forms.ComboBox();
            this.cbMaNhanKhau = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThemCTdc = new System.Windows.Forms.Button();
            this.btnSuaCTpdc = new System.Windows.Forms.Button();
            this.btnXoaCTpcd = new System.Windows.Forms.Button();
            this.btnHuyCTpdc = new System.Windows.Forms.Button();
            this.btnLuuCTpdc = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCTpdc = new System.Windows.Forms.DataGridView();
            this.Thoat = new System.Windows.Forms.Button();
            this.btnNgoaiNgu = new System.Windows.Forms.Button();
            this.btnTrinhDo = new System.Windows.Forms.Button();
            this.btnHoKhau = new System.Windows.Forms.Button();
            this.btnNhanKhau = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpPhieuDiChuyen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDiChuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbPhieuDiChuyen.SuspendLayout();
            this.tpChiTietPhieuDiChuyen.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTpdc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DÂN SỐ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPhieuDiChuyen);
            this.tabControl1.Controls.Add(this.tpChiTietPhieuDiChuyen);
            this.tabControl1.Location = new System.Drawing.Point(272, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 598);
            this.tabControl1.TabIndex = 1;
            // 
            // tpPhieuDiChuyen
            // 
            this.tpPhieuDiChuyen.Controls.Add(this.btnHuyPhieuDiChuyen);
            this.tpPhieuDiChuyen.Controls.Add(this.btnLuuPhieuDiChuyen);
            this.tpPhieuDiChuyen.Controls.Add(this.groupBox2);
            this.tpPhieuDiChuyen.Controls.Add(this.groupBox1);
            this.tpPhieuDiChuyen.Controls.Add(this.gbPhieuDiChuyen);
            this.tpPhieuDiChuyen.Location = new System.Drawing.Point(4, 25);
            this.tpPhieuDiChuyen.Name = "tpPhieuDiChuyen";
            this.tpPhieuDiChuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhieuDiChuyen.Size = new System.Drawing.Size(701, 569);
            this.tpPhieuDiChuyen.TabIndex = 0;
            this.tpPhieuDiChuyen.Text = "Phiếu di chuyển";
            this.tpPhieuDiChuyen.UseVisualStyleBackColor = true;
            this.tpPhieuDiChuyen.Click += new System.EventHandler(this.tpPhieuDiChuyen_Click);
            // 
            // btnHuyPhieuDiChuyen
            // 
            this.btnHuyPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnHuyPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyPhieuDiChuyen.Location = new System.Drawing.Point(519, 518);
            this.btnHuyPhieuDiChuyen.Name = "btnHuyPhieuDiChuyen";
            this.btnHuyPhieuDiChuyen.Size = new System.Drawing.Size(106, 45);
            this.btnHuyPhieuDiChuyen.TabIndex = 5;
            this.btnHuyPhieuDiChuyen.Text = "Hủy";
            this.btnHuyPhieuDiChuyen.UseVisualStyleBackColor = true;
            this.btnHuyPhieuDiChuyen.Click += new System.EventHandler(this.btnHuyPhieuDiChuyen_Click);
            // 
            // btnLuuPhieuDiChuyen
            // 
            this.btnLuuPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Save_32px1;
            this.btnLuuPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPhieuDiChuyen.Location = new System.Drawing.Point(393, 518);
            this.btnLuuPhieuDiChuyen.Name = "btnLuuPhieuDiChuyen";
            this.btnLuuPhieuDiChuyen.Size = new System.Drawing.Size(106, 45);
            this.btnLuuPhieuDiChuyen.TabIndex = 4;
            this.btnLuuPhieuDiChuyen.Text = "Lưu";
            this.btnLuuPhieuDiChuyen.UseVisualStyleBackColor = true;
            this.btnLuuPhieuDiChuyen.Click += new System.EventHandler(this.btnLuuPhieuDiChuyen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuDiChuyen);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 310);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu di chuyển";
            // 
            // dgvPhieuDiChuyen
            // 
            this.dgvPhieuDiChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDiChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDiChuyen.Location = new System.Drawing.Point(0, 45);
            this.dgvPhieuDiChuyen.Name = "dgvPhieuDiChuyen";
            this.dgvPhieuDiChuyen.RowTemplate.Height = 24;
            this.dgvPhieuDiChuyen.Size = new System.Drawing.Size(695, 277);
            this.dgvPhieuDiChuyen.TabIndex = 0;
            this.dgvPhieuDiChuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDiChuyen_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaPhieuDiChuyen);
            this.groupBox1.Controls.Add(this.btnXoaPhieuDiChuyen);
            this.groupBox1.Controls.Add(this.btnaddPhieuDiChuyen);
            this.groupBox1.Location = new System.Drawing.Point(472, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSuaPhieuDiChuyen
            // 
            this.btnSuaPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Edit_32px1;
            this.btnSuaPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhieuDiChuyen.Location = new System.Drawing.Point(47, 125);
            this.btnSuaPhieuDiChuyen.Name = "btnSuaPhieuDiChuyen";
            this.btnSuaPhieuDiChuyen.Size = new System.Drawing.Size(128, 37);
            this.btnSuaPhieuDiChuyen.TabIndex = 2;
            this.btnSuaPhieuDiChuyen.Text = "Sửa";
            this.btnSuaPhieuDiChuyen.UseVisualStyleBackColor = true;
            this.btnSuaPhieuDiChuyen.Click += new System.EventHandler(this.btnSuaPhieuDiChuyen_Click);
            // 
            // btnXoaPhieuDiChuyen
            // 
            this.btnXoaPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px1;
            this.btnXoaPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieuDiChuyen.Location = new System.Drawing.Point(47, 71);
            this.btnXoaPhieuDiChuyen.Name = "btnXoaPhieuDiChuyen";
            this.btnXoaPhieuDiChuyen.Size = new System.Drawing.Size(128, 37);
            this.btnXoaPhieuDiChuyen.TabIndex = 1;
            this.btnXoaPhieuDiChuyen.Text = "Xóa";
            this.btnXoaPhieuDiChuyen.UseVisualStyleBackColor = true;
            this.btnXoaPhieuDiChuyen.Click += new System.EventHandler(this.btnXoaPhieuDiChuyen_Click);
            // 
            // btnaddPhieuDiChuyen
            // 
            this.btnaddPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddPhieuDiChuyen.Image = global::QuanLyDanSo.Properties.Resources.Plus_Math_32px1;
            this.btnaddPhieuDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddPhieuDiChuyen.Location = new System.Drawing.Point(47, 21);
            this.btnaddPhieuDiChuyen.Name = "btnaddPhieuDiChuyen";
            this.btnaddPhieuDiChuyen.Size = new System.Drawing.Size(128, 37);
            this.btnaddPhieuDiChuyen.TabIndex = 0;
            this.btnaddPhieuDiChuyen.Text = "Thêm";
            this.btnaddPhieuDiChuyen.UseVisualStyleBackColor = true;
            this.btnaddPhieuDiChuyen.Click += new System.EventHandler(this.btnaddPhieuDiChuyen_Click);
            // 
            // gbPhieuDiChuyen
            // 
            this.gbPhieuDiChuyen.Controls.Add(this.txtSoPhieu);
            this.gbPhieuDiChuyen.Controls.Add(this.txtDiaChiNoiDen);
            this.gbPhieuDiChuyen.Controls.Add(this.dtpNgayLapPhieu);
            this.gbPhieuDiChuyen.Controls.Add(this.label4);
            this.gbPhieuDiChuyen.Controls.Add(this.label3);
            this.gbPhieuDiChuyen.Controls.Add(this.label2);
            this.gbPhieuDiChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhieuDiChuyen.Location = new System.Drawing.Point(6, 6);
            this.gbPhieuDiChuyen.Name = "gbPhieuDiChuyen";
            this.gbPhieuDiChuyen.Size = new System.Drawing.Size(441, 178);
            this.gbPhieuDiChuyen.TabIndex = 0;
            this.gbPhieuDiChuyen.TabStop = false;
            this.gbPhieuDiChuyen.Text = "Thông tin phiếu di chuyển";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(150, 34);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(242, 28);
            this.txtSoPhieu.TabIndex = 6;
            // 
            // txtDiaChiNoiDen
            // 
            this.txtDiaChiNoiDen.Location = new System.Drawing.Point(152, 118);
            this.txtDiaChiNoiDen.Name = "txtDiaChiNoiDen";
            this.txtDiaChiNoiDen.Size = new System.Drawing.Size(240, 28);
            this.txtDiaChiNoiDen.TabIndex = 5;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(150, 71);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(242, 28);
            this.dtpNgayLapPhieu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ nơi đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu";
            // 
            // tpChiTietPhieuDiChuyen
            // 
            this.tpChiTietPhieuDiChuyen.Controls.Add(this.groupBox3);
            this.tpChiTietPhieuDiChuyen.Controls.Add(this.groupBox4);
            this.tpChiTietPhieuDiChuyen.Controls.Add(this.btnHuyCTpdc);
            this.tpChiTietPhieuDiChuyen.Controls.Add(this.btnLuuCTpdc);
            this.tpChiTietPhieuDiChuyen.Controls.Add(this.groupBox5);
            this.tpChiTietPhieuDiChuyen.Location = new System.Drawing.Point(4, 25);
            this.tpChiTietPhieuDiChuyen.Name = "tpChiTietPhieuDiChuyen";
            this.tpChiTietPhieuDiChuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tpChiTietPhieuDiChuyen.Size = new System.Drawing.Size(701, 569);
            this.tpChiTietPhieuDiChuyen.TabIndex = 1;
            this.tpChiTietPhieuDiChuyen.Text = "Chi tiết phiếu di chuyển";
            this.tpChiTietPhieuDiChuyen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSTT);
            this.groupBox3.Controls.Add(this.cbSoPhieuCTdc);
            this.groupBox3.Controls.Add(this.cbMaNhanKhau);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 178);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phiếu di chuyển";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(150, 71);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(264, 28);
            this.txtSTT.TabIndex = 10;
            // 
            // cbSoPhieuCTdc
            // 
            this.cbSoPhieuCTdc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoPhieuCTdc.FormattingEnabled = true;
            this.cbSoPhieuCTdc.Location = new System.Drawing.Point(150, 26);
            this.cbSoPhieuCTdc.Name = "cbSoPhieuCTdc";
            this.cbSoPhieuCTdc.Size = new System.Drawing.Size(264, 29);
            this.cbSoPhieuCTdc.TabIndex = 9;
            // 
            // cbMaNhanKhau
            // 
            this.cbMaNhanKhau.FormattingEnabled = true;
            this.cbMaNhanKhau.Location = new System.Drawing.Point(150, 117);
            this.cbMaNhanKhau.Name = "cbMaNhanKhau";
            this.cbMaNhanKhau.Size = new System.Drawing.Size(264, 29);
            this.cbMaNhanKhau.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "STT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số phiếu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnThemCTdc);
            this.groupBox4.Controls.Add(this.btnSuaCTpdc);
            this.groupBox4.Controls.Add(this.btnXoaCTpcd);
            this.groupBox4.Location = new System.Drawing.Point(469, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 178);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnThemCTdc
            // 
            this.btnThemCTdc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTdc.Image = global::QuanLyDanSo.Properties.Resources.Plus_Math_32px1;
            this.btnThemCTdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCTdc.Location = new System.Drawing.Point(47, 26);
            this.btnThemCTdc.Name = "btnThemCTdc";
            this.btnThemCTdc.Size = new System.Drawing.Size(128, 37);
            this.btnThemCTdc.TabIndex = 3;
            this.btnThemCTdc.Text = "Thêm";
            this.btnThemCTdc.UseVisualStyleBackColor = true;
            this.btnThemCTdc.Click += new System.EventHandler(this.btnThemCTdc_Click);
            // 
            // btnSuaCTpdc
            // 
            this.btnSuaCTpdc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCTpdc.Image = global::QuanLyDanSo.Properties.Resources.Edit_32px1;
            this.btnSuaCTpdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCTpdc.Location = new System.Drawing.Point(47, 117);
            this.btnSuaCTpdc.Name = "btnSuaCTpdc";
            this.btnSuaCTpdc.Size = new System.Drawing.Size(128, 37);
            this.btnSuaCTpdc.TabIndex = 2;
            this.btnSuaCTpdc.Text = "Sửa";
            this.btnSuaCTpdc.UseVisualStyleBackColor = true;
            this.btnSuaCTpdc.Click += new System.EventHandler(this.btnSuaCTpdc_Click);
            // 
            // btnXoaCTpcd
            // 
            this.btnXoaCTpcd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCTpcd.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px1;
            this.btnXoaCTpcd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCTpcd.Location = new System.Drawing.Point(47, 71);
            this.btnXoaCTpcd.Name = "btnXoaCTpcd";
            this.btnXoaCTpcd.Size = new System.Drawing.Size(128, 37);
            this.btnXoaCTpcd.TabIndex = 1;
            this.btnXoaCTpcd.Text = "Xóa";
            this.btnXoaCTpcd.UseVisualStyleBackColor = true;
            this.btnXoaCTpcd.Click += new System.EventHandler(this.btnXoaCTpcd_Click);
            // 
            // btnHuyCTpdc
            // 
            this.btnHuyCTpdc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCTpdc.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px;
            this.btnHuyCTpdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCTpdc.Location = new System.Drawing.Point(516, 518);
            this.btnHuyCTpdc.Name = "btnHuyCTpdc";
            this.btnHuyCTpdc.Size = new System.Drawing.Size(106, 45);
            this.btnHuyCTpdc.TabIndex = 10;
            this.btnHuyCTpdc.Text = "Hủy";
            this.btnHuyCTpdc.UseVisualStyleBackColor = true;
            this.btnHuyCTpdc.Click += new System.EventHandler(this.btnHuyCTpdc_Click);
            // 
            // btnLuuCTpdc
            // 
            this.btnLuuCTpdc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCTpdc.Image = global::QuanLyDanSo.Properties.Resources.Save_32px1;
            this.btnLuuCTpdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCTpdc.Location = new System.Drawing.Point(390, 518);
            this.btnLuuCTpdc.Name = "btnLuuCTpdc";
            this.btnLuuCTpdc.Size = new System.Drawing.Size(106, 45);
            this.btnLuuCTpdc.TabIndex = 9;
            this.btnLuuCTpdc.Text = "Lưu";
            this.btnLuuCTpdc.UseVisualStyleBackColor = true;
            this.btnLuuCTpdc.Click += new System.EventHandler(this.btnLuuCTpdc_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCTpdc);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(695, 310);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phiếu di chuyển";
            // 
            // dgvCTpdc
            // 
            this.dgvCTpdc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTpdc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTpdc.Location = new System.Drawing.Point(3, 24);
            this.dgvCTpdc.Name = "dgvCTpdc";
            this.dgvCTpdc.RowTemplate.Height = 24;
            this.dgvCTpdc.Size = new System.Drawing.Size(686, 298);
            this.dgvCTpdc.TabIndex = 0;
            this.dgvCTpdc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTpdc_CellClick);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Image = global::QuanLyDanSo.Properties.Resources.Delete_32px2;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Thoat.Location = new System.Drawing.Point(52, 371);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(195, 71);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // btnNgoaiNgu
            // 
            this.btnNgoaiNgu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgoaiNgu.Image = global::QuanLyDanSo.Properties.Resources.Translation_32px;
            this.btnNgoaiNgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgoaiNgu.Location = new System.Drawing.Point(52, 294);
            this.btnNgoaiNgu.Name = "btnNgoaiNgu";
            this.btnNgoaiNgu.Size = new System.Drawing.Size(195, 71);
            this.btnNgoaiNgu.TabIndex = 3;
            this.btnNgoaiNgu.Text = "Ngoại ngữ";
            this.btnNgoaiNgu.UseVisualStyleBackColor = true;
            this.btnNgoaiNgu.Click += new System.EventHandler(this.btnNgoaiNgu_Click);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrinhDo.Image = global::QuanLyDanSo.Properties.Resources.Graduation_Cap_32px;
            this.btnTrinhDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrinhDo.Location = new System.Drawing.Point(52, 217);
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.Size = new System.Drawing.Size(195, 71);
            this.btnTrinhDo.TabIndex = 3;
            this.btnTrinhDo.Text = "Trình độ";
            this.btnTrinhDo.UseVisualStyleBackColor = true;
            this.btnTrinhDo.Click += new System.EventHandler(this.btnTrinhDo_Click);
            // 
            // btnHoKhau
            // 
            this.btnHoKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoKhau.Image = global::QuanLyDanSo.Properties.Resources.Conference_32px;
            this.btnHoKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoKhau.Location = new System.Drawing.Point(52, 140);
            this.btnHoKhau.Name = "btnHoKhau";
            this.btnHoKhau.Size = new System.Drawing.Size(195, 71);
            this.btnHoKhau.TabIndex = 3;
            this.btnHoKhau.Text = "Hộ khẩu";
            this.btnHoKhau.UseVisualStyleBackColor = true;
            this.btnHoKhau.Click += new System.EventHandler(this.btnHoKhau_Click);
            // 
            // btnNhanKhau
            // 
            this.btnNhanKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanKhau.Image = global::QuanLyDanSo.Properties.Resources.User_48px;
            this.btnNhanKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanKhau.Location = new System.Drawing.Point(52, 63);
            this.btnNhanKhau.Name = "btnNhanKhau";
            this.btnNhanKhau.Size = new System.Drawing.Size(195, 71);
            this.btnNhanKhau.TabIndex = 2;
            this.btnNhanKhau.Text = "Nhân khẩu";
            this.btnNhanKhau.UseVisualStyleBackColor = true;
            this.btnNhanKhau.Click += new System.EventHandler(this.btnNhanKhau_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 667);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.btnNgoaiNgu);
            this.Controls.Add(this.btnTrinhDo);
            this.Controls.Add(this.btnHoKhau);
            this.Controls.Add(this.btnNhanKhau);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPhieuDiChuyen.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDiChuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbPhieuDiChuyen.ResumeLayout(false);
            this.gbPhieuDiChuyen.PerformLayout();
            this.tpChiTietPhieuDiChuyen.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTpdc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPhieuDiChuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuaPhieuDiChuyen;
        private System.Windows.Forms.Button btnXoaPhieuDiChuyen;
        private System.Windows.Forms.Button btnaddPhieuDiChuyen;
        private System.Windows.Forms.GroupBox gbPhieuDiChuyen;
        private System.Windows.Forms.TextBox txtDiaChiNoiDen;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpChiTietPhieuDiChuyen;
        private System.Windows.Forms.Button btnNhanKhau;
        private System.Windows.Forms.Button btnHoKhau;
        private System.Windows.Forms.Button btnTrinhDo;
        private System.Windows.Forms.Button btnNgoaiNgu;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button btnLuuPhieuDiChuyen;
        private System.Windows.Forms.Button btnHuyPhieuDiChuyen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSuaCTpdc;
        private System.Windows.Forms.Button btnXoaCTpcd;
        private System.Windows.Forms.Button btnHuyCTpdc;
        private System.Windows.Forms.Button btnLuuCTpdc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPhieuDiChuyen;
        private System.Windows.Forms.DataGridView dgvCTpdc;
        private System.Windows.Forms.ComboBox cbMaNhanKhau;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.ComboBox cbSoPhieuCTdc;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnThemCTdc;
    }
}