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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginTableAdapters.QueriesTableAdapter lg = new LoginTableAdapters.QueriesTableAdapter();
            if (lg.checkLog(this.txtTenDangNhap.Text, this.txtMatKhau.Text) == 1)
            {
                this.Hide();
                FrmMain pdc = new FrmMain();
                pdc.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }

        private void cbshowmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowmatkhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else if (cbshowmatkhau.Checked == false)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bó tay! Chưa biết làm cái này! :))", "Chia buồn");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
