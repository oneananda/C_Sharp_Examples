using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Plug_in_Architectures.Payment_Processing
{
    // High-level module using the abstraction
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void MakePayment(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
