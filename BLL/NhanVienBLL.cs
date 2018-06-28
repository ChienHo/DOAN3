using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class NhanVienBLL
    {
        DataClassesCellPhoneSDataContext NV = new DataClassesCellPhoneSDataContext();
        DangNhapDAL DN = new DangNhapDAL();
        public List<NhanVien> SelectCartAll()
        {
            return NV.NhanViens.ToList();
        }
        // xóa danh sách
        public void XoaNV(string uid)
        {
            var Ma = NV.NhanViens.SingleOrDefault(u => u.IdNV == uid);
            NV.NhanViens.DeleteOnSubmit(Ma);
            NV.SubmitChanges();
        }
        //thêm bản ghi mới
        public void ThemNV(string IdNV, string TenNV, string ChucVu, String GioiTinh, DateTime NgaySinh, string DiaChi, string SDT, String Email, string Username, string password, string status, string ID)
        {
            NV.NhanViens.InsertOnSubmit(new NhanVien
            {
                IdNV = IdNV,
                TenNV = TenNV,
                ChucVu = ChucVu,
                GioiTinh = GioiTinh,
                NgaySinh = NgaySinh,
                DiaChi = DiaChi,
                SDT = SDT,
                Email = Email,
                username = Username,
                password = password,
                status = status,
                ID = ID
            });
            NV.SubmitChanges();
        }
        //Sửa
        public void SuaNV(string IdNV, string TenNV, string ChucVu, String GioiTinh, DateTime NgaySinh, string DiaChi, string SDT, String Email, string Username, string password, string status, string ID)
        {
            var ma = NV.NhanViens.SingleOrDefault(u => u.IdNV == IdNV);
            ma.IdNV = IdNV;
            ma.TenNV = TenNV;
            ma.ChucVu = ChucVu;
            ma.GioiTinh = GioiTinh;
            ma.DiaChi = DiaChi;
            ma.SDT = SDT;
            ma.Email = Email;
            ma.username = Username;
            ma.password = password;
            ma.status = status;
            ma.ID = ID;
            NV.SubmitChanges();
        }
        public List<NhanVien> SelectAll()
        {
            return NV.NhanViens.OrderByDescending(p => p.IdNV).Take(8).ToList();
        }
        public bool CheckLogin(string username, string password)
        {
            DataTable dt =DN.SelectLogin(username, password);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
