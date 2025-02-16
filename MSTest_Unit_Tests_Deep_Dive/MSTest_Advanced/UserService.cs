using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest_Advanced
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null)
                return null;

            if (user.Password == password && user.IsActive)
                return user;

            return null;
        }
        public async Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null || user.Password != oldPassword)
                return false;

            user.Password = newPassword;
            // In a real-world scenario, you would persist the changes here.
            return true;
        }
    }
}
