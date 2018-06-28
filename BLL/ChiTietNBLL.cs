using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class ChiTietNBLL
    {
        DataClassesCellPhoneSDataContext CTN = new DataClassesCellPhoneSDataContext();
        public List<ChiTietHDN> ChiTietN()
        {
            return CTN.ChiTietHDNs.ToList();
        }
        public void ThemCTN(string IdHDN, string IdDT, string IdNCC, string IdL, int Sl,int TT)
        {
            CTN.ChiTietHDNs.InsertOnSubmit(new ChiTietHDN
            {
                IdHDN = IdHDN,
                IdDT = IdDT,
                IdNCC = IdNCC,
                IdL = IdL,
                TongTien = TT
            });
            CTN.SubmitChanges();
        }
        public List<ChiTietHDN> SelectAll()
        {
            return CTN.ChiTietHDNs.OrderByDescending(p => p.IdHDN).Take(8).ToList();
        }
        public List<ChiTietHDN> LCTN(string id)
        {
            return CTN.ChiTietHDNs.Where(x => x.IdHDN == id).ToList();
        }
    }
}
