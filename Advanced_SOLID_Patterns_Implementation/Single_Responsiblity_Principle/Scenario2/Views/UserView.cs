using Single_Responsiblity_Principle.Scenario2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsiblity_Principle.Scenario2.Views
{
    internal class UserView
    {
        public void DisplayUser(User user)
        {
            Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }

        public void DisplayUsers(List<User> users)
        {
            foreach (var user in users)
            {
                DisplayUser(user);
            }
        }

        public User GetUserInput()
        {
            var user = new User();
            Console.Write("Enter User ID: ");
            user.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter User Name: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter User Email: ");
            user.Email = Console.ReadLine();
            return user;
        }
    }
}
