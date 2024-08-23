namespace var_Deep_Dive
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Typing for Local Variables

            Console.WriteLine($"Implicit Typing for Local Variables");

            var message = "Hello, World!";
            // The compiler takes that message is of type string.

            Console.WriteLine($"Message " + message);

            var number = 42;
            // The compiler takes that number is of type int.

            Console.WriteLine($"Number " + number);

            var price = 19.99;
            // The compiler takes that price is of type double.

            Console.WriteLine($"Price " + price);

            Console.WriteLine(string.Empty);

            #endregion


            #region Anonymous Types

            Console.WriteLine($"Anonymous Types");

            // var is essential when working with anonymous types, as you cannot explicitly name the type.

            var person = new { Name = "Craig", Age = 30 };
            // The type of 'person' is an anonymous type with Name and Age properties.

            Console.WriteLine(person.Name);  // Output: Craig
            Console.WriteLine(person.Age);   // Output: 30

            Console.WriteLine(string.Empty);

            #endregion

            Console.ReadLine(); // To hold the screen
        }
    }
}
