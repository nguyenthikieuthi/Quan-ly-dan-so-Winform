using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDanSo.ACTION;

namespace QuanLyDanSo.GUI
{
    public partial class FrmNhanKhau : Form
    {
        private bool isAddItem;
        private BindingSource list = new BindingSource();
        public FrmNhanKhau()
        {
            InitializeComponent();
            LoadNhanKhau();
        }
        void LoadComboBoxGioiTinh(ComboBox combo)
        {
            combo.DataSource = NhanKhau.Instance.LoadDanhSachGioiTinh();
            combo.DisplayMember = "Giới tính";
            combo.ValueMember = "Giới tính";

        }
        void LoadComboBoxTrinhDoVanHoa(ComboBox combo)
        {
            combo.DataSource = NhanKhau.Instance.LoadDanhSachMaTrinhDo();
            combo.DisplayMember = "Tên trình độ văn hóa";
            combo.ValueMember = "Mã trình độ văn hóa";

        }
        void LoadComboBoxMaNgoaiNgu(ComboBox combo)
        {
            combo.DataSource = NgoaiNgu.Instance.ShowListMaNgoaiNgu();
            combo.DisplayMember = "Tên Ngoại Ngữ";
            combo.ValueMember = "Mã Ngoại Ngữ";

        }
        void LoadComboBoxSoHoKhau(ComboBox combo)
        {

            combo.DataSource = HoKhau.Instance.LoadDanhSachSoHoKhau();
            combo.DisplayMember = "Số sổ hộ khẩu";
            combo.ValueMember = "Số sổ hộ khẩu";
        }

        void LoadNhanKhau()
        {
            LoadListNhanKhau();
            LoadComboBoxGioiTinh(cbGioiTinh);
            LoadComboBoxTrinhDoVanHoa(cbMaTrinhDo);
            LoadComboBoxMaNgoaiNgu(cbMaNgoaiNgu);
            LoadComboBoxSoHoKhau(cbSoHoKhau);
        }

        void LoadListNhanKhau()
        {
            dgvNhanKhau.DataSource = NhanKhau.Instance.LoadDanhSachNhanKhau();
            SetNull();
            SetBtn(false);
            SetText(false);
        }
        void SetText(bool a)
        {
            txtMaNhanKhau.Enabled = a;
            txtTenNhanKhau.Enabled = a;
            txtCMND.Enabled = a;
            txtGhiChu.Enabled = a;
            cbGioiTinh.Enabled = a;
            cbMaNgoaiNgu.Enabled = a;
            cbMaTrinhDo.Enabled = a;
            cbSoHoKhau.Enabled = a;
            dtpNgaySinh.Enabled = a;

        }

        void SetNull()
        {
            txtMaNhanKhau.Text = string.Empty;
            txtTenNhanKhau.Text = string.Empty;
            txtCMND.Text = string.Empty;
            
            txtGhiChu.Text = string.Empty;
            
            
        }

        void SetBtn(bool a)
        {
            btnHuyNhanKhau.Enabled = a;
            btnSuaNhanKhau.Enabled = !a;
            btnThemNhanKhau.Enabled = !a;
            btnXoaNhanKhau.Enabled = !a;
            btnLuuNhanKhau.Enabled = a;

        }
        private void FrmNhanKhau_Load(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(true);
            SetText(true);

            isAddItem = true;
        }

