using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversions
{
    internal class Currency
    {
        public class USD
        {
            public decimal Amount { get; }

            public USD(decimal amount)
            {
                Amount = amount;
            }

            // Implicit conversion from EUR to USD
            public static implicit operator USD(EUR eur)
            {
                // Assuming a conversion rate of 1 EUR = 1.10 USD
                return new USD(eur.Amount * 1.10m);
            }

            public override string ToString()
            {
                return $"{Amount} USD";
            }
        }

        public class EUR
        {
            public decimal Amount { get; }

            public EUR(decimal amount)
            {
                Amount = amount;
            }

            // Implicit conversion from USD to EUR
            public static implicit operator EUR(USD usd)
            {
                // Assuming a conversion rate of 1 USD = 0.91 EUR
                return new EUR(usd.Amount * 0.91m);
            }

            public override string ToString()
            {
                return $"{Amount} EUR";
            }
        }
    }
}
