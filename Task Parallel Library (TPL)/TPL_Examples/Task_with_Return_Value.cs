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
            string calculateOperation = "Add";
            Task<int> task = Task.Run(() =>
            {
                Console.WriteLine("");
                return CalculateValue(2, 4, calculateOperation);
            });
            

            calculateOperation = "Subtract";

            Task<int> task2 = Task.Run(() =>
            {
                Console.WriteLine("");
                return CalculateValue(10, 4, calculateOperation);
            });

            Console.WriteLine($"Result: {task.Result}"); // Blocks until task completes
            Console.WriteLine($"Result: {task2.Result}"); // Blocks until task completes
        }

        private static async Task<int>? CalculateValue(int v1, int v2, string calculateOperation)
        {
            // Applying more waits to see the behaviour

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine($"Sleeping for time being! {calculateOperation}");
                Thread.Sleep(1000);
            }
            switch (calculateOperation)
            {
                case "Add": return v1 + v2;
                case "Subtract": return v1 - v2;
                default: return v1 + v2;
            }
        }
    }
}
