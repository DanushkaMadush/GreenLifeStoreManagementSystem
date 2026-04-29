using System;
using GreenLifeStoreManagementSystem.Repositories;

namespace GreenLifeStoreManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }

        // user class constructor with no input params
        public User()
        {
        }

        // user class constructor with input params - method overloading
        public User(string fullName, string username, string password,
                    string email, string phone, string address, string role)
        {
            FullName = fullName;
            Username = username;
            Password = password;
            Email = email;
            Phone = phone;
            Address = address;
            Role = role;
        }

        // register user
        public bool Register()
        {
            UserRepository repo = new UserRepository();
            return repo.Register(this);
        }

        // login
        public static User Login(string username, string password)
        {
            UserRepository repo = new UserRepository();
            return repo.Login(username, password);
        }

        // check if username already exist
        public static bool IsUsernameTaken(string username)
        {
            UserRepository repo = new UserRepository();
            return repo.UserNameExists(username);
        }

        // get user details by user id
        public static User GetUserById(int userId)
        {
            UserRepository repo = new UserRepository();
            return repo.GetUserById(userId);
        }


        // update user profile
        public bool UpdateProfile()
        {
            UserRepository repo = new UserRepository();
            return repo.UpdateUser(this);
        }
    }
}
