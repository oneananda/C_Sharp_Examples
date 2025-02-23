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
            string op1 = "Add";
            Task<int> task = Task.Run(async () =>
            {
                Console.WriteLine($"Calculating {op1}");
                return await CalculateValue(2, 4, op1);
            });


            string op2 = "Subtract";

            Task<int> task2 = Task.Run(async () =>
            {
                Console.WriteLine($"Calculating {op2}");
                return await CalculateValue(6, 2, op2);
            });

            string op3 = "Divide";

            Task<int> task3 = Task.Run(async () =>
            {
                Console.WriteLine($"Calculating {op3}");
                return await CalculateValue(10, 5, op3);
            });

            Console.WriteLine($"Task1 Result: {task.Result}"); // Blocks until task completes
            Console.WriteLine($"Task2 Result: {task2.Result}"); // Blocks until task completes
            Console.WriteLine($"Task3 Result: {task3.Result}"); // Blocks until task completes
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
                case "Divide": return v1 / v2;
                default: return v1 + v2;
            }
        }
    }
}
