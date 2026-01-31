using System;
using GreenLifeStoreManagementSystem.Data.GreenLifeStoreManagementSystem.Data;
using GreenLifeStoreManagementSystem.Models.GreenLifeStoreManagementSystem.Models;

namespace GreenLifeStoreManagementSystem.Services
{
    internal class AuthService
    {
        private readonly UserRepository _userRepository;
        private User _loggedUser;

        public AuthService(UserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public bool Login(string username, string password)
        {
            if (_userRepository.ValidateUser(username, password))
            {
                _loggedUser = _userRepository.GetUserByUsername(username);
                return true;
            }
            _loggedUser = null;
            return false;
        }

        public User GetLoggedUser(string username)
        {
            var user = _userRepository.GetUserByUsername(username);
            if (_loggedUser != null && _loggedUser.Username == username)
            {
                return _loggedUser;
            }
            return null;
        }
    }
}
