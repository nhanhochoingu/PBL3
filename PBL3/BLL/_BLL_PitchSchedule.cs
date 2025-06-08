using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class _BLL_PitchSchedule
    {
        private _DAL_PitchSchedule dal = new _DAL_PitchSchedule();
        public List<PitchSchedule> GetSchedulesByDate(DateTime date)
        {
            return dal.GetAllBooked(date);
        }
        public void DeleteBooking(int scheduleId)
        {
            dal.DeleteBooking(scheduleId);
        }
        public List<object> GetPitchBookingStats()
        {
            return dal.GetPitchBookingStatistics();
        }
        public List<object> GetDisplayScheduleByDate(DateTime date)
        {
            var list = dal.GetAllBooked(date);

            var result = list.Select(p => new
            {
                p.ScheduleID,
                PitchName = p.Pitch?.PitchName ?? "",
                CustomerName = p.Customer?.Name ?? "",
                Date = p.Date,
                StartTime = p.StartTime,
                EndTime = p.EndTime,
                p.Status
            }).ToList<object>(); 

            return result;
        }


    }
}
