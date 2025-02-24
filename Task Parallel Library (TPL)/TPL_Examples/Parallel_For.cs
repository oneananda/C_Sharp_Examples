using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Parallel_For
    {
        public static void Parallel_For_Method()
        {
            Console.WriteLine($"Parallel For Loop!");
            Parallel.For(0, 5, i =>
            {
                Console.WriteLine($"Processing {i} on thread id {Task.CurrentId}");
            });
        }
    }
}
