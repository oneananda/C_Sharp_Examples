using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Producer_Consumer_Pattern
    {
        public static void Producer_Consumer_Pattern_Method() 
        {
            BlockingCollection<int> queue = new BlockingCollection<int>();

            Task producer = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    queue.Add(i);
                    Console.WriteLine($"Produced: {i}");
                    Thread.Sleep(500);
                }
                queue.CompleteAdding();
            });

            Task consumer = Task.Run(() =>
            {
                foreach (var item in queue.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Consumed: {item}");
                    Thread.Sleep(1000);
                }
            });

            Task.WaitAll(producer, consumer);
        }
    }
}
