using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyDanSo.ACTION
{
    class ChiTietPhieuDiChuyen
    {
        private static ChiTietPhieuDiChuyen instance;

        public static ChiTietPhieuDiChuyen Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuDiChuyen(); return ChiTietPhieuDiChuyen.instance; }
            private set { instance = value; }
        }
        private ChiTietPhieuDiChuyen() { }

        public DataTable ShowChiTietPhieuDiChuyen()
        {
            string query = "EXEC dbo.SP_ShowCTDiChuyen";
            return Database.Instance.ThucThiLenh(query);

        }
        public DataTable ShowSoPhieuDiChuyen()
        {
            string query = "EXEC dbo.SP_ShowSoPhieuDiChuyen";
            return Database.Instance.ThucThiLenh(query);

        }

        public DataTable ShowMaNhanKhau()
        {
            string query = "EXEC dbo.SP_ShowMaNhanKhau";
            return Database.Instance.ThucThiLenh(query);

        }


        public bool AddChiTietPhieuDiChuyen(int sophieu, int stt, int mank)
        {
            string query = string.Format("EXEC dbo.SP_AddCTPhieuDiChuyen @sophieu ='{0}' ,@stt ='{1}', @manhankhau ='{2}'", sophieu, stt, mank);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool DeleteChiTietPhieuDiChuyen(int sophieu)
        {
            string query = string.Format("EXEC dbo.SP_DeleteCTDiChuyen  @SoPhieu = '{0}'", sophieu);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool SuaChiTietPhieuDiChuyen(int sophieu, int stt, int mank)
        {
            string query = string.Format("EXEC dbo.SP_UpdateCTDiChuyen @maso ='{0}' ,@stt ='{1}', @manhankhau ='{2}'", sophieu, stt, mank);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }
    }
}
