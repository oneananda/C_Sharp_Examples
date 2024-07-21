using Open_Closed_Principle.Scenario_Notification_System.After_OCP.Interface;
using Open_Closed_Principle.Scenario_Notification_System.After_OCP;
using Open_Closed_Principle.Scenario_Payment_Methods.After_OCP;
using Open_Closed_Principle.Scenario_Payment_Methods.After_OCP.Interfaces;

namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var paymentMethods = new List<IPaymentMethod>
            //{
            //    new CreditCardPayment(),
            //    new PayPalPayment(),
            //    new BitcoinPayment(),
            //};

            var paymentProcessor = new PaymentProcessor();

            //var paymentProcessor = new PaymentProcessor(paymentMethods);

            paymentProcessor.ProcessPayment(new CreditCardPayment(), 100.00m);
            paymentProcessor.ProcessPayment(new PayPalPayment(), 200.00m);
            paymentProcessor.ProcessPayment(new BitcoinPayment(), 300.00m);

            // Notification Service

            var notificationService = new NotificationService();

            notificationService.SendNotification(new EmailNotification(), "This is an email message");
            notificationService.SendNotification(new SmsNotification(), "This is an SMS message");
            notificationService.SendNotification(new PushNotification(), "This is a push notification message");





            Console.ReadLine();
        }
    }
}
