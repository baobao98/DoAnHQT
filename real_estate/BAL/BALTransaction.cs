using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{

    public class BALTransaction
    {
        RealEstateEntities dbs = new RealEstateEntities();
        public System.Data.Entity.Core.Objects.ObjectResult<getTransaction_Result> getListTrans()
        {
            return dbs.getTransaction();
        }
        public System.Data.Entity.Core.Objects.ObjectResult<getInforTrans_Result> getInforTrans(String id_cus, String id_prop)
        {
            return dbs.getInforTrans(id_cus, id_prop);
        }
        public int updateContact(string id_prop, string phone)
        {
            return dbs.updateStatusContact(id_prop,phone);
        }
        public System.Data.Entity.Core.Objects.ObjectResult<getAddressProp_Result> getAdress(string id_prop)
        {
            return dbs.getAddressProp(id_prop);
        }
        public System.Data.Entity.Core.Objects.ObjectResult<getCustomer_Result> getCustomer(string id_cus)
        {
            return dbs.getCustomer(id_cus);
        }
        public System.Data.Entity.Core.Objects.ObjectResult<getProperty_Result> getProperty(string id_prop)
        {
            return dbs.getProperty(id_prop);
        }
        //public int insertTrans(string id_prop, string id_cus, float amount, string payment)
        //{
        //    return dbs.insertTransaction(id_prop, id_cus, amount, payment);
        //}
        public int spinsertTrans(string id_prop, string id_cus, float amount, string payment)
        {
            return dbs.sp_InsertTrans(id_prop, id_cus, amount,"1", payment);
        }
        public System.Data.Entity.Core.Objects.ObjectResult<getContact_Result> getContact()
        {
            return dbs.getContact();
        }
        public System.Data.Entity.Core.Objects.ObjectResult<sp_searchCusTrans_Result> searcCusTrans(string id_cus)
        {
            return dbs.sp_searchCusTrans(id_cus);
        }
    }
}
