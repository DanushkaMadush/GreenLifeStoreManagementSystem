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
            public Admin(int id, string username, string password, string fullName, string email)
                : base(id, username, password, fullName, email, "Admin")
            {
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
