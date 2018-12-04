﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class BALCustomer
    {

        public List<customer> GetCustomer()
        {
            using(RealEstateEntities dbs = new RealEstateEntities())
            return dbs.GetAllCustomer().ToList();
        }
       

        public void CreateCustomer(string name_cus, string email_cus, string phone_cus, DateTime birthday )
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.CustomerCreate(null, name_cus, email_cus, phone_cus, birthday, null);
            }

        
        }
        //public void UpdateCustomer(string id_cus,string name_cus, string email_cus, string phone_cus, DateTime birthday)
        //{
        //    using (RealEstateEntities dbs = new RealEstateEntities())
        //    {
        //        dbs.UpdateCustomer(id_cus, name_cus, email_cus, phone_cus, birthday, null);
        //    } 
        //}
        public void DeleteCustomer(string id_cus)
        {
            using (RealEstateEntities dbs = new RealEstateEntities())
            {
                dbs.CustomerDelete(id_cus);
            }
        }
    }
}
