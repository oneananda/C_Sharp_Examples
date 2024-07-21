using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario1.Before_OCP
{
    public class Before_OCP_PaymentProcessor
    {
        /*
        * A payment processing system that initially only 
        * supports credit card payments. 
        * Later, you want to add support for PayPal and Bitcoin payments 
        * without modifying the existing code.
        * This can't be possible with the current code
        */
        public void ProcessPayment(string paymentType, decimal amount)
        {
            if (paymentType == "CreditCard")
            {
                // Process credit card payment
                Console.WriteLine($"Processing credit card payment of {amount:C}");
            }
        }
    }

}
