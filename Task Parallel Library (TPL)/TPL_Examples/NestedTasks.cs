using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class NestedTasks
    {
        public static async Task NestedTasks_Method()
        {
            Task parentTask = Task.Run(async () =>
            {
                Console.WriteLine("Parent task started.");

                Task childTask = Task.Run(() =>
                {
                    Console.WriteLine("Child task running...");
                    Task.Delay(2000).Wait();
                    Console.WriteLine("Child task completed.");
                });

                await childTask;
                Console.WriteLine("Parent task completed.");
            });

            await parentTask;
        }
    }
}
