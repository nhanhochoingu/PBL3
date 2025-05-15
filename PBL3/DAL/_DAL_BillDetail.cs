using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_BillDetail
    {
        private readonly PBL3_EF db = new PBL3_EF();
        public List<object> GetDrinkUsageStatistics()
        {
            return db.BillDetails
                .GroupBy(d => d.Drink.DrinkName)
                .Select(g => new
                {
                    TenNuoc = g.Key,
                    SoLuongBan = g.Sum(x => x.Quantity)
                })
                .ToList<object>();
        }

    }
}
