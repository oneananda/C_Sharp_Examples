using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer_Pattern
{
    public class LoggingSystem
    {
        // Thread-safe queue for storing log messages
        static ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();

        // Semaphore to signal log availability
        static SemaphoreSlim semaphore = new SemaphoreSlim(0);

        // CancellationToken to stop logging gracefully
        static CancellationTokenSource cts = new CancellationTokenSource();

        public static void LoggingSystem_Method()
        {
            // Start the log consumer in the background
            Task logConsumerTask = Task.Run(() => LogConsumer(cts.Token));

            // Simulate multiple application components generating logs
            Task[] logProducers = new Task[3];
            for (int i = 0; i < logProducers.Length; i++)
            {
                int producerId = i;
                logProducers[i] = Task.Run(() => LogProducer(producerId));
            }

            // Wait for all producers to finish logging
            Task.WaitAll(logProducers);

            // Stop logging gracefully
            Console.WriteLine("[Main] All log producers finished. Stopping log consumer...");
            cts.Cancel();
            semaphore.Release(); // Unblock consumer if it's waiting
            logConsumerTask.Wait();

            Console.WriteLine("[Main] Logging system shut down.");
        }

        // Producer: Simulates application components generating logs
        static void LogProducer(int producerId)
        {
            for (int i = 0; i < 5; i++)
            {
                string logMessage = $"[Producer {producerId}] Log message {i} at {DateTime.Now}";
                logQueue.Enqueue(logMessage);
                Console.WriteLine(logMessage);
                semaphore.Release(); // Notify the consumer
                Thread.Sleep(new Random().Next(200, 500)); // Simulate work
            }
        }

        // Consumer: Writes log messages to a file
        static void LogConsumer(CancellationToken token)
        {
            string logFilePath = "app_log.txt";
            using (StreamWriter writer = new StreamWriter(logFilePath, append: true))
            {
                while (!token.IsCancellationRequested || !logQueue.IsEmpty)
                {
                    semaphore.Wait(token); // Wait for a log message or cancellation
                    while (logQueue.TryDequeue(out string logMessage))
                    {
                        writer.WriteLine(logMessage);
                        Console.WriteLine($"[LogConsumer] Written to file: {logMessage}");
                    }
                }
            }
        }

    }
}
