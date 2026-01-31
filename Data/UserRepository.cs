using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeStoreManagementSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using global::GreenLifeStoreManagementSystem.Models.GreenLifeStoreManagementSystem.Models;
    using GreenLifeStoreManagementSystem.Models;

    namespace GreenLifeStoreManagementSystem.Data
    {
        public class UserRepository
        {
            private readonly List<User> _users;

            public UserRepository()
            {
                _users = new List<User>();

                // Preload one Admin user (username: admin, password: 1234)
                var admin = new Admin(1, "admin", "1234", "Administrator", "admin@example.com");
                _users.Add(admin);
            }

            public void AddUser(User user)
            {
                if (user != null)
                {
                    _users.Add(user);
                }
            }

            public User GetUserByUsername(string username)
            {
                return _users.FirstOrDefault(u => u.Username == username);
            }

            public bool ValidateUser(string username, string password)
            {
                var user = GetUserByUsername(username);
                return user != null && user.Password == password;
            }
        }
    }

}
