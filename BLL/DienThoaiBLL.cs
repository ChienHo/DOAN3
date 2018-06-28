using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class DienThoaiBLL
    {
        DataClassesCellPhoneSDataContext DT = new DataClassesCellPhoneSDataContext();
        public List<DienThoai> DienThoai()
        {
            return DT.DienThoais.ToList();
        }
        public void ThemDT(string IdDT, string TenDT, string IdL, string mau, int SL, int giaNhap, int giaBan, string Anh, string Network, string Sim, string ManH, string Ram, String SD, string Cpu, string camera, string pin, int TalkT, int waitT)

        {
            DT.DienThoais.InsertOnSubmit(new DienThoai
            {

                IdDT = IdDT,
                TenDT = TenDT,
                IdL = IdL,
                Mau = mau,
                SoLuong = SL,
                GiaNhap = giaNhap,
                GiaBan = giaBan,
                Anh = Anh,
                Network = Network,
                SIM = Sim,
                ManHinh = ManH,
                RAM = Ram,
                SDcard = SD,
                CPU = Cpu,
                Camera = camera,
                Pin = pin,
                Talktime = TalkT,
                WaitTime = waitT
            }
                );
            DT.SubmitChanges();
        }
        public DienThoai SelectById(string id)
        {
            return DT.DienThoais.SingleOrDefault(u => u.IdDT == id);
        }
        public void Sua(int id, string IdDT, string TenDT, string IdL, string mau, int SL, int giaNhap, int giaBan, string Anh, string Network, string Sim, string ManH, string Ram, String SD, string Cpu, string camera, string pin, int TalkT, int waitT)
        {
            var S = DT.DienThoais.SingleOrDefault(u => u.IdDT == IdDT);
            S.IdDT = IdDT;
            S.TenDT = TenDT;
            S.IdL = IdL;
            S.Mau = mau;
            S.SoLuong = SL;
            S.GiaNhap = giaBan;
            S.GiaBan = giaBan;
            S.Anh = Anh;
            S.Network = Network;
            S.SIM = Sim;
            S.ManHinh = ManH;
            S.RAM = Ram;
            S.SDcard = SD;
            S.CPU = Cpu;
            S.Camera = camera;
            S.Pin = pin;
            S.Talktime = TalkT;
            S.WaitTime = waitT;
            DT.SubmitChanges();
        }
        public List<DienThoai> SelectAll()
        {
            return DT.DienThoais.OrderByDescending(p => p.IdDT).Take(8).ToList();
        }
        public List<DienThoai> SelectAlls()
        {
            return DT.DienThoais.OrderByDescending(p => p.IdDT).Take(6).ToList();
        }
        public List<DienThoai> SelectAllss()
        {
            return DT.DienThoais.OrderByDescending(p => p.IdDT).Take(4).ToList();
        }
        public List<DienThoai> ProductDetail(string productid)
        {
            return DT.DienThoais.Where(x => x.IdDT == productid).ToList();
        }
        public List<DienThoai> SanPham(string idSP)
        {
            return DT.DienThoais.Where(x => x.IdL == idSP).ToList();
        }
        public List<LoaiDT> LDT(string id)
        {
            return DT.LoaiDTs.Where(x => x.IdL == id).ToList();
        }
        public DienThoai GetProductByCateId(string productid)
        {
            return DT.DienThoais.SingleOrDefault(p => p.IdDT == productid);
        }

    }
}
