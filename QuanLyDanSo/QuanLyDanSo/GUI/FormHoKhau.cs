using QuanLyDanSo.ACTION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDanSo.GUI
{
    public partial class FormHoKhau : Form
    {
        private bool isAddItem;
        private BindingSource list = new BindingSource();
        public FormHoKhau()
        {
            InitializeComponent();
            LoadHoKhau();
        }

        void LoadListHoKhau()
        {
            dgvHoKhau.DataSource = HoKhau.Instance.LoadHoKhau();
            SetText(false);
            SetNull();
            SetBtn(false);
        }

        void LoadHoKhau()
        {
            LoadListHoKhau();
        }
        void SetText(bool a)
        {
            txtSoSoHoKhau.Enabled = a;
            txtDiaChi.Enabled = a;
            txtMaPhuong.Enabled = a;
        }

        void SetNull()
        {

            txtSoSoHoKhau.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtMaPhuong.Text = string.Empty;
        }

        void SetBtn(bool a)
        {
            btnLuuHoKhau.Enabled = a;
            btnSuaHoKhau.Enabled = !a;
            btnThemHoKhau.Enabled = !a;
            btnXoaHoKhau.Enabled = !a;

            btnHuyHoKhau.Enabled = a;

        }
        private void FormHoKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnThemHoKhau_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(true);
            SetText(true);

            isAddItem = true;
        }

        private void btnXoaHoKhau_Click(object sender, EventArgs e)
        {
            try
            {
                int sohokhau = Convert.ToInt32(txtSoSoHoKhau.Text);
                DialogResult result = MessageBox.Show("Bạn chắc chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (HoKhau.Instance.XoaHoKhau(sohokhau))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadHoKhau();
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

        private void btnSuaHoKhau_Click(object sender, EventArgs e)
        {
            SetBtn(true);
            SetText(true);
            txtSoSoHoKhau.ReadOnly = true;

            isAddItem = false;
        }

        private void btnLuuHoKhau_Click(object sender, EventArgs e)
        {
            try
            {
                int sohokhau = Convert.ToInt32(txtSoSoHoKhau.Text);
                int maphuong = Convert.ToInt32(txtMaPhuong.Text);
                string diachi = txtDiaChi.Text;
                //int numCheck = 0;
               
                if (isAddItem == true)
                {
                    try
                    {
                        
                        //else
                        if (txtDiaChi.Text == string.Empty || txtDiaChi.Text == string.Empty || txtMaPhuong.Text == string.Empty)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                        }
                        else
                        
                        if (HoKhau.Instance.ThemHoKhau(sohokhau, diachi, maphuong)) 
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadHoKhau();
                            SetText(false);
                            SetBtn(false);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Số phiếu đã tồn tại");
                    }
                }
                else if (isAddItem == false)
                {

                    try
                    {
                        if (txtSoSoHoKhau.Text == string.Empty || txtDiaChi.Text == string.Empty || txtMaPhuong.Text == string.Empty)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        }
                        else
                        if (HoKhau.Instance.SuathongtinHoKhau(sohokhau,diachi,maphuong))
                        {
                            MessageBox.Show("Sửa thông tin thành công");
                            LoadHoKhau();
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
        }

        private void btnHuyHoKhau_Click(object sender, EventArgs e)
        {

            SetNull();
            SetBtn(false);
            SetText(false);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain();
            main.Show();
        }

        private void txtSoSoHoKhau_TextChanged(object sender, EventArgs e)
        {
            //int numCheck = 0;
            //if (!int.TryParse(txtSoSoHoKhau.Text, out numCheck) || !int.TryParse(txtMaPhuong.Text, out numCheck))
            //{
            //    MessageBox.Show("Vui lòng nhập bằng số", "Lỗi");
            //}
        }

        private void dgvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoKhau.SelectedRows.Count > 0)
            {
                txtSoSoHoKhau.Text = dgvHoKhau.SelectedRows[0].Cells[0].Value.ToString();
                txtDiaChi.Text = dgvHoKhau.SelectedRows[1].Cells[1].Value.ToString();
                txtMaPhuong.Text = dgvHoKhau.SelectedRows[2].Cells[2].Value.ToString();

                // Thay đổi tương ứng với số cột trong datagridview
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoKhau.Rows[e.RowIndex];
                txtSoSoHoKhau.Text = row.Cells[0].Value.ToString();
                txtDiaChi.Text = row.Cells[1].Value.ToString();
                txtMaPhuong.Text = row.Cells[2].Value.ToString();

                // Thay đổi tương ứng với số cột trong datagridview
            }
        }

        private void dgvHoKhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
