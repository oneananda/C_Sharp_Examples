using Dependency_Inversion_Principle.Plug_in_Architectures.Payment_Processing;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paymentProcessor = new CreditCardPaymentProcessor();
            PaymentService paymentService = new PaymentService(paymentProcessor);
            paymentService.MakePayment(100);

            Console.ReadLine();
        }
    }
}
