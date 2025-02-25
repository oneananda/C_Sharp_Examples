using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Parallel_ForEach
    {
        public static void Parallel_ForEach_Method()
        {
            List<string> items = new List<string> { "Apple", "Banana", "Cherry", "Mango", "Orange" };

            Parallel.ForEach(items, item =>
            {
                Console.WriteLine($"Processing {item} on thread {Task.CurrentId}");
            });

            Console.WriteLine("Parallel processing completed.");
        }
    }
}
