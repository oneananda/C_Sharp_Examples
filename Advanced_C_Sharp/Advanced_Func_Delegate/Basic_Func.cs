using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Func_Delegate
{
    internal class Basic_Func
    {
        public static void GetEvenNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Expects int as input and ouputs bool based on condition
            Func<int, bool> isEven = num => num % 2 == 0;

            var evenNums = numbers.Where(isEven).ToList();

            evenNums.ForEach(Console.WriteLine);
        }
    }
}
