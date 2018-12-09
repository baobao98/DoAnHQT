using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using System.Data;
namespace BAL
{
    
    public class BALPROJ
    {
        RealEstateEntities dbs = new RealEstateEntities();
        public System.Data.Entity.Core.Objects.ObjectResult<DAL.getProject_Result> getpro()
        {
            return dbs.getProject();
        }
        public void addProject(string name_project, string address, string license_number, DateTime dateOfIssue, string placeOfIssue, string information)
        {
            dbs.addProject(name_project, address, license_number, dateOfIssue, placeOfIssue, information);
        }
        public void updateProject(string id, string name_project, string address, string license_number, DateTime dateOfIssue,string placeOfIssue, string information)
        {
            dbs.editProject(id, name_project, address, license_number, dateOfIssue, placeOfIssue, information);
        }
        public void deleteProject(string id)
        {
            dbs.deleteProject(id);
        }
    }
}
