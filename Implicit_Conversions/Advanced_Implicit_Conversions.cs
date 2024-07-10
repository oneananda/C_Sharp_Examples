using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Implicit_Conversions.Currency;

namespace Implicit_Conversions
{
    internal class Advanced_Implicit_Conversions
    {
        public static void Example1()
        {
            // Convert EUR to USD
            EUR euros = new EUR(100);
            USD dollars = euros;
            Console.WriteLine(dollars); // Output: 110 USD
        }

        public static void Example2()
        {
            // Convert USD to EUR
            USD usDollars = new USD(100);
            EUR eurosFromDollars = usDollars;
            Console.WriteLine(eurosFromDollars); // Output: 91 EUR
        }
    }
}
