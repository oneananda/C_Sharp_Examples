using Open_Closed_Principle.Scenario1.After_OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario1.After_OCP
{
    public class PaymentProcessor
    {
        private readonly List<IPaymentMethod> _paymentMethods;

        public PaymentProcessor()
        {

        }
        public PaymentProcessor(List<IPaymentMethod> paymentMethods)
        {
            _paymentMethods = paymentMethods;
        }

        public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }

}
