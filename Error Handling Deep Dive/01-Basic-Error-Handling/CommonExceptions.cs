using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._01_Basic_Error_Handling
{
    class CommonExceptions
    {
        public static void Run()
        {
            Console.WriteLine("== Common Exceptions Demo ==");

            HandleNullReference();
            HandleIndexOutOfRange();
            HandleInvalidCast();
        }

        static void HandleNullReference()
        {
            try
            {
                string value = null;
                Console.WriteLine(value.ToUpper()); // NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Caught a NullReferenceException:");
                Console.WriteLine(ex.Message);
            }
        }

        static void HandleIndexOutOfRange()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught an IndexOutOfRangeException:");
                Console.WriteLine(ex.Message);
            }
        }

        static void HandleInvalidCast()
        {
            try
            {
                object obj = "Hello";
                int num = (int)obj; // InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Caught an InvalidCastException:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
