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
    public class KhachHangBLL
    {
        DataClassesCellPhoneSDataContext KH = new DataClassesCellPhoneSDataContext();
        public List<KhachHang> KhachHang()
        {
            return KH.KhachHangs.ToList();
        }
        //Xóa Khách hàng
        //public void XoaKH(string uiKh)
        //{
        //    var Ma = KH.KhachHangs.SingleOrDefault(u => u.IdC == uiKh);
        //    KH.KhachHangs.DeleteOnSubmit(Ma);
        //    KH.SubmitChanges();
        //}
        //thêm bản ghi mới
        public void ThemKH(string IdKh, string HoTen, String GioiTinh, string SDT, string Email, string DiaChi)
        {
            KH.KhachHangs.InsertOnSubmit(new KhachHang
            {
                IdC = IdKh,
                HoTen = HoTen,
                GioiTinh = GioiTinh,
                SDT = SDT,
                 Email = Email,
                 DiaChi = DiaChi
            });
            KH.SubmitChanges();
        }
        public List<KhachHang> SelectAll()
        {
            return KH.KhachHangs.OrderByDescending(p => p.IdC).Take(8).ToList();
        }
    }
}
