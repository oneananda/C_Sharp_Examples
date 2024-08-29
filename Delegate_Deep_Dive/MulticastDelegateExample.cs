using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Deep_Dive
{
    public class MulticastDelegateExample
    {
        public MulticastDelegateExample() { }
        public static void MulticastDelegate()
        {
            #region Example 2 Multicast Delegate Example
            Console.WriteLine($"Example 2 Multicast Delegate Example");

            PrintWithOptionsDelegate pd = PrintWithOptions1;

            pd += PrintWithOptions2;

            pd("Hello, this is a MulticastDelegateExample example 1!", string.Empty);
            pd("Hello, this is a MulticastDelegateExample example 2!", string.Empty);

            Console.WriteLine(string.Empty);
            #endregion
        }
        private static void PrintWithOptions1(string message, string options)
        {
            if (options == string.Empty)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("PrintWithOptions1: " + message + " and options are " + options);
            }
        }

        private static void PrintWithOptions2(string message, string options)
        {
            if (options == string.Empty)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("PrintWithOptions2: " + message + " and options are " + options);
            }
        }
    }
}
