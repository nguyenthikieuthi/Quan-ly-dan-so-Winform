using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDanSo.ACTION
{
    class Database
    {
        public static string strcnn = @"Data Source=DESKTOP-3HUVNPO;Initial Catalog=QuanLyDanSo;Integrated Security=True";

        #region Old Source
        SqlConnection cnn;
        SqlDataAdapter da;
        SqlCommand cmd;
        //DataSet ds;
        DataTable dt;

        


        public SqlConnection open()
        {
            cnn = new SqlConnection(strcnn);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            return cnn;
        }

        public SqlConnection close()
        {
            cnn = new SqlConnection(strcnn);
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            return cnn;
        }

        public DataTable Truyvan(string sql)
        {
            open();
            dt = new DataTable();
            cmd = new SqlCommand(sql, cnn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        public DataTable Select_proc(string tenproc)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand(tenproc, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;// trả về giá trị 
        }
        #endregion

        private static Database instance; // Một lần chỉ 1 connection đc kết nối tới csdl
        // tại một thời điểm chỉ có duy nhất 1 thể hiện đc tạo ra (câu lệnh thực thi)
        public static Database Instance
        {
            get { if (instance == null) instance = new Database(); return instance; }
            private set => instance = value;
        }

        private Database() { }

        #region New Source
        public DataTable ThucThiLenh(string query, object[] parameter = null)   // <---------------------------------------------------
        {                                                                                                                      //      |
            DataTable data = new DataTable();   // Tạo mới datatable                                                                   |
            using (SqlConnection connection = new SqlConnection(strcnn))    // Khi lệnh thực thi kết thúc --> giải phóng bộ nhớ        |
            {                                                                                                                  //      |
                connection.Open();  // Mở kết nối sql                                                                                  |
                SqlCommand command = new SqlCommand(query, connection); // Thực thi lệnh trong kết nối                                 |           
                                                                                                                              //       |
                // Mỗi parameter truyền vào có dạng @... vd: cmd.Parameters.Add(new SqlParameter("@MaNhanKhau", mank));                |
                // nếu có nhiều trường:                                                                                                |
                if(parameter != null)   //parameter có thể null ------------------------------------------------------------------------
                {
                    string[] listParameter = query.Split(' ');  // list parameter này sẽ chia theo khoảng trắng... Not ','
                    int i = 0;
                    foreach(string item in listParameter)   // cho mỗi item trong list parameter
                    {
                        if (item.Contains('@')) // nếu như item có chứa @ thì nó là parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close(); // Đóng kết nối
            }
            return data;
        }

        public int KiemTraLenhThucThi(string query, object[] parameter = null)  // Kiểm tra xem insert, update, delete có thành công hay không
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(strcnn))
            { 
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)   
                {
                    string[] listParameter = query.Split(' ');  // list parameter này sẽ chia theo khoảng trắng... Not ','
                    int i = 0;
                    foreach (string item in listParameter)   // cho mỗi item trong list parameter
                    {
                        if (item.Contains('@')) // nếu như item có chứa @ thì nó là parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close(); // Đóng kết nối
            }
            return data;    // return về số dòng thực thi thành công
        }

        #endregion



    }
}
