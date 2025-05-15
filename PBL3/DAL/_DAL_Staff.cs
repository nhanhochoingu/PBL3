using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_Staff
    {
        private readonly PBL3_EF db = new PBL3_EF();

        public List<Staff> GetAllStaff()
        {
            return db.Staffs.ToList();
        }
        public bool DeleteStaff(int staffId)
        {
            var staff = db.Staffs.FirstOrDefault(s => s.StaffID == staffId);
            if (staff != null)
            {
                db.Staffs.Remove(staff);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateStaff(Staff s)
        {
            var staff = db.Staffs.FirstOrDefault(x => x.StaffID == s.StaffID);
            if (staff != null)
            {
                staff.StaffName = s.StaffName;
                staff.StaffSDT = s.StaffSDT;
                staff.StaffEmail = s.StaffEmail;
                staff.Coefficient = s.Coefficient;
                staff.Worktime = s.Worktime;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool AddStaff(Staff staff)
        {
            try
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
