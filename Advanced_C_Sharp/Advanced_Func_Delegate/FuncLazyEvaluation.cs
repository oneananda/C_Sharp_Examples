using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Func_Delegate
{
    internal class FuncLazyEvaluation
    {
        public static void ProcessLazy()
        {
            Console.WriteLine("ProcessLazy");
            Lazy<int> lazyValue = new Lazy<int>(() => ComputeValue());

            Console.WriteLine("Lazy value not computed yet.");

            Console.WriteLine($"Computed value: {lazyValue.Value}");
        }
        private static int ComputeValue()
        {
            Console.WriteLine("Computing value...");
            return 200;
        }
    }
}
