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
        public class Customer : User
        {
            // Default constructor
            public Customer() : base()
            {
                Role = "Customer";
            }

            // Parameterized constructor
            public Customer(string fullName, string username, string password, string email, string phone, string role)
            {
                FullName = fullName;
                Username = username;
                Password = password;
                Email = email;
                Phone = phone;
                Role = role;
            }

            // Additional methods
            public void PlaceOrder()
            {
                // Order placement logic placeholder
            }

            public void TrackOrder()
            {
                // Order tracking logic placeholder
            }
        }
    }

}
