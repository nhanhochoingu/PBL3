using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Customer
    {
        _DAL_Customer dal = new _DAL_Customer();

        public Account Login(string username, string password)
        {
            return dal.GetAccount(username, password);
        }
        public Customer GetCustomerInfo(int userId)
        {
            return dal.GetCustomerByUserID(userId);
        }
        public bool UpdateCustomerInfo(int userId, string name, string phone, string email, string username, string password)
        {
            return dal.UpdateCustomerInfo(userId, name, phone, email, username, password);
        }
        public List<object> GetAllPitch()
        {
            return dal.GetAll()
            .Select(s => new
            {
                s.PitchID,
                s.PitchName,
                s.PitchType,
                s.PitchStatus,
                s.PitchPrice,
            }).ToList<object>();
        }

        public bool BookPitch(String type, DateTime date, TimeSpan start, TimeSpan end, int customerID)
        {
            var pitch = dal.GetAvailablePitch(type, date, start, end);
            if (pitch == null) return false;

            PitchSchedule ps = new PitchSchedule
            {
                PitchID = pitch.PitchID,
                CustomerID = customerID,
                Date = date,
                StartTime = start,
                EndTime = end,
                Status = "Đã đặt"
            };

            return dal.AddPitchSchedule(ps);
        }
        public List<Pitch> GetAvailablePitches(string type, DateTime date, TimeSpan start, TimeSpan end)
        {
            var all = dal.GetAllPitchesByType(type); // Tất cả sân cùng loại
            var booked = dal.GetBookedPitches(type, date, start, end); // Những sân đã đặt

            return all.Where(p => !booked.Any(b => b.PitchID == p.PitchID)).ToList();
        }

        public bool BookSpecificPitch(int pitchID, int customerID, DateTime date, TimeSpan start, TimeSpan end)
        {
            PitchSchedule ps = new PitchSchedule
            {
                PitchID = pitchID,
                CustomerID = customerID,
                Date = date,
                StartTime = start,
                EndTime = end,
                Status = "Đã đặt"
            };
            return dal.AddPitchSchedule(ps);
        }


        public List<Pitch> GetAllPitchesByType(string type)
        {
            return dal.GetAllPitchesByType(type);
        }

        public List<Pitch> GetBookedPitches(string type, DateTime date, TimeSpan start, TimeSpan end)
        {
            return dal.GetBookedPitches(type, date, start, end);
        }
        public List<Drink> GetAllDrinks()
        {
            return dal.GetAllDrinks();
        }
        public void CreateBillWithDetails(int customerId, int pitchId, DateTime date, decimal total, List<(int drinkId, int quantity, decimal price)> drinks)
        {
            Bill bill = new Bill
            {
                CustomerID = customerId,
                PitchID = pitchId,
                Date = date,
                Total = total
            };

            List<BillDetail> details = drinks.Select(d => new BillDetail
            {
                DrinkID = d.drinkId,
                Quantity = d.quantity,
                UnitPrice = d.price
            }).ToList();

            dal.SaveBill(bill, details);
        }
        public List<dynamic> GetLichSanDaDat(int customerId)
        {
            return dal.GetLichSanDaDat(customerId);
        }
        public List<object> GetBillsByCustomer(int customerId)
        {
            return dal.GetBillsByCustomer(customerId);
        }
        public void RegisterCustomer(Customer cus)
        {
            dal.AddCustomer(cus);
        }







    }
}
