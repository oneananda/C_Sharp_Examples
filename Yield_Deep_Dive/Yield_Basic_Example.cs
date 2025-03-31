using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_Deep_Dive
{
    public class Yield_Basic_Example
    {
        public static void Example_1()
        {
            foreach (int number in GetEvenNumbers(10))
            {
                Console.WriteLine(number);
            }
        }

        static IEnumerable<int> GetEvenNumbers(int max)
        {
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
