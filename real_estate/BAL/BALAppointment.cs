using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class BALAppointment
    {
        public List<appointment> GetAllAppo()
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                return dbs.appo_GetAllAppo().ToList();
            }
        }
        public void CreateAppo(string description, string status, string id_cus, DateTime appointment_date)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.AppoCreate(description, status, id_cus, appointment_date);
            }
        }
        public void UpdateAppo(int id, string description,string status,string id_cus, DateTime appointment_date)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.AppointmentUpdate(id, description, status, id_cus, appointment_date);
            }
        }
        public void DeleteAppo(int id)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.DeleteAppo(id);
            }
        }
    }
}
