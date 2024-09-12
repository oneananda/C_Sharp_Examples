using DesignPatterns_Factory_Method_Basic.Before_Factory_Pattern;

namespace DesignPatterns_Factory_Method_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before_Factory_Pattern
            var service = new NotificationService();
            service.SendNotification("Email", "Hello via Email!");
            service.SendNotification("SMS", "Hello via SMS!");

            /*
               Issues with the Above Approach:

               Tight Coupling: The NotificationService class is tightly coupled 
               with the specific notification classes (EmailNotification, SMSNotification).

               Adding new notification types requires modifying the SendNotification method, 
               violating the Open/Closed Principle.
            */


            #endregion


            Console.ReadLine(); // Hold the screen
        }
    }
}
