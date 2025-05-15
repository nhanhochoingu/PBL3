using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Account
    {
        _DAL_Account dal = new _DAL_Account();
        public void RegisterAccount(Account acc)
        {
            dal.AddAccount(acc);
        }

        public bool IsUsernameTaken(string username)
        {
            return dal.UsernameExists(username);
        }

        public int GetLastUserID()
        {
            return dal.GetLatestUserID();
        }
    }

}
