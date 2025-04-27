using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL
    {
        _DAL dal = new _DAL();

        public Account Login(string username, string password)
        {
            return dal.GetAccount(username, password);
        }
    }
}
