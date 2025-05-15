using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_PitchSchedule
    {
        private readonly PBL3_EF db = new PBL3_EF();
        public List<PitchSchedule> GetAllBooked(DateTime date)
        {
            return db.PitchSchedules
             .Include(p => p.Pitch)
             .Include(p => p.Customer)
             .Where(p => DbFunctions.TruncateTime(p.Date) == date.Date)
             .ToList();
        }
        public void DeleteBooking(int scheduleId)
        {
            var s = db.PitchSchedules.Find(scheduleId);
            if (s != null)
            {
                db.PitchSchedules.Remove(s);
                db.SaveChanges();
            }
        }
        public List<object> GetPitchBookingStatistics()
        {
            return db.PitchSchedules
                .GroupBy(p => new { p.Pitch.PitchName, p.Pitch.PitchType })
                .Select(g => new
                {
                    TenSan = g.Key.PitchName,
                    LoaiSan = g.Key.PitchType,
                    SoLuotDat = g.Count()
                })
                .ToList<object>();
        }

    }
}
