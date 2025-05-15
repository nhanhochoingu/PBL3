using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Drink
    {
        _DAL_Drink dal = new _DAL_Drink();
        public List<Drink> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(Drink drink)
        {
            dal.Add(drink);
        }

        public void Update(Drink drink)
        {
            dal.Update(drink);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }
    }
}
