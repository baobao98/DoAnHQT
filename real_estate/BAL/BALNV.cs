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
        public System.Data.Entity.Core.Objects.ObjectResult<getEmployee_Result> getEmployees()
        {
            return dbs.getEmployee();
        }
        public void addEmployee(string name, string email, string phone, DateTime birthday, string acc)
        {
            dbs.addEmployee(name, email, phone, birthday, acc);
        }
        public void updateEmployee(string id, string name, string email, string phone, DateTime birthday)
        {
            dbs.editEmployee(id, name, email, phone, birthday);
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
