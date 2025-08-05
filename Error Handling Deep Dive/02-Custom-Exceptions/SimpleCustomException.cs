using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
    // Define a simple custom exception
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class SimpleCustomException
    {
        static void Main()
        {
            Console.WriteLine("== Simple Custom Exception Demo ==");

            try
            {
                RegisterUser("Alice", 12);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Custom exception caught: {ex.Message}");
            }
        }

        static void RegisterUser(string name, int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException($"User '{name}' is underaged for registration.");
            }

            Console.WriteLine($"User {name} registered successfully.");
        }
    }
}
