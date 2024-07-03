using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cast_OfType_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let's create a list of objects as an IEnumerable<object> containing a mixture of different types
            // (int, string, double).
            IEnumerable<object> objects = new List<object> { 1, "two", 3.0, "four" };

            // Let's do the cast now
            IEnumerable<string> strings = objects.Cast<string>();

            //Cast<string>() converts each element in objects to a string.
            //If any element cannot be cast to the specified type(string),
            //an InvalidCastException will be thrown at runtime.

            try
            {
                // I am not getting any error at 'objects.Cast<string>();'
                // but getting error at '  foreach (string s in strings)'
                // This phenomenen is called 'Deffered Execution'
                foreach (string s in strings) 
                    Console.WriteLine(s);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"InvalidCastException caught: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
