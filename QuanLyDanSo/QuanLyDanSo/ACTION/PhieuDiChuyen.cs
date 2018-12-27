using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyDanSo.ACTION
{
    class PhieuDiChuyen
    {
        private static PhieuDiChuyen instance;

        public static PhieuDiChuyen Instance
        {
            get { if (instance == null) instance = new PhieuDiChuyen(); return instance; }
            private set { instance = value; }
        }
        private PhieuDiChuyen() { }

        public DataTable ShowPhieuDiChuyen()
        {
            string query = "EXEC dbo.SP_ShowPhieuDiChuyen";
            return Database.Instance.ThucThiLenh(query);

        }
     

        public bool AddPhieuDiChuyen(int sophieu,string ngaylapphieu, string noiden)
        {
            string query = string.Format("EXEC dbo.SP_AddPhieuDiChuyen @sophieu ='{0}' , @ngay ='{1}' , @noiden =N'{2}'",sophieu,ngaylapphieu,noiden);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool DeletePhieuDiChuyen(int sophieu)
        {
            string query = string.Format("EXEC dbo.SP_DeleteDiChuyen @maso = '{0}'", sophieu);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool SuaPhieuDiChuyen(int sophieu,string ngaylapphieu, string noiden)
        {
            string query = string.Format("EXEC dbo.SP_UpdateDiChuyen @maso ='{0}' , @ngay ='{1}' , @diachi =N'{2}'", sophieu, ngaylapphieu, noiden);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }
    }
}
