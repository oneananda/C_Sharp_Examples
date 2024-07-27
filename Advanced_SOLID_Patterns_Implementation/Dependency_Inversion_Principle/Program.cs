using Dependency_Inversion_Principle.Plug_in_Architectures.Payment_Processing;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inject the appropriate plug-in
            IPaymentProcessor paymentProcessor = new CreditCardPaymentProcessor();
            PaymentService paymentService = new PaymentService(paymentProcessor);
            paymentService.MakePayment(100);

            paymentProcessor = new PayPalPaymentProcessor();
            paymentService = new PaymentService(paymentProcessor);
            paymentService.MakePayment(200.00m);

            paymentProcessor = new CryptoPaymentProcessor();
            paymentService = new PaymentService(paymentProcessor);
            paymentService.MakePayment(300.00m);

            Console.ReadLine();
        }
    }
}
