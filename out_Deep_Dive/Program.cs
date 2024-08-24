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


            Console.ReadLine(); // To hold the screen
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
