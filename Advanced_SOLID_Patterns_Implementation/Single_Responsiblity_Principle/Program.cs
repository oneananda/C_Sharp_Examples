using Single_Responsiblity_Principle.Scenario2.Controllers;

namespace Single_Responsiblity_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Scenario 2 
            var userController = new UserController();

            string userEntry = "Some_Entry";

            while (userEntry!=string.Empty)
            {
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Display Users");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        userController.AddUser();
                        break;
                    case "2":
                        userController.DisplayUsers();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press 'Enter' to exit, press any other key to proceed");
                userEntry = Console.ReadLine();
            }

            //Console.ReadLine();
        }
    }
}
