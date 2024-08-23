namespace var_Deep_Dive
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Typing for Local Variables

            var message = "Hello, World!";
            // The compiler takes that message is of type string.

            Console.WriteLine($"Message " + message);

            var number = 42;
            // The compiler takes that number is of type int.

            Console.WriteLine($"Number " + number);

            var price = 19.99;
            // The compiler takes that price is of type double.

            Console.WriteLine($"Price " + price);

            #endregion

            Console.ReadLine(); // To hold the screen
        }
    }
}
