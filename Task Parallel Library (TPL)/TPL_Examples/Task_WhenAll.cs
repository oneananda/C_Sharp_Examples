using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Task_WhenAll
    {
        public async Task Task_WhenAll_Method()
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                int taskNumber = i;
                tasks.Add(Task.Run(() =>
                {
                    Console.WriteLine($"Task {taskNumber} is running.");
                }));
            }

            await Task.WhenAll(tasks); // Wait for all tasks to complete
            Console.WriteLine("All tasks completed.");

            string[] items = { "Apple", "Banana", "Cherry" };
            Parallel.ForEach(items, item =>
            {
                Console.WriteLine($"Processing {item}");
            });
        }
    }
}
