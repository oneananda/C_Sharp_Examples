using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversions
{
    internal class Vendor : Person
    {
        public void Supply()
        {
            Console.WriteLine($"{Name} supplies goods.");
        }
    }
}
