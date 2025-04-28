using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL
    {
        private PBL3_EF db = new PBL3_EF();
        public Account GetAccount(string username, string password)
        {
            return db.Accounts
                  .FirstOrDefault(a => a.Username.Trim().ToLower() == username.ToLower()
                                    && a.Password.Trim() == password);
        }
    }
}
