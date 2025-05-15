using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Bill
    {
        private _DAL_Bill dal = new _DAL_Bill();
        public List<Bill> GetAll()
        {
            return dal.GetAll();
        }

        public List<Bill> GetByDate(DateTime from, DateTime to)
        {
            return dal.GetByDateRange(from, to);
        }

        public void Delete(int billId)
        {
            dal.DeleteBill(billId);
        }
        public Bill GetBillById(int billId)
        {
            return dal.GetBillWithDetails(billId);
        }
    }
}
