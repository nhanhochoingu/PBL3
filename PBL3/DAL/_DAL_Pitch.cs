using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_Pitch
    {
        private readonly PBL3_EF db = new PBL3_EF();
        public List<Pitch> GetAll()
        {
            return db.Pitches.ToList();
        }

        public void Update(Pitch p)
        {
            var pitch = db.Pitches.Find(p.PitchID);
            if (pitch != null)
            {
                pitch.PitchName = p.PitchName;
                pitch.PitchType = p.PitchType;
                pitch.PitchStatus = p.PitchStatus;
                pitch.PitchPrice = p.PitchPrice;
                db.SaveChanges();
            }
        }

        public void Delete(int pitchId)
        {
            var pitch = db.Pitches.Find(pitchId);
            if (pitch != null)
            {
                db.Pitches.Remove(pitch);
                db.SaveChanges();
            }
        }
        public void Add(Pitch p)
        {
                db.Pitches.Add(p);
                db.SaveChanges();
            
        }
    }
}
