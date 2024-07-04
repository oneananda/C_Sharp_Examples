using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Func_Delegate
{
    internal class Combining_multiple_func_delegates
    {
        public static void AddAndThenSquare()
        {
            Console.WriteLine("AddAndThenSquare : (5 + 4) ^ 2 = 18");

            Func<int,int,int> add = (a,b) => a + b;
            Func<int, int> square = (a) => a * a; 

            Func<int,int,int> addThenSquare = (a,b) => square(add(a,b));

            int result = addThenSquare(5, 4); // (5 + 4) ^ 2 = 18

            Console.WriteLine(result);
        }
    }
}
