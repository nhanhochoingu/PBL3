using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_Statistic
    {
        private readonly PBL3_EF db = new PBL3_EF();
        public List<Statistic> GetStatisticByDateRange(DateTime startDate, DateTime endDate)
        {
            
                decimal totalRevenue = db.Bills
                    .Where(b => b.Date >= startDate && b.Date <= endDate)
                    .Sum(b => (decimal?)b.Total) ?? 0;


                decimal totalDrinkMoney = db.BillDetails
                    .Where(d => d.Bill.Date >= startDate && d.Bill.Date <= endDate)
                    .Sum(d => (decimal?)(d.Quantity * d.UnitPrice)) ?? 0;

            decimal totalPitchMoney = totalRevenue - totalDrinkMoney;

            int totalBookedPitch = db.Bills
                    .Count(b => b.Date >= startDate && b.Date <= endDate);

                Statistic statistic = new Statistic
                {
                    StartTime = startDate,
                    EndTime = endDate,
                    TotalRevenue = totalRevenue,
                    TotalBookings = totalPitchMoney,
                    TotalDrinksSold = totalDrinkMoney,
                    TotalBookedPitch = totalBookedPitch
                };

                db.Statistics.Add(statistic);
                db.SaveChanges();

                return new List<Statistic> { statistic };
            
        }

    }
}
