using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_Account
    {
        private readonly PBL3_EF db = new PBL3_EF();

        public void AddAccount(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public int GetLatestUserID()
        {
            return db.Accounts.OrderByDescending(a => a.UserID).FirstOrDefault()?.UserID ?? 0;
        }

        public bool UsernameExists(string username)
        {
            return db.Accounts.Any(a => a.Username == username);
        }
    }
}
