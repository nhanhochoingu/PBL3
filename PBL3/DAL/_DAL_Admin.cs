using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class _DAL_Admin
    {
        private readonly PBL3_EF db = new PBL3_EF();
        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var existing = db.Customers.Find(customer.CustomerID);
            if (existing != null)
            {
                existing.Name = customer.Name;
                existing.PhoneNumber = customer.PhoneNumber;
                existing.Email = customer.Email;
                db.SaveChanges();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = db.Customers.Find(customerId);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

    }
}
