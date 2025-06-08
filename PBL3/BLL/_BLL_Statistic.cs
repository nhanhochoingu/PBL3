using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Statistic
    {
        private _DAL_Statistic dal = new _DAL_Statistic();

        public List<Statistic> GetStatistic(DateTime startDate, DateTime endDate)
        {
            return dal.GetStatisticByDateRange(startDate, endDate);
        }
        public List<object> GetFormattedStatistic(DateTime from, DateTime to)
        {
            var rawList = dal.GetStatisticByDateRange(from, to);

            return rawList.Select(s => new
            {
                s.StartTime,
                s.EndTime,
                s.TotalRevenue,
                s.TotalBookings,
                s.TotalDrinksSold,
                s.TotalBookedPitch
            }).ToList<object>();
        }
    }
}
