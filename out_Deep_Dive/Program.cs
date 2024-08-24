namespace out_Deep_Dive
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Example 1: Basic Example with out Parameter

            Console.WriteLine($"Example 1: Basic Example with out Parameter");

            int x, y;
            
            GetNumbers(out x, out y);

            Console.WriteLine($"x = {x}, y = {y}");

            Console.WriteLine(string.Empty);

            #endregion

            Console.ReadLine(); // To hold the screen
        }

        static void GetNumbers(out int a, out int b)
        {
            // The a and b needs to be assigned before the control leaves the method
            // if not, the compiler error will happen
            a = 10; 
            b = 20;
        }
    }
}
