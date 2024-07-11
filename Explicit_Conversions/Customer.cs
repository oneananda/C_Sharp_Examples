using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Explicit_Conversions
{
    internal class Customer : Person
    {
        public void Purchase()
        {
            Console.WriteLine($"{Name} makes a purchase.");
        }
    }
}
