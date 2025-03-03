using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer_Pattern
{
    public class UsingBlockingCollection_Multiple_Producers_Consumers
    {
        public static void Multiple_Producers_Consumers_Method()
        {
            BlockingCollection<int> queue = new BlockingCollection<int>(10); // Bounded size of 10

            // Multiple Producers
            Task[] producers = new Task[2];
            for (int i = 0; i < 2; i++)
            {
                int producerId = i;
                producers[i] = Task.Run(() =>
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        int item = producerId * 10 + j;
                        queue.Add(item);
                        Console.WriteLine($"Producer {producerId} added: {item}");
                        Thread.Sleep(500); // Simulating work
                    }
                });
            }

            // Multiple Consumers
            Task[] consumers = new Task[3];
            for (int i = 0; i < 3; i++)
            {
                int consumerId = i;
                consumers[i] = Task.Run(() =>
                {
                    foreach (var item in queue.GetConsumingEnumerable()) // Automatically waits for new items
                    {
                        Console.WriteLine($"Consumer {consumerId} processed: {item}");
                        Thread.Sleep(1000); // Simulating processing time
                    }
                });
            }

            Task.WaitAll(producers); // Wait for all producers to finish
            queue.CompleteAdding();  // No more items will be added

            Task.WaitAll(consumers); // Wait for all consumers to finish
            Console.WriteLine("All work done!");
        }
    }
}
