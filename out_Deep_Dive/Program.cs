namespace out_Deep_Dive
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Example 1: Basic Example with out Parameter

            Console.WriteLine($"Example 1: Basic Example with out Parameter");

            int x, y;
            
            y = Multiply(out x);

            Console.WriteLine($"x = {x}, y = {y}");

            Console.WriteLine(string.Empty);

            #endregion

            #region Example 2: Using out for Multiple Return Values

            Console.WriteLine($"Example 2: Using out for Multiple Return Values");

            int dividend = 17, divisor = 3;
            int quotient, remainder;

            Divide(dividend, divisor, out quotient, out remainder);

            Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");


            Console.WriteLine(string.Empty);

            #endregion


            #region Example 3: Using out with TryParse

            Console.WriteLine($"Example 3: Using out with TryParse");
            Console.WriteLine($"Passing a integer value to parse - string input = \"123\"");
            string input = "123";
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"Parsing successful: {result}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }
            Console.WriteLine(string.Empty);

            Console.WriteLine($"Passing a non integer value to parse - string input = \"123A\"");
            input = "123A";
            if (int.TryParse(input, out result))
            {
                Console.WriteLine($"Parsing successful: {result}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }
            Console.WriteLine(string.Empty);

            #endregion

            #region Example 3: Method Overloading with out

            Console.WriteLine($"Example 3: Method Overloading with out");

            int overloadResult;

            DoSomething(5, out overloadResult); // Calls the first method
            Console.WriteLine(overloadResult);   // Output: 10

            DoSomething(5, 3, out overloadResult); // Calls the second method
            Console.WriteLine(overloadResult);     // Output: 8

            #endregion

            Console.ReadLine(); // To hold the screen
        }

        static void DoSomething(int a, out int b)
        {
            b = a * 2;
        }
        static void DoSomething(int a, int c, out int b)
        {
            b = a + c;
        }
        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
        static int Multiply(out int a)
        {
            // The a needs to be assigned before the control leaves the method
            // if not, the compiler error will happen
            a = 10; 
            return a * a;
        }
    }
}
