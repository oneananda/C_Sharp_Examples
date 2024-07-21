using Open_Closed_Principle.Scenario1.After_OCP;
using Open_Closed_Principle.Scenario1.After_OCP.Interfaces;

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

            Console.ReadLine();
        }
    }
}
