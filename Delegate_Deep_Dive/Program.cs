
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Delegate_Deep_Dive
{
    // Example 1 : Step 1: Declare a delegate
    public delegate void PrintDelegate(string message);

    public delegate void PrintWithOptionsDelegate(string message, string options);
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
            MulticastDelegateExample();
            Console.ReadLine(); // Hold screen
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

        private static void MulticastDelegateExample()
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
