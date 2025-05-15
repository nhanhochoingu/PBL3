using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Pitch
    {
        private _DAL_Pitch dal = new _DAL_Pitch();
        public List<Pitch> GetAllPitch()
        {
            return dal.GetAll();
        }

        public void UpdatePitch(Pitch p)
        {
            dal.Update(p);
        }

        public void DeletePitch(int pitchId)
        {
            dal.Delete(pitchId);
        }
        public void AddPitch(Pitch p)
        {
            dal.Add(p);
        }

    }
}
