using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Scenario1.After_OCP.Interfaces
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }
}
