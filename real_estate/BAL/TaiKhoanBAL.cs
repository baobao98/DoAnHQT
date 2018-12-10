using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class TaiKhoanBAL
    {
        RealEstateEntities dbs = new RealEstateEntities();
        public System.Data.Entity.DbSet<account> LayTK()
        {
            return dbs.accounts;
        }
        //public List<account> getAll()
        //{
        //    return dbs.typeAccounts.ToList();
        //    //nay do account giong hoi nay~
        //}
        //m dua list type nay len dgv a. uk
        public  List<typeAccount> GetLoaiTK()
        {
            using (RealEstateEntities db = new RealEstateEntities())
            {
                return db.spGetloaiTK().ToList();
            }
               
        }
       
    }
}
