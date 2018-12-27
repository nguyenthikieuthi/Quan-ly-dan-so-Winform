using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDanSo.ACTION
{
    public class NhanKhau
    {
        private static NhanKhau instance;

        public static NhanKhau Instance
        {
            get { if (instance == null) instance = new NhanKhau(); return instance; }
            private set { instance = value; }
        }

        private NhanKhau() { }

        //public DataTable LoadNhanKhau()
       // {
        //    string lenhThucThi = "EXEC dbo.SHOW_NhanKhau";
       //     return Database.Instance.ThucThiLenh(lenhThucThi);
       // }
        // Các form khác có cấu trúc Load danh sách như trên, chỉ thay đổi query
        public bool ThemNhanKhau(int mank, String tennk, string phai, string ngaysinh, int cmnd, string mangoaingu, int sohokhau, string matrinhdo, string ghichu) 
        {
            string lenhThucThi = string.Format("EXEC dbo.SP_AddNhanKhau @MaNhanKhau ='{0}'  , @Ten=N'{1}', @Phai=N'{2}' , @Ngaysinh ='{3}', @CMND='{4}' , @MaNgoaiNgu=N'{5}', @SoHoKhau ='{6}', @MaTrinhDo=N'{7}' , @note=N'{8}' ", mank,tennk,phai,ngaysinh,cmnd,mangoaingu,sohokhau,matrinhdo,ghichu);
            int result = Database.Instance.KiemTraLenhThucThi(lenhThucThi);
            return result > 0;
        }

        public bool XoaNhanKhau(int mank)
        {
            string lenhthucthi = string.Format("EXEC dbo.SP_DeleteNhanKhau @MaNhanKhau = '{0}'", mank);
            int result = Database.Instance.KiemTraLenhThucThi(lenhthucthi);
            return result > 0;

        }

        public bool SuathongtinNhanKhau(int mank, string tennk, string phai, string ngaysinh, int cmnd, string mangoaingu, int sohokhau, string matrinhdo, string ghichu)
        {
            string query = string.Format("EXEC dbo.SP_SuaThongTinNhanKhau @MaNhanKhau ='{0}'  , @Ten=N'{1}', @Phai=N'{2}' , @Ngaysinh ='{3}', @CMND='{4}' , @MaNgoaiNgu=N'{5}', @SoHoKhau ='{6}', @MaTrinhDo=N'{7}' , @note=N'{8}' ", mank, tennk, phai, ngaysinh, cmnd, mangoaingu, sohokhau, matrinhdo, ghichu);
            int result = Database.Instance.KiemTraLenhThucThi(query);
            return result > 0;

        }



        #region Old Source
        //public static SqlConnection cnn;
        //public static SqlDataAdapter da;
        //public static SqlCommand cmd;
        //public static DataSet ds;
        //public static DataTable dt;

        //Database db = new Database();

        //public SqlCommand add_NhanKhau(double mank, string tennk, string gioitinh, DateTime ngaysinh, double cmnd, string mangoaingu, double sohokhau, string matrinhdo, string ghichu)
        //{

        //    //cnn = new SqlConnection();
        //    //cnn.Open();
        //    db.open(); //Mở Kết nối
        //    cmd = new SqlCommand("SP_AddNhanKhau", cnn);
        //    cmd.Parameters.Add(new SqlParameter("@MaNhanKhau", mank));
        //    cmd.Parameters.Add(new SqlParameter("@Ten ", tennk));
        //    cmd.Parameters.Add(new SqlParameter("@Phai ", gioitinh));
        //    cmd.Parameters.Add(new SqlParameter("@Ngaysinh ", ngaysinh));
        //    cmd.Parameters.Add(new SqlParameter("@CMND ", cmnd));
        //    cmd.Parameters.Add(new SqlParameter("@MaNgoaiNgu ", mangoaingu));
        //    cmd.Parameters.Add(new SqlParameter("@SoHoKhau ", sohokhau));
        //    cmd.Parameters.Add(new SqlParameter("@MaTrinhDo ", matrinhdo));
        //    cmd.Parameters.Add(new SqlParameter("@note ", ghichu));

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.ExecuteNonQuery();
        //    //cnn.Close();
        //    db.close();
        //    return cmd;

        //}


        //public SqlCommand update_NhanKhau(double mank, string tennk, string gioitinh, DateTime ngaysinh, double cmnd, string mangoaingu, double sohokhau, string matrinhdo, string ghichu)
        //{

        //    cnn = new SqlConnection();
        //    cnn.Open();
        //    //db.open();
        //    cmd = new SqlCommand("SP_SuaThongTinNhanKhau", cnn);
        //    cmd.Parameters.Add(new SqlParameter("@MaNhanKhau", mank));
        //    cmd.Parameters.Add(new SqlParameter("@Ten ", tennk));
        //    cmd.Parameters.Add(new SqlParameter("@Phai ", gioitinh));
        //    cmd.Parameters.Add(new SqlParameter("@Ngaysinh ", ngaysinh));
        //    cmd.Parameters.Add(new SqlParameter("@CMND ", cmnd));
        //    cmd.Parameters.Add(new SqlParameter("@MaNgoaiNgu ", mangoaingu));
        //    cmd.Parameters.Add(new SqlParameter("@SoHoKhau ", sohokhau));
        //    cmd.Parameters.Add(new SqlParameter("@MaTrinhDo ", matrinhdo));
        //    cmd.Parameters.Add(new SqlParameter("@note ", ghichu));

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.ExecuteNonQuery();
        //    cnn.Close();
        //    return cmd;

        //}

        //public SqlCommand delete_NhanKhau(string mank)
        //{
        //    db.open(); //Mở kết nối
        //    cmd = new SqlCommand("SP_DeleteNhanKhau", cnn);
        //    cmd.Parameters.Add(new SqlParameter("@MaNhanKhau", mank));
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.ExecuteNonQuery();
        //    db.close();//đóng kết nối
        //    return cmd;
        //}
        #endregion

        #region New Source
        public DataTable LoadDanhSachNhanKhau()
        {
            string lenhThucThi = "EXEC dbo.SHOW_NhanKhau";
            return Database.Instance.ThucThiLenh(lenhThucThi);
        }
        #endregion
        public DataTable LoadDanhSachGioiTinh()
        {
            string lenhThucThi = "EXEC dbo.SP_ShowGioiTinh";
            return Database.Instance.ThucThiLenh(lenhThucThi);
        }

        public DataTable LoadDanhSachMaTrinhDo()
        {
            string query = "EXEC dbo.SP_ShowTrinhDo";
            return Database.Instance.ThucThiLenh(query);

        }
       
        public DataTable LoadDanhSachMaNgoaiNgu()
        {
            string lenhThucThi = "EXEC dbo.SP_SHOWMANGOAINGU";
            return Database.Instance.ThucThiLenh(lenhThucThi);
        }
    }

}
