using Open_Closed_Principle.Scenario1.After_OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario1.After_OCP
{
    public class PaymentMethods
    {

    }
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            // Process credit card payment
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            // Process PayPal payment
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }

    public class BitcoinPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            // Process Bitcoin payment
            Console.WriteLine($"Processing Bitcoin payment of {amount:C}");
        }
    }
}
