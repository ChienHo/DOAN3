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
    public class NhaCCBLL
    {
        DataClassesCellPhoneSDataContext NCC = new DataClassesCellPhoneSDataContext();
        public List<NhaCC> NhaCungC()
        { 
            return NCC.NhaCCs.ToList();
        }
        // Them Nha CC
        public void ThemNCC(string IdNCC, string TenNCC, string SDT, string DiaChi)
        {
            NCC.NhaCCs.InsertOnSubmit(new NhaCC
            {
                IdNCC = IdNCC,
                TenNCC = TenNCC,
                SDT = SDT,
                DiaChi=DiaChi
            });
            NCC.SubmitChanges();
        }
        public List<NhaCC> SelectAll()
        {
            return NCC.NhaCCs.OrderByDescending(p => p.IdNCC).Take(7).ToList();
        }
    }
}
