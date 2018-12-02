using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class BALNV
    {
        QLBDSDataContext dbs = new QLBDSDataContext();
        public List<NHAN_VIEN> getAllEmployee()
        {
            return dbs.NHAN_VIENs.ToList();
        }
    }
}
