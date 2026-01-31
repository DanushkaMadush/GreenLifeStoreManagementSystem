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
        public abstract class User
        {
            // Auto-properties
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }

            // Default constructor
            protected User()
            {
            }

            // Parameterized constructor
            protected User(int id, string username, string password, string fullName, string email, string role)
            {
                Id = id;
                Username = username;
                Password = password;
                FullName = fullName;
                Email = email;
                Role = role;
            }

            // Virtual methods
            public virtual bool SignIn(string username, string password)
            {
                // Basic credential check
                return Username == username && Password == password;
            }

            public virtual void Register()
            {
                // Registration logic placeholder
            }
        }
    }

}
