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
    public class QuyenBLL
    {
        DataClassesCellPhoneSDataContext Q = new DataClassesCellPhoneSDataContext();
        public List<Quyen> Quyen()
        {
            return Q.Quyens.ToList();
        }
        //thêm bản ghi mới
        public void ThemQ(string Id, string TenQ, string MoT)
        {
            Q.Quyens.InsertOnSubmit(new Quyen
            {
                ID = Id,
                Tenquyen= TenQ,
                Mota = MoT,
               
            });
            Q.SubmitChanges();
        }
        public List<Quyen> SelectAll()
        {
            return Q.Quyens.OrderByDescending(p => p.ID).Take(8).ToList();
        }
    }
}
