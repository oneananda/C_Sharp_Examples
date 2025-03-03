using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer_Pattern
{
    public class Multiple_Producers_Consumers
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
        }
    }
}
