using System;
using System.Text;

namespace var_Deep_Dive
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Example 1: Implicit Typing for Local Variables

            Console.WriteLine($"Example 1: Implicit Typing for Local Variables");

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


            #region Example 2: Anonymous Types

            Console.WriteLine($"Example 2: Anonymous Types");

            // var is essential when working with anonymous types, as you cannot explicitly name the type.

            var person = new { Name = "Craig", Age = 30 };
            // The type of 'person' is an anonymous type with Name and Age properties.

            Console.WriteLine(person.Name);  // Output: Craig
            Console.WriteLine(person.Age);   // Output: 30

            Console.WriteLine(string.Empty);

            #endregion

            #region Example 3: Complex Object Initializations

            Console.WriteLine($"Example 3: Complex Object Initializations");

            var customer = new Dictionary<string, Dictionary<string, double>>();

            var orderItems = new Dictionary<string, double>();

            orderItems.Add("Laptop", 27272.33);
            orderItems.Add("Monitor", 78771.52);

            customer.Add("Cust 1", orderItems);
            customer.Add("Cust 2", orderItems);

            // var is used to iterate also
            foreach (var item in customer)
            {
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item.Key + " " + item2.Key + " " + item2.Value);
                }
            }

            Console.WriteLine(string.Empty);

            #endregion

            #region Example 4: LINQ Queries

            Console.WriteLine($"Example 4: LINQ Queries");

            var numbers = new[] { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            // evenNumbers is of type IEnumerable<int>.

            foreach (var currentNumber in evenNumbers)
            {
                Console.WriteLine(currentNumber);  // Output: 2, 4
            }

            Console.WriteLine(string.Empty);

            #endregion


            #region Example 5: Reducing Redundancy

            Console.WriteLine($"Example 5: Reducing Redundancy");

            var sb = new StringBuilder();
            // Instead of StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            sb.Append(" World!");

            Console.WriteLine($"Use var instead of StringBuilder sb = new StringBuilder() to Reducing Redundancy");

            Console.WriteLine(string.Empty);

            #endregion


            #region Example 6: Working with Collections

            Console.WriteLine($"Example 6: Working with Collections");

            var list = new List<string> { "apple", "banana", "cherry" };

            foreach (var item in list)
            {
                Console.WriteLine(item);  // Output: apple, banana, cherry
            }

            Console.WriteLine(string.Empty);

            #endregion


            #region Example 7: Rules & Restrictions of var - Initialization is Mandatory

            Console.WriteLine($"Example 7: Rules & Restrictions of var - Initialization is Mandatory");

            /*
             
            var myString;  // This will cause a compile-time error
            
            myString = "Hello";
            
            */
            Console.WriteLine($"var myString;  // This will cause a compile-time error");

            Console.WriteLine($"var requires an initial value to determine the type.");

            Console.WriteLine(string.Empty);

            #endregion

            

            Console.ReadLine(); // To hold the screen
        }
    }
}
