using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class KetnoiCSDL
    {
        public static readonly string ConnectionString = @"Data Source=CHIENHO\SQLEXPRESS;Initial Catalog=CellPhone;Integrated Security=True";
        public static SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public static DataTable dt;

        //Không cần kết nối
        public static void ThucThiSql(string sqlCommand)
        {
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, sqlCon);
            da.Fill(dt);
        }

        public static DataTable DocDL(string sqlCommand)
        {
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, sqlCon);
            da.Fill(dt);
            return dt;
        }

        //Cần kết nối
        public void KetNoi()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        public void DongKn()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        public void ThucThiSql2(string sqlCommand)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(sqlCommand, sqlCon);
            cmd.ExecuteNonQuery();
            DongKn();
        }
    }
}
