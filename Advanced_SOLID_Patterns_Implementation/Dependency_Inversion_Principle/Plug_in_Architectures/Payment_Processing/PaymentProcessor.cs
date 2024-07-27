using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Plug_in_Architectures.Payment_Processing
{
    internal class PaymentProcessor 
    {
       
    }

    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Implementation for processing credit card payment
            Console.WriteLine($"Processing credit card payment of {amount}.");
        }
    }

    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Implementation for processing PayPal payment
            Console.WriteLine($"Processing PayPal payment of {amount}.");
        }
    }

    public class CryptoPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Implementation for processing cryptocurrency payment
            Console.WriteLine($"Processing cryptocurrency payment of {amount}.");
        }
    }

}
