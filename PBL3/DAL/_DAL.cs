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
        private EF_QLSB db = new EF_QLSB();
        public Account GetAccount(string username, string password)
        {
            return db.Accounts
                  .FirstOrDefault(a => a.Username.Trim().ToLower() == username.ToLower()
                                    && a.Password.Trim() == password);
        }
    }
}
