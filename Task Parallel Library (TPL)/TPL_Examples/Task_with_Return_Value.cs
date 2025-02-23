using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Task_with_Return_Value
    {
        public static void ReturnValueTaskMethod()
        {
            Task<int> task = Task.Run(() =>
            {
                Console.WriteLine("");
                return CalculateValue(2, 4, "Add");
            });

            Console.WriteLine($"Result: {task.Result}"); // Blocks until task completes
        }

        private static async Task<int>? CalculateValue(int v1, int v2, string v3)
        {

            // Applying more waits to see the behaviour

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("Sleeping for time being!");
                Thread.Sleep(1000);
            }
            switch (v3)
            {
                case "Add": return v1 + v2;
                default: return v1 + v2;
            }
        }
    }
}
