using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Deep_Dive
{
    // Example 1 : Step 1: Declare a delegate
    public delegate void PrintDelegate(string message);
    public class BasicDelegateExample
    {
        public BasicDelegateExample()
        {

        }

        public static void BasicDelegate()
        {
            #region Example 1 Basic Delegate Example
            Console.WriteLine($"Example 1 Basic Delegate Example");

            // Example 1 : Step 3: Instantiate the delegate
            PrintDelegate pd = PrintMessage;

            // Example 1 : Step 4: Invoke the delegate
            pd("Hello, this is a delegate example!");

            Console.WriteLine(string.Empty);
            #endregion
        }

        // Example 1 :Step 2: Create a method that matches the delegate signature
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
