using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_BillDetail
    {
        private _DAL_BillDetail dal = new _DAL_BillDetail();
        public List<object> GetDrinkStats()
        {
            return dal.GetDrinkUsageStatistics();
        }
    }
}
