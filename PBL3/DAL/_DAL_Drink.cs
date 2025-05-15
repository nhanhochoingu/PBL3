using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_Drink
    {
        private readonly PBL3_EF db = new PBL3_EF();
        public List<Drink> GetAll()
        {
            return db.Drinks.ToList();
        }

        public void Add(Drink drink)
        {
            db.Drinks.Add(drink);
            db.SaveChanges();
        }

        public void Update(Drink drink)
        {
            var d = db.Drinks.Find(drink.DrinkID);
            if (d != null)
            {
                d.DrinkName = drink.DrinkName;
                d.DrinkPrice = drink.DrinkPrice;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var d = db.Drinks.Find(id);
            if (d != null)
            {
                db.Drinks.Remove(d);
                db.SaveChanges();
            }
        }
        


    }
}