        private void btnXoaNhanKhau_Click(object sender, EventArgs e)
        {
            try
            {
                int manhankhau = Convert.ToInt32(txtMaNhanKhau.Text);
                DialogResult result = MessageBox.Show("Bạn chắc chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (NhanKhau.Instance.XoaNhanKhau(manhankhau)) 
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadNhanKhau();
                        SetBtn(false);
                        SetText(false);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất bại");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSuaNhanKhau_Click(object sender, EventArgs e)
        {
            SetBtn(true);
            SetText(true);
            txtMaNhanKhau.ReadOnly = true;

            isAddItem = false;
        }

        private void btnHuyNhanKhau_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(false);
            SetText(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int manhankhau = Convert.ToInt32(txtMaNhanKhau.Text);
                int socmnd = Convert.ToInt32(txtCMND.Text);
                string tennhankhau =txtTenNhanKhau.Text;
                string ghichu = txtGhiChu.Text;
                string gioitinh = cbGioiTinh.SelectedValue.ToString();
                string ngaysinh = string.Format("{0:MM/dd/yyyy}",dtpNgaySinh.Value);
                string matrinhdovanhoa = cbMaTrinhDo.SelectedValue.ToString();
                string mangoaingu = cbMaNgoaiNgu.SelectedValue.ToString();
                int sohokhau =Convert.ToInt32( cbSoHoKhau.SelectedValue.ToString());
                //int numCheck = 0;

                if (isAddItem == true)
                {
                    //try
                    //{

                        //else
                        if (txtMaNhanKhau.Text == string.Empty || txtTenNhanKhau.Text == string.Empty || txtCMND.Text == string.Empty)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                        }
                        else

                        if (NhanKhau.Instance.ThemNhanKhau(manhankhau,tennhankhau,gioitinh,ngaysinh,socmnd,mangoaingu,sohokhau,matrinhdovanhoa,ghichu))
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadNhanKhau();
                            SetText(false);
                            SetBtn(false);
                        }

                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("Nhân khẩu đã tồn tại");
                    //}
                }
                else if (isAddItem == false)
                {

                    try
                    {
                        if (txtMaNhanKhau.Text == string.Empty || txtTenNhanKhau.Text == string.Empty || txtCMND.Text == string.Empty)
                        
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        }
                        else
                        if (NhanKhau.Instance.SuathongtinNhanKhau(manhankhau, tennhankhau, gioitinh, ngaysinh, socmnd, mangoaingu, sohokhau, matrinhdovanhoa, ghichu))
                        {
                            MessageBox.Show("Sửa thông tin thành công");
                            LoadNhanKhau();
                            SetBtn(false);
                            SetText(false);
                        }
                    }
                    catch (FormatException) { }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số", "Lỗi");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Nhập sai ngày", "Lỗi");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Lỗi nhập CMND", "Lỗi");
            }
        }

        private void btnThoatNhanKhau_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) ;
            //{
            //    this.Hide();
            //    FrmMain main = new FrmMain();
            //    main.Show();
            //    //Dispose();//giải phóng tài nguyên
            //}
            Close();

        }

        private void dgvNhanKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanKhau.SelectedRows.Count > 0)
            {
                txtMaNhanKhau.Text = dgvNhanKhau.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNhanKhau.Text = dgvNhanKhau.SelectedRows[1].Cells[1].Value.ToString();
                cbGioiTinh.SelectedValue = dgvNhanKhau.SelectedRows[2].Cells[2].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse( dgvNhanKhau.SelectedRows[3].Cells[3].Value.ToString());
                txtCMND.Text = dgvNhanKhau.SelectedRows[4].Cells[4].Value.ToString();
                cbMaNgoaiNgu.SelectedValue = dgvNhanKhau.SelectedRows[5].Cells[5].Value.ToString();
                cbSoHoKhau.SelectedValue= dgvNhanKhau.SelectedRows[6].Cells[6].Value.ToString();
                cbMaTrinhDo.SelectedValue= dgvNhanKhau.SelectedRows[7].Cells[7].Value.ToString();
                txtGhiChu.Text = dgvNhanKhau.SelectedRows[8].Cells[8].Value.ToString();

                // Thay đổi tương ứng với số cột trong datagridview
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanKhau.Rows[e.RowIndex];
               

                txtMaNhanKhau.Text = row.Cells[0].Value.ToString();
                txtTenNhanKhau.Text = row.Cells[1].Value.ToString();
                cbGioiTinh.SelectedValue = row.Cells[2].Value.ToString();
                dtpNgaySinh.Value =DateTime.Parse( row.Cells[3].Value.ToString());
                txtCMND.Text = row.Cells[4].Value.ToString();
                cbMaNgoaiNgu.SelectedValue = row.Cells[5].Value.ToString();
                cbSoHoKhau.SelectedValue = row.Cells[6].Value.ToString();
                cbMaTrinhDo.SelectedValue = row.Cells[7].Value.ToString();
                txtGhiChu.Text = row.Cells[8].Value.ToString();
                // Thay đổi tương ứng với số cột trong datagridview
            }
        }
    }
}
