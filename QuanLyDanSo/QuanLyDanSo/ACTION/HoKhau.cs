using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanSo.ACTION
{
    public class HoKhau
    {
        private static HoKhau instance;
        public static HoKhau Instance
        {
            get { if (instance == null) instance = new HoKhau(); return instance; }
            private set { instance = value; }
        }
        private HoKhau() { }

        public DataTable LoadHoKhau()
        {
            string lenhThucThi = "EXEC dbo.SP_ShowHoKhau";
            return Database.Instance.ThucThiLenh(lenhThucThi);
        }

        public DataTable LoadDanhSachSoHoKhau()
        {
            string lenhThucThi = "EXEC dbo.SP_ShowDSHoKhau";
            return Database.Instance.ThucThiLenh(lenhThucThi);
        }
        // Các form khác có cấu trúc Load danh sách như trên, chỉ thay đổi query
        public bool ThemHoKhau(int soHoKhau, string diaChi, int maPhuong)
        {
            string lenhThucThi = string.Format("EXEC dbo.SP_AddHoKhau @SoSO = {0}, @Diachi = N'{1}', @MaPhuong = {2}", soHoKhau, diaChi, maPhuong);
            int result = Database.Instance.KiemTraLenhThucThi(lenhThucThi);
            return result > 0;
        }

        public bool XoaHoKhau (int sohokhau)
        {
            string lenhthucthi = string.Format("EXEC dbo.SP_DeleteHoKhau @SoSo = '{0}'", sohokhau);
            int result = Database.Instance.KiemTraLenhThucThi(lenhthucthi);
            return result > 0;

        }

        public bool SuathongtinHoKhau (int sohokhau, string diachi, int maphuong)
        {
            string query = string.Format("EXEC dbo.SP_SuaThongTinHoKhau @SoSo = '{0}', @DiaChi = N'{1}', @MaPhuong ='{2}'", sohokhau, diachi,maphuong);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;

        }
        // Lệnh Sửa + Xóa như trên, chỉ thay đổi biến khai báo cần dùng và câu lệnh thực thi
    }
}
