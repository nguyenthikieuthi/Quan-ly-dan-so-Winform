using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyDanSo.ACTION
{
    class TrinhDo
    {

        private static TrinhDo instance;

        public static TrinhDo Instance
        {
            get { if (instance == null) instance = new TrinhDo(); return instance; }
            private set { instance = value; }
        }
        private TrinhDo() { }

        public DataTable ShowListTrinhDo()
        {
            string query = "EXEC dbo.SP_ShowTrinhDo";
            return Database.Instance.ThucThiLenh(query);

        }

        public DataTable ShowListMaTrinhDo()
        {
            string query = "EXEC dbo.SP_ShowTrinhDo";
            return Database.Instance.ThucThiLenh(query);
        }

        public bool AddTrinhDo(string maTD, string tenTD)
        {
            string query = string.Format("EXEC dbo.SP_AddTrinhDo @MaTrinhDo= N'{0}' ,@TenTrinhDo = N'{1}'", maTD, tenTD);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool DeleteTrinhDo(string MaTrinhDo)
        {
            string query = string.Format("EXEC dbo.SP_DeleteTrinhDo  @MaTrinhDo = '{0}'", MaTrinhDo);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

        public bool SuaTrinhDo(string MaTrinhdo, string TenTrinhDo)
        {
            string query = string.Format("EXEC dbo.SP_SuaThongTinTrinhDo @MaTrinhDo= N'{0}' ,@TenTrinhDo = N'{1}'", MaTrinhdo, TenTrinhDo);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;
        }

    }
}
