using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_Bill
    {
        private readonly PBL3_EF db = new PBL3_EF();

        public List<Bill> GetAll()
        {
            return db.Bills.ToList();
        }

        public List<Bill> GetByDateRange(DateTime from, DateTime to)
        {
            return db.Bills
                     .Where(b => b.Date >= from && b.Date <= to)
                     .ToList();
        }

        public void DeleteBill(int billId)
        {
            var bill = db.Bills.Find(billId);
            if (bill != null)
            {
                // Xoá cả chi tiết hóa đơn nếu có
                var details = db.BillDetails.Where(d => d.BillID == billId);
                db.BillDetails.RemoveRange(details);
                db.Bills.Remove(bill);
                db.SaveChanges();
            }
        }
        public Bill GetBillWithDetails(int billId)
        {
            return db.Bills
                     .Include("Customer")
                     .Include("Pitch")
                     .Include("BillDetails.Drink")
                     .FirstOrDefault(b => b.BillID == billId);
        }
    }
}
