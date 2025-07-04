using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace dynamic_Deep_Dive._03_Advanced
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Advanced
    {
        public static void Run()
        {
            // Dynamic LINQ Queries (System.Linq.Dynamic.Core)
            // Ensure you have the System.Linq.Dynamic.Core package installed
            // You can install it via NuGet: Install-Package System.Linq.Dynamic.Core

            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 22 },
                new Person { Name = "Bob", Age = 17 },
                new Person { Name = "Charlie", Age = 30 },
                new Person { Name = "Diana", Age = 15 }
            };

            // Convert list to IQueryable to support dynamic LINQ
            var queryable = people.AsQueryable();

            // Dynamic filter: find people older than 18
            var adults = queryable.Where("Age > 18");

            Console.WriteLine("People over 18:");
            foreach (var person in adults)
            {
                Console.WriteLine($"{person.Name} ({person.Age})");
            }

            // dynamic filter by name

            var nameQuery = queryable.Where("Name == @0", "Alice");
            Console.WriteLine("\nPeople named Alice:");
            foreach (var person in nameQuery)
            {
                Console.WriteLine($"{person.Name} ({person.Age})");
            }
        }
    }
}
