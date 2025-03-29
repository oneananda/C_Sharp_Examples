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

            int a, b;
            GetDataViaOut(5, out a, out b);
            Console.WriteLine($"Doubled: {a}, Tripled: {b}");

            Console.WriteLine("Handling_MultiValue_Returns!");
            Console.ReadLine(); // Hold the screen
        }

        public static void GetDataViaOut(int input, out int doubled, out int tripled)
        {
            doubled = input * 2;
            tripled = input * 3;
        }
    }
}
