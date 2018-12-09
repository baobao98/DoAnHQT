using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BAL
{
    public class BALNV
    {
        RealEstateEntities dbs = new RealEstateEntities();
        public DataTable getEmployee()
        {
            var eps = from p in dbs.employees join c in dbs.accounts on p.account equals c.id select new { p.id_emp, p.name_emp, p.email_emp, p.phone_emp, p.create_date, p.birthday, c.nameAcc };
            DataTable dt = new DataTable();
            dt.Columns.Add("id_emp");
            dt.Columns.Add("name_emp");
            dt.Columns.Add("email_emp");
            dt.Columns.Add("phone_emp");
            dt.Columns.Add("create_date");
            dt.Columns.Add("birthday");
            dt.Columns.Add("nameAcc");
            foreach (var p in eps)
            {
                dt.Rows.Add(p.id_emp, p.name_emp, p.email_emp, p.phone_emp, p.create_date, p.birthday, p.nameAcc);
            }
            return dt;
        }
        public System.Data.Entity.Core.Objects.ObjectResult<getEmployees_Result> getAll()
        {
            return dbs.getEmployees();
        }
        //public bool addEmployee(string id, string name, string email, string phone, string birthday, string date)
        //{
        //    employee em = new employee();
        //    em.id_emp = id;
        //    em.name_emp = name;
        //    em.email_emp = email;
        //    em.phone_emp = phone;
        //    em.create_date = Convert.ToDateTime(date);
        //    em.birthday = Convert.ToDateTime(birthday);
        //    dbs.employees.Add(em);
        //    dbs.SaveChanges();
        //    return true;
        //}
        public void addEmployee(string name, string email, string phone, DateTime birthday, string acc)
        {
            //getEmployee em = new employee();
            dbs.addEmployee(name, email, phone, birthday, acc);
            //return true;
        }
        //public bool updateEmployee(string id, string name, string email, string phone, DateTime birthday)
        //{
        //    //int x = Convert.ToInt32(id);
        //    var eps = (from p in dbs.employees where p.id_emp == id select p).SingleOrDefault();
        //    if (eps != null)
        //    {
        //        eps.name_emp = name;
        //        eps.email_emp = email;
        //        eps.phone_emp = phone;
        //        eps.birthday = birthday;
        //        dbs.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}
        public void updateEmployee(string id, string name, string email, string phone, DateTime birthday)
        {
            dbs.aditEmployee(id, name, email, phone, birthday);
            //dbs.editEmployee(id, name, email, phone, birthday);
        }
        public void deleteEmployee(string id)
        {
            dbs.deleteEmployee(id);
        }
        public System.Data.Entity.Core.Objects.ObjectResult<searchEmployee_Result> searchEmployee(string idname)
        {
            return dbs.searchEmployee(idname);
        }
    }
}
