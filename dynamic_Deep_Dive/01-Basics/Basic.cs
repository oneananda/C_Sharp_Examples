using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_Deep_Dive._01_Basics
{
    internal class Basic
    {
        public static void Run()
        {
            #region Basic examples
            // Basic dynamic typing 

            dynamic name = "Alice";
            Console.WriteLine(name.Length); // Resolved at runtime

            // Compare var vs dynamic

            var x = "Hello";     // Type resolved at compile time
            dynamic y = "Hello"; // Type resolved at runtime

            // Dynamic with primitive operations

            dynamic a = 5;
            dynamic b = 10;
            Console.WriteLine(a + b); // Runtime resolution

            // Runtime method call on dynamic object

            dynamic obj = new ExpandoObject();
            obj.SayHello = new Action(() => Console.WriteLine("Hello from dynamic!"));
            obj.SayHello();

            #endregion
        }
    }
}
