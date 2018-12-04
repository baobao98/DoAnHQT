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
    }
}
