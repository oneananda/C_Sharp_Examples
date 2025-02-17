using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyEvaluation
{
    public class Basic_Example_of_Lazy_Evaluation
    {
        public static string ComputeExpensiveString()
        {
            Console.WriteLine("Computing the expensive string...");
            return "Hello, Lazy Evaluation!";
        }
    }
}
