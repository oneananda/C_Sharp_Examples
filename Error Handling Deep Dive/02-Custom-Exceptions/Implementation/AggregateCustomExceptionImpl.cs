using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions.Implementation
{
    public class AggregateCustomExceptionImpl
    {
        public static void Run()
        {
            var exceptions = new List<Exception>();

            // Simulating batch tasks
            for (int i = 1; i <= 3; i++)
            {
                try
                {
                    ProcessItem(i);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateCustomException(exceptions);
            }

            Console.WriteLine("All items processed successfully.");
        }
        static void ProcessItem(int id)
        {
            if (id == 1) throw new InvalidOperationException("Invalid operation on item 1");
            if (id == 2) throw new ArgumentNullException(nameof(id), "ID cannot be null for item 2");
            if (id == 3) throw new DivideByZeroException("Division by zero on item 3");

            Console.WriteLine($"Item {id} processed successfully.");
        }
    }
}
