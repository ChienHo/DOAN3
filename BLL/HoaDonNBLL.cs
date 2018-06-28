using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public class HoaDonNBLL
    {
        DataClassesCellPhoneSDataContext HDN = new DataClassesCellPhoneSDataContext();
        public List<HoaDonN> HDNhap()
        {
            return HDN.HoaDonNs.ToList();
        }
        public void ThemHDN(string IdN, DateTime NgayN, int SL, int TT)
        {
            HDN.HoaDonNs.InsertOnSubmit(new HoaDonN
            {
                IdHDN = IdN,
                NgayNhap = NgayN,
                SoLuong = SL,
                TongTien = TT
            });
            HDN.SubmitChanges();
        }
        public List<HoaDonN> SelectAll()
        {
            return HDN.HoaDonNs.OrderByDescending(p => p.IdHDN).Take(8).ToList();
        }
    }
}
