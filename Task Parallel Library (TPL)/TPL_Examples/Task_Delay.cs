using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Task_Delay
    {
        public static async Task Task_Delay_Method()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Task delayTask = Task.Delay(5000, cts.Token); // 5 seconds delay

            Task workTask = Task.Run(async () =>
            {
                await Task.Delay(3000); // Simulate work
                Console.WriteLine("Work completed before timeout.");
                cts.Cancel(); // Cancel the timeout
            });

            await Task.WhenAny(delayTask, workTask);

            if (delayTask.IsCompleted)
                Console.WriteLine("Task timed out.");
            else
                Console.WriteLine("Task completed within time.");
        }
    }
}
