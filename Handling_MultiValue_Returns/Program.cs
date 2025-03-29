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

            // Methode 2 : Tuples
            // With C# 7.0 and above, tuples (especially ValueTuple) are a popular, 
            // concise way to return multiple values.
            // They support deconstruction, making the code very readable.

            // Usage:
            var result = GetDataViaTuple(5);
            Console.WriteLine($"Doubled: {result.Doubled}, Tripled: {result.Tripled}");

            // Or using deconstruction:
            var (doubled, tripled) = GetDataViaTuple(5);
            Console.WriteLine($"Doubled: {doubled}, Tripled: {tripled}");

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
    }
}
