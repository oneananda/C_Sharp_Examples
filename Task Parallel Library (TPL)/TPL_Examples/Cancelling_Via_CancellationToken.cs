using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Cancelling_Via_CancellationToken
    {
        public static void CancellationToken_Method()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task canceled.");
                        return;
                    }
                    Console.WriteLine($"Step {i}");
                    Thread.Sleep(500);
                }
            }, token);

            Thread.Sleep(1500); // Let it run for 1.5 seconds
            cts.Cancel(); // Cancel the task

            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Exception: {ex.InnerException.Message}");
            }
        }
    }
}
