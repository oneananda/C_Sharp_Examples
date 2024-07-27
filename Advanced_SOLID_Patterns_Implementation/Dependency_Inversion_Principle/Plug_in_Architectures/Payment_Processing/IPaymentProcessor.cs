using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Plug_in_Architectures.Payment_Processing
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
