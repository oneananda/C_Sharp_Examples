
using System.Security.Cryptography.X509Certificates;

namespace Delegate_Deep_Dive
{
    // Example 1 : Step 1: Declare a delegate
    public delegate void PrintDelegate(string message);
    public class Program
    {
        // Example 1 :Step 2: Create a method that matches the delegate signature
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            BasicDelegateExample();
            Console.ReadLine(); // Hold screen
        }

        private static void BasicDelegateExample()
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


    }
}
