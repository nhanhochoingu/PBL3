using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.DAL
{
    public class _DAL_Customer
    {
        private readonly PBL3_EF db = new PBL3_EF();
        public Account GetAccount(string username, string password)
        {
            return db.Accounts
                  .FirstOrDefault(a => a.Username.Trim().ToLower() == username.ToLower()
                                    && a.Password.Trim() == password);
        }
        public Customer GetCustomerByUserID(int userId)
        {
            return db.Customers
                     .Include("Account") // Nạp navigation property
                     .FirstOrDefault(c => c.UserID == userId);
        }

        public bool UpdateCustomerInfo(int userId, string name, string phone, string email, string username, string password)
        {
            var customer = db.Customers.Include("Account")
                              .FirstOrDefault(c => c.UserID == userId);

            if (customer == null) return false;

            customer.Name = name;
            customer.PhoneNumber = phone;
            customer.Email = email;

            if (customer.Account != null)
            {
                customer.Account.Username = username;
                customer.Account.Password = password;
            }

            db.SaveChanges();
            return true;
        }
        public List<Pitch> GetAll()
        {
            return db.Pitches.ToList();
        }

        // Tìm sân trống
        public Pitch GetAvailablePitch(String type, DateTime date, TimeSpan start, TimeSpan end)
        {
            return db.Pitches
                .Where(p => p.PitchType == type && p.PitchStatus == "Sẵn Sàng")
                .Where(p => !p.PitchSchedules.Any(s =>
                    s.Date == date &&
                    ((s.StartTime <= end && s.EndTime >= start))))
                .FirstOrDefault();
        }
        // Đặt sân mới
        public bool AddPitchSchedule(PitchSchedule ps)
        {
            try
            {
                db.PitchSchedules.Add(ps);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Pitch> GetAllPitchesByType(string type)
        {
            return db.Pitches.Where(p => p.PitchType == type && p.PitchStatus == "Sẵn Sàng").ToList();
        }

        public List<Pitch> GetBookedPitches(string type, DateTime date, TimeSpan start, TimeSpan end)
        {
            return db.PitchSchedules
                .Where(ps => ps.Date == date &&
                             ps.Pitch.PitchType == type &&
                            ((ps.StartTime < end && ps.EndTime > start)))
                .Select(ps => ps.Pitch)
                .Distinct()
                .ToList();
        }


        public List<Drink> GetAllDrinks()
        {
            return db.Drinks.ToList();
        }
        public void SaveBill(Bill bill, List<BillDetail> billDetails)
        {
            db.Bills.Add(bill);
            db.SaveChanges(); // lưu để có BillID

            foreach (var detail in billDetails)
            {
                detail.BillID = bill.BillID; // gán BillID vừa tạo
                db.BillDetails.Add(detail);
            }

            db.SaveChanges();
        }
        public List<dynamic> GetLichSanDaDat(int customerId)
        {
            var result = (from ps in db.PitchSchedules
                          join p in db.Pitches on ps.PitchID equals p.PitchID
                          join b in db.Bills on new { ps.CustomerID, ps.PitchID } equals new { b.CustomerID, b.PitchID } into billJoin
                          from b in billJoin.DefaultIfEmpty()
                          join bd in db.BillDetails on b.BillID equals bd.BillID into billDetailJoin
                          from bd in billDetailJoin.DefaultIfEmpty()
                          where ps.CustomerID == customerId
                          group new { ps, p, b, bd } by new
                          {
                              ps.ScheduleID,
                              p.PitchName,
                              p.PitchType,
                              ps.Date,
                              ps.StartTime,
                              ps.EndTime,
                              p.PitchPrice
                          }
                          into g
                          select new
                          {
                              g.Key.PitchName,
                              g.Key.PitchType,
                              g.Key.Date,
                              g.Key.StartTime,
                              g.Key.EndTime,
                              g.Key.PitchPrice,
                              TongTien = g.Key.PitchPrice + g.Sum(x => (x.bd != null ? x.bd.Quantity * x.bd.UnitPrice : 0))
                          }).ToList<dynamic>();

            return result;
        }
        public List<object> GetBillsByCustomer(int customerId)
        {
            return db.Bills
                .Where(b => b.CustomerID == customerId)
                .OrderByDescending(b => b.Date)
                .Select(b => new
                {
                    b.BillID,
                    b.Date,
                    PitchName = b.Pitch.PitchName,
                    b.Total
                })
                .ToList<object>();
        }
        public void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }









    }
}
