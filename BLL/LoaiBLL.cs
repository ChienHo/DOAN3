using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class LoaiBLL
    {
        DataClassesCellPhoneSDataContext Loai = new DataClassesCellPhoneSDataContext();
        public List<LoaiDT> LoaiDThoai()
        {
            return Loai.LoaiDTs.ToList();
        }
        //Xóa Loại điện thoại
        public void XoaLoai(string uid)
        {
            var Ma = Loai.LoaiDTs.SingleOrDefault(u => u.IdL == uid);
            Loai.LoaiDTs.DeleteOnSubmit(Ma);
            Loai.SubmitChanges();
        }
        //thêm bản ghi mới
        public void ThemL(string Idl, string TenLoai, int SL)
        {
            Loai.LoaiDTs.InsertOnSubmit(new LoaiDT
            {
                IdL = Idl,
                TenLoai = TenLoai,
                SoLuong = SL
            });
            Loai.SubmitChanges();
        }
        //Sửa
        public void SuaL(string Idl, string TenLoai, int SL)
        {
            var ma = Loai.LoaiDTs.SingleOrDefault(u => u.IdL == Idl);
            ma.IdL = Idl;
            ma.TenLoai = TenLoai;
            ma.SoLuong = SL;
            Loai.SubmitChanges();
        }
       
        public List<LoaiDT> SelectAll()
        {
            return Loai.LoaiDTs.OrderByDescending(p => p.IdL).Take(8).ToList();
        }
    }
}
