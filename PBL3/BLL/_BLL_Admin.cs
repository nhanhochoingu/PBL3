using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class _BLL_Admin
    {
        _DAL_Admin dal = new _DAL_Admin();
        public List<Customer> GetAll()
        {
            return dal.GetAllCustomers();
        }

        public void Add(Customer customer)
        {
            dal.AddCustomer(customer);
        }

        public void Update(Customer customer)
        {
            dal.UpdateCustomer(customer);
        }

        public void Delete(int customerId)
        {
            dal.DeleteCustomer(customerId);
        }
    }
}
