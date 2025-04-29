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
        private readonly PBL3_EF db = new PBL3_EF();
        public Account GetAccount(string username, string password)
        {
            return db.Accounts
                  .FirstOrDefault(a => a.Username.Trim().ToLower() == username.ToLower()
                                    && a.Password.Trim() == password);
        }
        public Customer GetCustomerByUserID(int userId)
        {
            return db.Customers
                     .Include("Account") // Nạp navigation property
                     .FirstOrDefault(c => c.UserID == userId);
        }

        public bool UpdateCustomerInfo(int userId, string name, string phone, string email, string username, string password)
        {
            var customer = db.Customers.Include("Account")
                              .FirstOrDefault(c => c.UserID == userId);

            if (customer == null) return false;

            customer.Name = name;
            customer.PhoneNumber = phone;
            customer.Email = email;

            if (customer.Account != null)
            {
                customer.Account.Username = username;
                customer.Account.Password = password;
            }

            db.SaveChanges();
            return true;
        }

    }
}
