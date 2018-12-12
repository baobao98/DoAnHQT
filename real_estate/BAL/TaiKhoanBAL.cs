using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;
namespace BAL
{
    public class TaiKhoanBAL
    {
        // CRUD loại tài khoản
        public static List<typeAccount> GetAllTypeAcc()
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                return dbs.spGetAllTypeAcc().ToList();
            }

        }
        public static void DelTypeAcc(int id)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.spDelTypeAcc(id);
            }
        }
        public static void UpTypeAcc(int id, string name)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.spUpdateTypeAcc(id, name);
            }
        }
        public static void InsertTypeAcc(string name)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.spInsertTypeAcc(name);
            }
        }
        public static int Kttk(int id)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                var tk = dbs.typeAccounts
                .Where(p => p.id == id).Count();
                return tk;
            }
            
        }
        // CRUD tài khoản 
        public static List<account> GetAllAcc()
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                return dbs.accounts.ToList();
            }
        }
        public static void InsertAcc(string name,int type, string pass)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                //dbs.accounts.Add(acc);
                //dbs.SaveChanges();
                dbs.spInsertAcc(name, type, pass);
            }
        }
        public static void UpdateAcc( account acc)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.accounts.Attach(acc);
                dbs.SaveChanges();
                dbs.Entry(acc).State = System.Data.Entity.EntityState.Modified;
                dbs.SaveChanges();
            }
        }
        public static void DelAcc(account acc)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.accounts.Remove(acc);
            }
        }
        //public static List< CheckAcc(string acc, string pass)
        //{
        //    using (RealEstateEntities dbs = new RealEstateEntities())
        //    {
        //        int a = Convert.ToInt32(dbs.sp_checktaikhoan(acc, pass));
        //        return a;
        //    }
        //}
        public static account GetAccountByAcc(string acc)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                return dbs.accounts.SingleOrDefault(a => a.nameAcc == acc);
            }
        }

    }
}
