using DesignPatterns_Factory_Method_Basic.After_Factory_Pattern;
using DesignPatterns_Factory_Method_Basic.Before_Factory_Pattern;

namespace DesignPatterns_Factory_Method_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before_Factory_Pattern
            var service = new NotificationService();
            //service.SendNotification("Email", "Hello via Email!");
            //service.SendNotification("SMS", "Hello via SMS!");

            /*
               Issues with the Above Approach:

               Tight Coupling: The NotificationService class is tightly coupled 
               with the specific notification classes (EmailNotification, SMSNotification).

               Adding new notification types requires modifying the SendNotification method, 
               violating the Open/Closed Principle.
            */
            #endregion


            #region  After_Factory_Pattern

            NotificationFactory emailFactory = new EmailNotificationFactory();
            emailFactory.SendNotification("Hello via Email!");

            NotificationFactory smsFactory = new SMSNotificationFactory();
            smsFactory.SendNotification("Hello via SMS!");

            // Adding more types are very easy
            // Applying WhatsApp type notification, likewise we can add any client instantly whenever needed.

            NotificationFactory whatsAppFactory = new WhatsAppNotificationFactory();
            whatsAppFactory.SendNotification("Hello via WhatsApp!");

            // The Factory Method pattern can feel like overkill when the number of classes and their associated factories grow,
            // making the addition of new types somewhat cumbersome.
            #endregion


            Console.ReadLine(); // Hold the screen
        }
    }
}
