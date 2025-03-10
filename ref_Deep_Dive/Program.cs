﻿using System;
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
            Console.WriteLine($"Example 1: Basic implementation of 'ref'");
            // Basic implementation of 'ref'
            int num = 10;
            Console.WriteLine($"Before method call: {num}");

            ModifyValue(ref num);

            Console.WriteLine($"After method call: {num}");

            // Output
            // Before method call: 10
            // After method call: 20
            Console.WriteLine(string.Empty);
            #endregion

            #region Example 2: Multiple 'ref' implementation
            Console.WriteLine($"Example 2: Multiple 'ref' implementation");
            int result1 = 0, result2 = 0;

            CalculateValues(5, 3, ref result1, ref result2);

            Console.WriteLine($"Sum: {result1}, Difference: {result2}");

            Console.WriteLine(string.Empty);
            #endregion

            #region Example 3: Handling Reference Types
            Console.WriteLine($"Example 3: Handling Reference Types");
            // Create a new Person object and set its Name property.
            Person person = new Person { Name = "Alice" };
            Console.WriteLine($"Before: {person.Name}");

            // Pass the person object by reference.
            ModifyPerson(ref person);

            // The reference to person has been changed inside the method.
            Console.WriteLine($"After: {person.Name}");
            Console.WriteLine(string.Empty);
            #endregion


            #region Example 4: Using ref in string 
            Console.WriteLine($"Example 4: Using ref in string");
            string text = "Hello";
            Console.WriteLine($"Before: {text}");

            // Pass the string by reference.
            ModifyString(ref text);

            // The string reference should point to the new string value.
            Console.WriteLine($"After: {text}");
            Console.WriteLine(string.Empty);
            #endregion

            #region Example 5: Using ref in Recursive Methods
            Console.WriteLine($"Example 5: Using ref in Recursive Methods");
            int number = 1;
            Console.WriteLine($"Original Number: {number}");

            IncrementRef(ref number, 5);

            Console.WriteLine($"Incremented Number: {number}");
            Console.WriteLine(string.Empty);
            #endregion


            #region Example 6: Without Using ref but achive the same functionality 
            Console.WriteLine($"Example 6: Without Using ref but achive the same functionality ");
            List<string> LstStr = new List<string>();
            LstStr.Add("Adding string 1");
            Console.WriteLine($"Original Count: {LstStr.Count}");

            ProcessLstStr(LstStr);

            Console.WriteLine($"Current Count: {LstStr.Count}");
            Console.WriteLine(string.Empty);
            #endregion

            #region Example 7: With and without Using ref - Performance considerations
            Console.WriteLine($"Example 7: With and without Using ref - Performance considerations");

            LargeStruct largeStruct = new LargeStruct(1000000);
            Console.WriteLine("Starting Without ref...");

            for (int i = 0; i < 1000; i++)
            {
                ProcessLargeStruct(largeStruct);
            }

            Console.WriteLine("Finished Without ref.");

            Console.WriteLine($"Each time ProcessLargeStruct (without ref) is called, a full copy of largeStruct is made. If the struct is large (e.g., contains a large array), this copying process can be slow and memory-intensive.");

            Console.WriteLine(string.Empty);

            Console.WriteLine("Starting With ref...");

            for (int i = 0; i < 1000; i++)
            {
                ProcessLargeStruct(ref largeStruct);
            }

            Console.WriteLine("Finished With ref.");

            Console.WriteLine(string.Empty);

            #endregion

            Console.ReadLine();
        }

        static void ProcessLargeStruct(ref LargeStruct ls)
        {
            // Processing large struct...
            ls.Data[0] = 42; // Modify just to simulate some processing
        }

        static void ProcessLargeStruct(LargeStruct ls)
        {
            // Processing large struct...
            ls.Data[0] = 42; // Modify just to simulate some processing
        }

        public struct LargeStruct
        {
            public int[] Data;
            public LargeStruct(int size)
            {
                Data = new int[size];
            }
        }

        private static void ProcessLstStr(List<string> lstStr)
        {
            // Adding values, but not returning
            lstStr.Add("Adding new string");
            lstStr.Add("Adding another new string");
        }

        static void IncrementRef(ref int num, int limit)
        {
            if (num < limit)
            {
                num++;
                IncrementRef(ref num, limit);
            }
        }

        static void ModifyString(ref string s)
        {
            // Reassign the reference to a new string instance.
            s = "World";
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
