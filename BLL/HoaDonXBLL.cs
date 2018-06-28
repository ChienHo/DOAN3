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
    public class HoaDonXBLL
    {
        DataClassesCellPhoneSDataContext HDX = new DataClassesCellPhoneSDataContext();
        public List<HoaDonX> HDXuat()
        {
            return HDX.HoaDonXes.ToList();
        }
        public void ThemHDX(string IdX, DateTime NgayX, int SL, int TT)
        {
            HDX.HoaDonXes.InsertOnSubmit(new HoaDonX
            {
                IdHDX = IdX,
                NgayXuat = NgayX,
                SoLuong = SL,
                TongTien = TT
            });
            HDX.SubmitChanges();
        }
        public List<HoaDonX> SelectAll()
        {
            return HDX.HoaDonXes.OrderByDescending(p => p.IdHDX).Take(8).ToList();
        }
        //public void UpdateHDX(string idhdx, DateTime ngay, int sl, int TongTien)
        //{
          
        //    txtMaSP.Text = sp.MaSP;
        //    DropDownList1.SelectedValue = sp.MaLoai;
        //    txtTenSP.Text = sp.TenSP;
        //    txtGia.Text = sp.Gia.ToString();
        //    txtSL.Text = sp.SL.ToString();
        //    txtMota.Text = sp.Mota;
        //}
    }
}
