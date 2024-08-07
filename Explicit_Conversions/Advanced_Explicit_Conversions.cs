﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversions
{
    internal class Advanced_Explicit_Conversions
    {
        public static void Example1()
        {
            Console.WriteLine("Converting Object to Specific Type: using 'as' keyword");

            object obj = "Hello, World!";
            string str = obj as string;
            if (str != null)
            {
                Console.WriteLine(str);
            }
        }

        public static void Example2()
        {
            Console.WriteLine("Converting Object to Specific Type: using 'as' keyword");

            object obj = 123;
            string str = obj as string; // Returns null if obj is not a string
            if (str != null)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Returns null if obj is not a string");
        }

        public static void Example3()
        {
            Console.WriteLine("Converting Object to Specific Type: using 'is' keyword");

            object obj = 123;
            string str = obj as string;

            // Using is with casting
            if (obj is string str2)
            {
                Console.WriteLine(str2);
            }
            else
            {
                Console.WriteLine("Not possible to type cast");
            }
        }

        public static void Example4()
        {
            Person person = new Customer { Name = "Some Customer" };

            // Using 'as' operator for safe type conversion
            Customer customer = person as Customer;

            if (customer != null)
            {
                customer.Purchase(); // This will execute because 'person' is actually a Customer
            }
            else
            {
                Console.WriteLine("Conversion to Customer failed");
            }

            Vendor vendor = person as Vendor;  //   We are casting downwards - converting base class to derived, so this will fail

            if (vendor != null)
            {
                vendor.Supply();
            }
            else
            {
                Console.WriteLine("Conversion to Vendor failed");
            }

            Console.WriteLine($"Using the as operator, the program tries to cast person to Customer and Vendor. If the cast fails, it returns null, and the program prints a failure message.");
        }
        public static void Example5()
        {
            Person person = new Customer { Name = "Some Another Customer" };

            // Using 'is' operator for type checking
            if (person is Customer)
            {
                Customer customer = (Customer)person; // Safe to cast because 'person' is actually a Customer
                customer.Purchase();
            }
            else
            {
                Console.WriteLine("person is not a Customer");
            }

            if (person is Vendor)
            {
                Vendor vendor = (Vendor)person; // Safe to cast because 'person' is actually a Vendor
                vendor.Supply();
            }
            else
            {
                Console.WriteLine("person is not a Vendor");
            }

            Console.WriteLine($"Using the is operator, the program checks if person is of type Customer or Vendor. If the check is true, it safely casts and calls the respective method.");
        }
    }
}

