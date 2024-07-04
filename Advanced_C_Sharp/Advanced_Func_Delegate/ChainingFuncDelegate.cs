using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Func_Delegate
{
    internal class ChainingFuncDelegate
    {
        public static void ProcessChaining()
        {
            Console.WriteLine("ProcessChaining: // (4 + 1) * 2 = 10");

            Func<int, int> addOne = x => x + 1;
            Func<int, int> doubleValue = x => x * 2;

            Func<int, int> addOneThenDouble = addOne.Compose(doubleValue);

            Console.WriteLine(addOneThenDouble(4)); // (4 + 1) * 2 = 10
        }
    }
    public static class FuncExtensions
    {
        /*
        Explanation of the Compose Method

        Generic Parameters:

        T: The input type of the first function.
        
        TIntermediate: The output type of the first function and the input type of the second function.
        
        TResult: The output type of the second function.
        */
        public static Func<T, TResult> Compose<T, TIntermediate, TResult>(this Func<T, TIntermediate> first, Func<TIntermediate, TResult> second)
        {
            return x => second(first(x));
        }
    }
}
