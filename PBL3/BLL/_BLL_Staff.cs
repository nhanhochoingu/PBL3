using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Staff
    {
        private _DAL_Staff dal = new _DAL_Staff();
        public List<Staff> GetAllStaff() => dal.GetAllStaff();
        public bool DeleteStaff(int id) => dal.DeleteStaff(id);
        public bool UpdateStaff(Staff s) => dal.UpdateStaff(s);
        public bool AddStaff(Staff staff)
        {
            return dal.AddStaff(staff);
        }
    }
}
