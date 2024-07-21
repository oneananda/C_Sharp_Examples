using Single_Responsiblity_Principle.Scenario2.Models;
using Single_Responsiblity_Principle.Scenario2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsiblity_Principle.Scenario2.Controllers
{
    internal class UserController
    {
        private readonly UserView _userView;
        private readonly List<User> _users;

        public UserController()
        {
            _userView = new UserView();
            _users = new List<User>();
        }

        public void AddUser()
        {
            var user = _userView.GetUserInput();
            _users.Add(user);
            Console.WriteLine("User added successfully!");
        }

        public void DisplayUsers()
        {
            _userView.DisplayUsers(_users);
        }
    }
}
