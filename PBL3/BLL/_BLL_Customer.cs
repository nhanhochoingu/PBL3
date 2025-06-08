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

        //public List<object> GetLichSanDaDat(int userId)
        //{
        //    var rawList = dal.GetLichSanDaDat(userId);

        //    return rawList.Select(item => new
        //    {
        //        item.ScheduleID,
        //        item.PitchName,
        //        item.PitchType,
        //        item.Date,
        //        item.StartTime,
        //        item.EndTime,
        //        PitchPrice = item.PitchPrice,
        //        TongTien = (GetDurationMinutes(item.StartTime, item.EndTime) == 90
        //                    ? item.PitchPrice * 1.75m
        //                    : item.PitchPrice) + item.TienNuoc
        //    }).ToList<object>();
        //}

        //private int GetDurationMinutes(TimeSpan? start, TimeSpan? end)
        //{
        //    if (start.HasValue && end.HasValue)
        //        return (int)(end.Value - start.Value).TotalMinutes;

        //    return 0;
        //}


        public List<object> GetBillsByCustomer(int customerId)
        {
            return dal.GetBillsByCustomer(customerId);
        }
        public void RegisterCustomer(Customer cus)
        {
            dal.AddCustomer(cus);
        }

        public List<Pitch> GetDisplayPitches(List<Pitch> allPitches, List<Pitch> bookedPitches, int duration)
        {
            return allPitches.Select(p => new Pitch
            {
                PitchID = p.PitchID,
                PitchName = p.PitchName,
                PitchType = p.PitchType,
                PitchStatus = bookedPitches.Any(bp => bp.PitchID == p.PitchID) ? "Đã đặt" : "Trống",
                PitchPrice = (duration == 90) ? (p.PitchPrice ?? 0) * 1.75m : (p.PitchPrice ?? 0)
            }).ToList();
        }

        public List<Drink> GetDrinksForDisplay()
        {
            return dal.GetAllDrinks()
                .Select(d => new Drink
                {
                    DrinkID = d.DrinkID,
                    DrinkName = d.DrinkName,
                    DrinkPrice = d.DrinkPrice ?? 0
                }).ToList();
        }








    }
}
