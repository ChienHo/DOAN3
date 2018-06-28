using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class DangNhapDAL
    {

        public DataTable SelectLogin(string username, string password)
        {
            return KetnoiCSDL.DocDL("SELECT * FROM NhanVien WHERE Username='" + username + "' AND Password='" + password + "' AND (ID='Q01' OR ID='Q02')");
        }

    }
}
