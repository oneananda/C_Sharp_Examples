﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversions
{
    internal class Advanced_Explicit_Conversions
    {
        public static void Example1()
        {
            Console.WriteLine("Converting Object to Specific Type: using 'as' keyword");

            object obj = "Hello, World!";
            string str = obj as string; // Returns null if obj is not a string
            if (str != null)
            {
                Console.WriteLine(str);
            }
        }

        public static void Example2()
        {
            Console.WriteLine("Converting Object to Specific Type: using 'as' keyword");

            object obj = 123;
            string str = obj as string; // Returns null if obj is not a string
            if (str != null)
            {
                Console.WriteLine(str);
            }
        }
    }
}
