namespace ref_out_Deep_Comparision
{

    public class Program
    {
        static void Main(string[] args)
        {
            #region Example 1: Combining ref and out

            Console.WriteLine($"Example 1: Combining ref and out");

            int a = 5;
            int b;

            Console.WriteLine("Original value of a: " + a);

            Calculate(ref a, out b);

            Console.WriteLine("Value of a after Calculate: " + a);
            Console.WriteLine("Value of b after Calculate: " + b);

            Console.WriteLine(string.Empty);

            #endregion


            


            Console.ReadLine(); // To hold the screen
        }



        static void Calculate(ref int x, out int y)
        {
            x *= 10; // Modify x
            y = x + 5; // Assign value to y
        }
    }
}
