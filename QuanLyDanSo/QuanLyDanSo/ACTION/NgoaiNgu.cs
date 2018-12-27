using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyDanSo.ACTION
{
    public class NgoaiNgu
    {
        private static NgoaiNgu instance;

        public static NgoaiNgu Instance
        {
            get { if (instance == null) instance = new NgoaiNgu(); return instance; }
            private set { instance = value; }
        }
        private NgoaiNgu() { }

        public DataTable ShowListNgoaiNgu()
        {
            string query = "EXEC dbo.SP_SHOWNGOAINGU";
            return Database.Instance.ThucThiLenh(query);
           
        }
        public DataTable ShowListMaNgoaiNgu()
        {
            string query = "EXEC dbo.SP_SHOWMANGOAINGU";
            return Database.Instance.ThucThiLenh(query);

        }
        public bool AddNgoaiNgu (string MaNgoaiNgu, string NgoaiNgu)
        {
            string query = string.Format("EXEC SP_ThemNgoaiNguMoi @MaNgoaiNgu= N'{0}' ,@NgoaiNgu = N'{1}'", MaNgoaiNgu, NgoaiNgu);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool DeleteNgoaiNgu (string MaNgoaiNgu)
        {
            string query = string.Format("EXEC dbo.SP_XoaNgoaiNgu  @MaNgoaiNgu = N'{0}'", MaNgoaiNgu);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool SuaNgoaiNgu (string MaNgoaiNgu, string NgoaiNgu)
        {
            string query = string.Format("EXEC dbo.SP_SuaThongTinNgoaiNgu @MaNgoaiNgu = N'{0}', @TenNgoaiNgu = N'{1}'", MaNgoaiNgu, NgoaiNgu);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

    }
}
