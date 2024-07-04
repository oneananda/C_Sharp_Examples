using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Func_Delegate
{
    internal class FuncHigherOrderFunction
    {
        public static void FuncAsParam()
        {
            Console.WriteLine("FuncAsParam");

            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> multiply = (a, b) => a * b;

            Console.WriteLine("FuncAsParam: add(2,4)");
            int addResult = ExecuteHighOrderOperation(2, 4, add);
            Console.WriteLine(addResult);

            Console.WriteLine("FuncAsParam: multiply(2,4)");
            int multiplyResult = ExecuteHighOrderOperation(2, 4, multiply);
            Console.WriteLine(multiplyResult);
        }

        private static int ExecuteHighOrderOperation(int v1, int v2, Func<int, int, int> operation)
        {
            return operation(v1, v2);
        }
    }
}
