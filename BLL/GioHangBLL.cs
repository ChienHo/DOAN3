using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class GioHangBLL
    {
        DataClassesCellPhoneSDataContext GH = new DataClassesCellPhoneSDataContext();

        public void ThemGH(string idCart, string IdC, string IdDT, int SL, int TongTien, DateTime NgayDat)
        {
            GH.GioHangs.InsertOnSubmit(new GioHang
            {
                IdCart = idCart,
                IdC = IdC,
                IdDT = IdDT,
                SoLuong = SL,
                TongTien = TongTien,
                NgayDat = NgayDat
            }
                );
            GH.SubmitChanges();
        }

        public List<GioHang> SelectAll()
        {
            return GH.GioHangs.OrderByDescending(p => p.IdCart).Take(8).ToList();
        }

    }
}
