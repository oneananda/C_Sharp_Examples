using System;
using System.Diagnostics.Metrics;

namespace ref_Deep_Dive
{
    public class Person
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1: Basic implementation of 'ref'
            // Basic implementation of 'ref'
            int num = 10;
            Console.WriteLine($"Before method call: {num}");

            ModifyValue(ref num);

            Console.WriteLine($"After method call: {num}");

            // Output
            // Before method call: 10
            // After method call: 20
            #endregion

            #region Example 2: Multiple 'ref' implementation
            int result1 = 0, result2 = 0;

            CalculateValues(5, 3, ref result1, ref result2);

            Console.WriteLine($"Sum: {result1}, Difference: {result2}");

            #endregion

            #region Example 3: Handling Reference Types
            // Create a new Person object and set its Name property.
            Person person = new Person { Name = "Alice" };
            Console.WriteLine($"Before: {person.Name}");

            // Pass the person object by reference.
            ModifyPerson(ref person);

            // The reference to person has been changed inside the method.
            Console.WriteLine($"After: {person.Name}");
            #endregion

            Console.ReadLine();
        }

        // Method that takes a Person object by reference.
        static void ModifyPerson(ref Person p)
        {
            // Create a new Person object and assign it to the parameter.
            p = new Person { Name = "Bob" };
        }

        static void CalculateValues(int a, int b, ref int sum, ref int difference)
        {
            sum = a + b;
            difference = a - b;
        }

        static void ModifyValue(ref int x)
        {
            x = x * 2;
        }
    }
}
