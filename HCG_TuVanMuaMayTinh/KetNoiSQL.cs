using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HCG_TuVanMuaMayTinh
{
    public class KetNoiSQL
    {
        private SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TUVANMAYTINH;Integrated Security=True");
        private SqlCommand cmd;

        public DataTable layDLTuBang(string table)
        {
            DataTable t = new DataTable();

            string sql = "select * from " + table;
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            if (da == null)
            {
                throw new Exception("Sai cấu hình CSDL! \nVui lòng xem Trợ Giúp trên thanh menu!");
            }
            else
            {
                da.Fill(t);
                return t;
            }
        }
        public DataTable truyVanSQL(string sql)
        {

            DataTable t = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            if (da == null)
            {
                throw new Exception("Sai cấu hình CSDL! \nVui lòng xem Trợ Giúp trên thanh menu!");
            }
            else
            {
                da.Fill(t);
                return t;
            }

        }
        public void thucThiSQL(string sql, Luat l)
        {
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("a", l.Age);
            cmd.Parameters.AddWithValue("s", l.Sex);
            cmd.Parameters.AddWithValue("i", l.Income);
            cmd.Parameters.AddWithValue("c", l.Configuration);
            cmd.Parameters.AddWithValue("m", l.Manufacturers);
            cmd.Parameters.AddWithValue("o", l.OS);
            cmd.Parameters.AddWithValue("b", l.Buy);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void xoaSuaTimKiemDL(string sql, Luat l)
        {
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("a", l.Age);
            cmd.Parameters.AddWithValue("s", l.Sex);
            cmd.Parameters.AddWithValue("i", l.Income);
            cmd.Parameters.AddWithValue("c", l.Configuration);
            cmd.Parameters.AddWithValue("m", l.Manufacturers);
            cmd.Parameters.AddWithValue("o", l.OS);
            cmd.Parameters.AddWithValue("b", l.Buy);
            cmd.Parameters.AddWithValue("stt", l.STT);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
