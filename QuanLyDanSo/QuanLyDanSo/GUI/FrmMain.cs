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
    public partial class FrmMain : Form
    {
        private bool isAddItem;
        private BindingSource list = new BindingSource();
        public FrmMain()
        {
            InitializeComponent();
            LoadPhieuDiChuyen();
            LoadCTPhieuDiChuyen();
        }

        void LoadPhieuDiChuyen()
        {
            LoadListPhieuDiChuyen();

        }

        void LoadCTPhieuDiChuyen()
        {
            LoadListCTPhieuDiChuyen();
            LoadComboBoxSoPhieu(cbSoPhieuCTdc);
            LoadComboBoxMaNhanKhau(cbMaNhanKhau);
        }

        void LoadListPhieuDiChuyen()
        {
            dgvPhieuDiChuyen.DataSource = PhieuDiChuyen.Instance.ShowPhieuDiChuyen();
            SetNull();
            SetBtn(false);
            SetText(false);
        }

        void LoadListCTPhieuDiChuyen()
        {
            dgvCTpdc.DataSource = ChiTietPhieuDiChuyen.Instance.ShowChiTietPhieuDiChuyen();
            SetNull();
            SetBtndc(false);
            SetTextdc(false);
        }


        void SetNull ()
        {
            txtSoPhieu.Text = string.Empty;
            txtDiaChiNoiDen.Text = string.Empty;

        }
        void SetNulldc()
        {
            txtSTT.Text = string.Empty;
        }

        

        void SetBtndc (bool a)
        {
            btnThemCTdc.Enabled = !a;
            btnLuuCTpdc.Enabled = a;
            btnHuyCTpdc.Enabled = a;
            btnSuaCTpdc.Enabled = !a;
            btnXoaCTpcd.Enabled = !a;
            
        }

        void SetBtn( bool a)
        {
            btnaddPhieuDiChuyen.Enabled = !a;
            btnSuaPhieuDiChuyen.Enabled = !a;
            btnXoaPhieuDiChuyen.Enabled = !a;
            btnLuuPhieuDiChuyen.Enabled = a;
            btnHuyPhieuDiChuyen.Enabled = a;
        }

        void SetText (bool a)
        {
            txtSoPhieu.Enabled = a;
            txtDiaChiNoiDen.Enabled = a;
            dtpNgayLapPhieu.Enabled = a;
          

        }
        void SetTextdc (bool a)
        {
            cbSoPhieuCTdc.Enabled = a;
            txtSTT.Enabled = a;
            cbMaNhanKhau.Enabled = a;
        }
        
        void LoadComboBoxSoPhieu(ComboBox combo)
        {
            combo.DataSource = ChiTietPhieuDiChuyen.Instance.ShowSoPhieuDiChuyen() ;
            combo.DisplayMember = "Số phiếu";
            combo.ValueMember = "Số phiếu";

        }

        void LoadComboBoxMaNhanKhau(ComboBox combo)
        {
            combo.DataSource = ChiTietPhieuDiChuyen.Instance.ShowMaNhanKhau();
            combo.DisplayMember = "Tên nhân khẩu";
            combo.ValueMember = "Mã nhân khẩu";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            FrmNhanKhau nhanKhau = new FrmNhanKhau();
            this.Hide();
            nhanKhau.ShowDialog();
            Show();
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHoKhau hoKhau = new FormHoKhau();
            hoKhau.Show();
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTrinhDo trinhDo = new FrmTrinhDo();
            trinhDo.Show();
        }

        private void btnNgoaiNgu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNgoaiNgu ngoaiNgu = new FrmNgoaiNgu();
            ngoaiNgu.ShowDialog();
            Show();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin lg = new FrmLogin();
            lg.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnaddPhieuDiChuyen_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(true);
            SetText(true);
            txtSoPhieu.ReadOnly = false;
            isAddItem = true;
        }

        private void btnXoaPhieuDiChuyen_Click(object sender, EventArgs e)
        {
            
            try
            {
                int sophieu = Convert.ToInt32(txtSoPhieu.Text);
                DialogResult result = MessageBox.Show("Bạn chắc chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (PhieuDiChuyen.Instance.DeletePhieuDiChuyen(sophieu))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadListPhieuDiChuyen();
                        SetBtn(false);
                        SetText(false);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất bại");
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }

        private void btnSuaPhieuDiChuyen_Click(object sender, EventArgs e)
        {
            SetBtn(true);
            SetText(true);
            txtSoPhieu.ReadOnly = true;

            isAddItem = false;
        }

        private void btnLuuPhieuDiChuyen_Click(object sender, EventArgs e)
        {
            
            try
            {
                int sophieu = Convert.ToInt32(txtSoPhieu.Text);
                string diachi = txtDiaChiNoiDen.Text;
                string ngaylapphieu = string.Format("{0:MM/dd/yyyy}", dtpNgayLapPhieu.Value);
                if (isAddItem == true)
                {
                    //try
                    //{
                        if (txtSoPhieu.Text == string.Empty || txtDiaChiNoiDen.Text == string.Empty)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                        }
                        //if (dtpNgayLapPhieu.Value > DateTime.Today)
                        //{
                        //    MessageBox.Show("Sai ngay roi ba", "Lỗi");
                        //}
                        else
                        if (PhieuDiChuyen.Instance.AddPhieuDiChuyen(sophieu, ngaylapphieu, diachi))
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadPhieuDiChuyen();
                            SetText(false);
                            SetBtn(false);
                        }

                    //}
                    //catch (System.Data.SqlClient.SqlException)
                    //{
                    //    MessageBox.Show("Số phiếu đã tồn tại");
                    //}
                }
                else if (isAddItem == false)
                {

                    try
                    {
                        if (txtSoPhieu.Text == string.Empty || txtDiaChiNoiDen.Text == string.Empty || dtpNgayLapPhieu.Value > DateTime.Today)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        }
                        else
                        if (PhieuDiChuyen.Instance.SuaPhieuDiChuyen(sophieu, ngaylapphieu, diachi))
                        {
                            MessageBox.Show("Sửa thông tin thành công");
                            LoadPhieuDiChuyen();
                            SetBtn(false);
                            SetText(false);
                        }
                    }
                    catch (FormatException) { }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("<\\ Mã đã tồn tại > hoặc <\\ Ngày không hợp lệ >", "Lỗi");
            }

        }

        private void btnHuyPhieuDiChuyen_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(false);
            SetText(false);
        }

        private void dgvPhieuDiChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPhieuDiChuyen.SelectedRows.Count > 0)
                {
                    txtSoPhieu.Text = dgvPhieuDiChuyen.SelectedRows[0].Cells[0].Value.ToString();
                    txtDiaChiNoiDen.Text = dgvPhieuDiChuyen.SelectedRows[0].Cells[2].Value.ToString();
                    dtpNgayLapPhieu.Value = Convert.ToDateTime(dgvPhieuDiChuyen.SelectedRows[0].Cells[1].Value.ToString());
                }
                else
               if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPhieuDiChuyen.Rows[e.RowIndex];
                    txtSoPhieu.Text = row.Cells[0].Value.ToString();
                    txtDiaChiNoiDen.Text = row.Cells[2].Value.ToString();
                    dtpNgayLapPhieu.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
                }
            }
            catch (FormatException) { }
        }

        private void tpPhieuDiChuyen_Click(object sender, EventArgs e)
        {

        }


        private void btnXoaCTpcd_Click(object sender, EventArgs e)
        {
             try
            {
                int sophieu = Convert.ToInt32(txtSoPhieu.Text);
                DialogResult result = MessageBox.Show("Bạn chắc chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ChiTietPhieuDiChuyen.Instance.DeleteChiTietPhieuDiChuyen(sophieu)) 
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadCTPhieuDiChuyen();
                        SetBtndc(false);
                        SetTextdc(false);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất bại");
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }

        private void btnSuaCTpdc_Click(object sender, EventArgs e)
        {
            SetBtndc(true);
            SetTextdc(true);
            cbSoPhieuCTdc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaNhanKhau.DropDownStyle = ComboBoxStyle.DropDownList;
            isAddItem = false;
        }

        private void btnLuuCTpdc_Click(object sender, EventArgs e)
        {
            try
            {
                int stt = Convert.ToInt32(txtSTT.Text);
                int sophieu = Convert.ToInt32(cbSoPhieuCTdc.SelectedValue.ToString());
                int manhankhau = Convert.ToInt32(cbMaNhanKhau.SelectedValue.ToString());

                if (isAddItem == true)
                {
                    try
                    {

                        
                        if (txtSTT.Text == string.Empty )
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                        }
                        else

                        if (ChiTietPhieuDiChuyen.Instance.AddChiTietPhieuDiChuyen(sophieu,stt,manhankhau))
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadCTPhieuDiChuyen();
                            SetTextdc(false);
                            SetBtndc(false);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Số STT đã tồn tại");
                    }
                }
                else if (isAddItem == false)
                {

                    try
                    {
                        if (txtSTT.Text == string.Empty )
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        }
                        else
                        if (ChiTietPhieuDiChuyen.Instance.SuaChiTietPhieuDiChuyen(sophieu,stt,manhankhau))
                        {
                            MessageBox.Show("Sửa thông tin thành công");
                            LoadCTPhieuDiChuyen();
                            SetBtndc(false);
                            SetTextdc(false);
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

        private void btnHuyCTpdc_Click(object sender, EventArgs e)
        {
            SetNulldc();
            SetBtndc(false);
            SetTextdc(false);
        }

        private void dgvCTpdc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTpdc.SelectedRows.Count > 0)
            {
                cbSoPhieuCTdc.SelectedValue = dgvCTpdc.SelectedRows[0].Cells[0].Value.ToString();
                txtSTT.Text = dgvCTpdc.SelectedRows[1].Cells[1].Value.ToString();
                cbMaNhanKhau.SelectedValue = dgvCTpdc.SelectedRows[2].Cells[2].Value.ToString();
                
                
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCTpdc.Rows[e.RowIndex];
                cbSoPhieuCTdc.SelectedValue = row.Cells[0].Value.ToString();
                txtSTT.Text = row.Cells[1].Value.ToString();
                cbMaNhanKhau.SelectedValue = row.Cells[2].Value.ToString();
               
            }
        }

        private void btnThemCTdc_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtndc(true);
            SetTextdc(true);

            isAddItem = true;
        }
    }
    
}
