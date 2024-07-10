using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversions
{
    internal class Basic_Explicit_Conversions
    {
        public static void Example1()
        {
            Console.WriteLine("Converting double to int:");
            double d = 9.78;
            int i = (int)d;  // i is now 9
            Console.WriteLine(i); 
        }

        public static void Example2()
        {
            Console.WriteLine("Converting float to int:");

            float f = 3.14f;
            int i = (int)f;  // i is now 3

            Console.WriteLine(i);
        }

        public static void Example3()
        {
            Console.WriteLine("Converting long to int:");

            long l = 1234567890L;
            int i = (int)l;  // i is now 1234567890 if within the range of int, otherwise it may lose data

            Console.WriteLine(i);
        }

        public static void Example4()
        {
            Console.WriteLine("Converting decimal to int:");
            decimal m = 123.45m;
            int i = (int)m;  // i is now 123

            Console.WriteLine(i);
        }
    }
}
