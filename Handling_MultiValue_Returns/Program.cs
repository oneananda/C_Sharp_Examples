using System;
using System.Linq.Expressions;

namespace Handling_MultiValue_Returns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C# we have several ways to return multiple values from a method.

            // Method 1 : Out Parameters

            /* We can define additional parameters as out parameters. 
             * This is one of the older approaches but still useful in many cases.
            */

            Console.WriteLine($"Out Parameters");

            int a, b;
            GetDataViaOut(5, out a, out b);
            Console.WriteLine($"Doubled: {a}, Tripled: {b}");

            // Methode 2 : Tuples
            // With C# 7.0 and above, tuples (especially ValueTuple) are a popular, 
            // concise way to return multiple values.
            // They support deconstruction, making the code very readable.

            Console.WriteLine($"Tuples");
            // Usage:
            var result = GetDataViaTuple(5);
            Console.WriteLine($"Doubled: {result.Doubled}, Tripled: {result.Tripled}");

            // Or using deconstruction:
            var (doubled, tripled) = GetDataViaTuple(5);
            Console.WriteLine($"Doubled: {doubled}, Tripled: {tripled}");

            // Methode 3 : Custom Classes or Structs
            // When the returned values are related,
            // creating a custom type can make your code
            // more expressive and maintainable.

            Console.WriteLine($"Custom Struct");
            // Usage:
            var dataResult = GetDataViaCustom(5);
            Console.WriteLine($"Doubled: {dataResult.Doubled}, Tripled: {dataResult.Tripled}");


            // Methode 4 :KeyValuePair
            // For returning two related values, KeyValuePair can be used,
            // although it’s more common for representing pairs in collections.

            Console.WriteLine($"Using KeyValuePair");

            var pair = GetDataViaPair(5);
            Console.WriteLine($"Doubled: {pair.Key}, Tripled: {pair.Value}");

            // Methode 4 : Arrays 
            // If the values are of the same type or if we’re returning a variable number of items,
            // we might choose to return an array or a collection like List<T>.

            Console.WriteLine($"Using Arrays");

            int[] results = GetDataViaArray(5);
            Console.WriteLine($"Doubled: {results[0]}, Tripled: {results[1]}");


            Console.WriteLine("Handling_MultiValue_Returns!");
            Console.ReadLine(); // Hold the screen
        }

        public static void GetDataViaOut(int input, out int doubled, out int tripled)
        {
            doubled = input * 2;
            tripled = input * 3;
        }

        public static (int Doubled, int Tripled) GetDataViaTuple(int input)
        {
            return (input * 2, input * 3);
        }

        public class DataResult
        {
            public int Doubled { get; set; }
            public int Tripled { get; set; }
        }

        public static DataResult GetDataViaCustom(int input)
        {
            return new DataResult { Doubled = input * 2, Tripled = input * 3 };
        }

        public static KeyValuePair<int, int> GetDataViaPair(int input)
        {
            return new KeyValuePair<int, int>(input * 2, input * 3);
        }

        public static int[] GetDataViaArray(int input)
        {
            return new int[] { input * 2, input * 3 };
        }
    }
}
