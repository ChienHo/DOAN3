using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class ChiTietXBLL
    {
        DataClassesCellPhoneSDataContext CTX = new DataClassesCellPhoneSDataContext();
        public List<ChiTietHDX> ChiTietX()
        {
            return CTX.ChiTietHDXes.ToList();
        }
        public void ThemCTX(string IdHDX, string IdC, string IdDT, string IdL, int TT)
        {
            CTX.ChiTietHDXes.InsertOnSubmit(new ChiTietHDX
            {
                IdHDX = IdHDX,
                IdC = IdC,
                IdDT = IdDT,
                IdL = IdL,
                TongTien = TT
            });
            CTX.SubmitChanges();
        }
        public List<ChiTietHDX> SelectAll()
        {
            return CTX.ChiTietHDXes.OrderByDescending(p => p.IdHDX).Take(8).ToList();
        }
    }
}
