using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversions
{
    internal class Basic_Implicit_Conversions
    {
        public static void Example1()
        {
            int intVal = 123;
            double doubleVal = intVal; // Implicit conversion from int to double
            Console.WriteLine(doubleVal); // Output: 123
        }

        public static void Example2()
        {
            int IntValue = 10;
            long LongValue;

            // Converting int to long is easy
            LongValue = IntValue;
            // The above code will work as we are converting from small memory size to bigger one
            Console.WriteLine(LongValue); // Output: 10
        }

        public static void Example3()
        {
            int IntValue = 10;
            long LongValue = 1000;

            // Converting int to long is NOT easy possible

            // Un comment the following line to see the compile time error
            //IntValue = LongValue;
            
            // The above code will NOT work as we are converting from bigger memory size to smaller one,
            // Even though we are assigning the values to int that is capable of holding

            //Compiler Error: Cannot implicitly convert type 'long' to 'int'.An explicit conversion exists(are you missing a cast?)

        }
    }
}
