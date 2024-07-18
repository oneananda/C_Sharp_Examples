using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancellationToken_Implementation
{
    internal class WithAwaitOperation
    {
        public static async void DoWork()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine($"Cancellation (WithAwaitOperation) requested!");
                        return;
                    }
                    Console.WriteLine($"Task running (WithAwaitOperation) iteration {i + 1}");
                    Thread.Sleep(1000); // Simulate some work
                }
                Console.WriteLine($"Task completed (WithAwaitOperation) successfully.");
            }, cancellationToken);


            // wait for some time
            await Task.Delay(3500);

            cancellationTokenSource.Cancel();

            try
            {
                // Await the task to observe any OperationCanceledException
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Task was cancelled and caught OperationCanceledException.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Task threw an exception: {ex.Message}");
            }

            // With await task; 
            Console.WriteLine("DoWork - WithAwaitOperation method finished.");           
        }
    }
}
