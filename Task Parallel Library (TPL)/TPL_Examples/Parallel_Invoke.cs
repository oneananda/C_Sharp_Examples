using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Parallel_Invoke
    {
        public static void Parallel_Invoke_Method()
        {
            Parallel.Invoke(
              () => Console.WriteLine("Task 1 running"),
              () => Console.WriteLine("Task 2 running"),
              () => Console.WriteLine("Task 3 running")
            );
        }
    }
}
