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
        public static List<account> LayTK()
        {
            using (RealEstateEntities dbs = new RealEstateEntities() )
            {
                return dbs.accounts.ToList();
            }
        }
    }
}
