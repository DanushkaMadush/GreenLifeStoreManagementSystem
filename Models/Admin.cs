using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeStoreManagementSystem.Models
{
    using System;

    namespace GreenLifeStoreManagementSystem.Models
    {
        public class Admin : User
        {
            // Default constructor
            public Admin() : base()
            {
                Role = "Admin";
            }

            // Parameterized constructor
            public Admin(string fullName, string username, string password, string email, string phone, string role)
            {
                FullName = fullName;
                Username = username;
                Password = password;
                Email = email;
                Phone = phone;
                Role = role;
            }

            // Additional methods
            public void ManageProducts()
            {
                // Product management logic placeholder
            }

            public void ManageCustomers()
            {
                // Customer management logic placeholder
            }

            public void ManageOrders()
            {
                // Order management logic placeholder
            }
        }
    }

}
