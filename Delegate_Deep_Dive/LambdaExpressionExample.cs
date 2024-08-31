using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Deep_Dive
{
    public delegate int MathOperationLambda(int x, int y);
    internal class LambdaExpressionExample
    {
        public static void LambdaExpression()
        {
            Console.WriteLine($"Example 4 : Anonymous Method Example");

            MathOperationLambda add = (a, b) => a + b;
            MathOperationLambda multiply = (a, b) => a * b;

            Console.WriteLine("Sum: " + add(10, 5));
            Console.WriteLine("Product: " + multiply(10, 5));
            Console.WriteLine(string.Empty);
        }
    }
}
