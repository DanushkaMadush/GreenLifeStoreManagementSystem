using GreenLifeStoreManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeStoreManagementSystem.Models
{
    public class Customer : User
    {
        public Customer() : base()
        {
        }

        public static List<Customer> GetAllCustomers()
        {
            CustomerRepository repo = new CustomerRepository();
            return repo.GetAllCustomers();
        }
    }
}
