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
    public partial class FrmNgoaiNgu : Form
    {
        public BindingSource list = new BindingSource();
        private bool isAddItem;
        //public Boolean abc;
        public FrmNgoaiNgu()
        {
            InitializeComponent();
            LoadNgoaiNgu();
        }

        void LoadNgoaiNgu()
        {
            LoadListNgoaiNgu();
        }

        void LoadListNgoaiNgu()
        {

            dgvNgoaiNgu.DataSource = NgoaiNgu.Instance.ShowListNgoaiNgu();
            SetNull();
            SetBtn(false);
            SetText(false);
            
        }

        void SetText(bool a)
        {
            txtMaNgoaiNgu.Enabled = a;
            txtTenNgoaiNgu.Enabled = a;
        }

        void SetNull()
        {
            txtMaNgoaiNgu.Text = string.Empty;
            txtTenNgoaiNgu.Text = string.Empty;
        }

        void SetBtn(bool a)
        {
            btnLuuNgoaiNgu.Enabled = a;
            btnSuaNgoaiNgu.Enabled = !a;
            btnThemNgoaiNgu.Enabled = !a;
            btnXoaNgoaiNgu.Enabled = !a;
            btnHuyNgoaiNgu.Enabled = a;

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void NgoaiNgu_Load(object sender, EventArgs e)
        {

        }

        private void btnThoatNgoaiNgu_Click(object sender, EventArgs e)
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

        private void btnXoaNgoaiNgu_Click(object sender, EventArgs e)
        {
            string mangoaingu = txtMaNgoaiNgu.Text;
            DialogResult result = MessageBox.Show("Bạn chắc chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (NgoaiNgu.Instance.DeleteNgoaiNgu(mangoaingu))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadNgoaiNgu();
                    SetBtn(false);
                    SetText(false);
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }

            }
        }

        private void btnSuaNgoaiNgu_Click(object sender, EventArgs e)
        {
            SetBtn(true);
            SetText(true);
            txtMaNgoaiNgu
.ReadOnly = true;

            isAddItem = false;
        }

        private void btnHuyNgoaiNgu_Click(object sender, EventArgs e)
        {

            SetNull();
            SetBtn(false);
            SetText(false);
        }

        private void btnLuuNgoaiNgu_Click(object sender, EventArgs e)
        {
            string mangoaingu = txtMaNgoaiNgu.Text;
            string tenngoaingu = txtTenNgoaiNgu.Text;

            if (isAddItem == true)
            {
                try
                {
                    if (txtMaNgoaiNgu.Text == string.Empty || txtTenNgoaiNgu.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                    }
                    else
                    if (NgoaiNgu.Instance.AddNgoaiNgu(mangoaingu, tenngoaingu))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadNgoaiNgu();
                        SetText(false);
                        SetBtn(false);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã ngoại ngữ đã tồn tại");
                }
            }
            else if (isAddItem == false)
            {
                if (txtMaNgoaiNgu.Text == string.Empty || txtTenNgoaiNgu.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                    if (NgoaiNgu.Instance.SuaNgoaiNgu(mangoaingu,tenngoaingu))
                {
                    MessageBox.Show("Sửa thông tin thành công");
                    LoadNgoaiNgu();
                    SetBtn(false);
                    SetText(false);
                }
            }
        }

        private void dgvNgoaiNgu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNgoaiNgu.SelectedRows.Count > 0)
            {
               txtMaNgoaiNgu.Text = dgvNgoaiNgu.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNgoaiNgu.Text = dgvNgoaiNgu.SelectedRows[1].Cells[1].Value.ToString();
            }
            else
               if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNgoaiNgu.Rows[e.RowIndex];
                txtMaNgoaiNgu.Text = row.Cells[0].Value.ToString();
                txtTenNgoaiNgu.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnThemNgoaiNgu_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(true);
            SetText(true);

            isAddItem = true;
        }
    }
}
