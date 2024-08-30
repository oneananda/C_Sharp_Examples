using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Deep_Dive
{
    public delegate int MathOperation(int x, int y);
    internal class DelegateAsParameterExample
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b; 
        }

        public static void PerformOperation(int a, int b, MathOperation mathOperation)
        {
            int result = mathOperation(a, b);
            Console.WriteLine(result);
        }

        public static void DelegateAsParameter()
        {
            PerformOperation(5, 3, Add);

            PerformOperation(5, 3, Multiply);
        }
    }
}
