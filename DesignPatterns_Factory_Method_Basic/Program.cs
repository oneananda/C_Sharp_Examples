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
            #endregion


            Console.ReadLine(); // Hold the screen
        }
    }
}
