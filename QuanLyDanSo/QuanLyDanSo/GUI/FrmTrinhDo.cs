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
    public partial class FrmTrinhDo : Form
    {
        private bool isAddItem;
        private BindingSource list = new BindingSource();
        public FrmTrinhDo()
        {
            InitializeComponent();
            LoadTrinhDO();
        }
        void LoadTrinhDO()
        {
            LoadListTrinhDo();
           
        }

        void LoadListTrinhDo()
        {

            dgvTrinhDo.DataSource = TrinhDo.Instance.ShowListTrinhDo();
            //LoadMaTrinhDo(cbMaTrinhDo);
            SetNull();
            SetBtn(false);
            SetText(false);
        }

   
        private void FrmTrinhDo_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(false);
            SetText(false);

        }
        void SetText (bool a)
        {
            txtMaTrinhDo.Enabled = a;
            txtTenTrinhDo.Enabled = a;
        }

        void SetNull()
        {
           
            txtTenTrinhDo.Text = string.Empty;
            txtMaTrinhDo.Text = string.Empty;
        }

        void SetBtn(bool a)
        {
            btnLuuTrinhDo.Enabled = a;
            btnSuaTrinhDoVanHoa.Enabled = !a;
            btnThemTrinhDo.Enabled = !a;
            btnXoaTrinhDo.Enabled = !a;
            
            btnHuyTrinhDo.Enabled = a;

        }

        void LoadMaTrinhDo ( ComboBox combo)
        {
            combo.DataSource = TrinhDo.Instance.ShowListMaTrinhDo();
            combo.DisplayMember = "Tên trình độ văn hóa";
            combo.ValueMember = "Mã trình độ văn hóa";
        }
        private void btnThemTrinhDo_Click(object sender, EventArgs e)
        {
            SetNull();
            SetBtn(true);
            SetText(true);
              
            isAddItem = true;

        }



        private void dgvTrinhDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnLuuTrinhDo_Click(object sender, EventArgs e)
        {
            string tentrinhdo = txtTenTrinhDo.Text;
            string matrinhdo = txtMaTrinhDo.Text;
           
            if (isAddItem == true)
            {
                try
                {
                    if (txtTenTrinhDo.Text == string.Empty || txtMaTrinhDo.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                    }
                    else
                    if (TrinhDo.Instance.AddTrinhDo(matrinhdo ,tentrinhdo))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadListTrinhDo();
                        SetText(false);
                        SetBtn(false);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã trình độ đã tồn tại");
                }
            }
            else if (isAddItem == false)
            {
                if (txtTenTrinhDo.Text == string.Empty || txtMaTrinhDo.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                    if (TrinhDo.Instance.SuaTrinhDo(matrinhdo, tentrinhdo))
                {
                    MessageBox.Show("Sửa thông tin thành công");
                    LoadListTrinhDo();
                    SetBtn(false);
                    SetText(false);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) ;
            {
                this.Hide();
                FrmMain main = new FrmMain();
                main.Show();
               // Dispose();//giải phóng tài nguyên
            }
        }

        private void btnSuaTrinhDoVanHoa_Click(object sender, EventArgs e)
        {
            SetBtn(true);
            SetText(true);
            txtMaTrinhDo.ReadOnly = true;

            isAddItem = false;
        }

        private void dgvTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrinhDo.SelectedRows.Count > 0)
            {
                txtMaTrinhDo.Text = dgvTrinhDo.SelectedRows[0].Cells[0].Value.ToString();
                txtTenTrinhDo.Text= dgvTrinhDo.SelectedRows[1].Cells[1].Value.ToString();
            }
            else
                if (e.RowIndex >=0)
            {
                DataGridViewRow row = dgvTrinhDo.Rows[e.RowIndex];
                txtMaTrinhDo.Text = row.Cells[0].Value.ToString();
                txtTenTrinhDo.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnXoaTrinhDo_Click(object sender, EventArgs e)
        {
            string matrinhdo = txtMaTrinhDo.Text;
            DialogResult result = MessageBox.Show("Bạn chắc chắc muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if( result == DialogResult.Yes)
            {
                if (TrinhDo.Instance.DeleteTrinhDo(matrinhdo))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadListTrinhDo();
                    SetBtn(false);
                    SetText(false);
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
              
            }
        }
    }
}
