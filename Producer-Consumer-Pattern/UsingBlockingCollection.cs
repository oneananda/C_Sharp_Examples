using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer_Pattern
{
    public class UsingBlockingCollection
    {
        public static void UsingBlockingCollection_Method()
        {
            // The producer thread generates numbers and adds them to the collection.

            BlockingCollection<int> blockingCollection = new BlockingCollection<int>(boundedCapacity: 5); // Bounded capacity of 5

            // Producer Task
            Task producer = Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    blockingCollection.Add(i); // Add item to the collection
                    Console.WriteLine($"Produced: {i}");
                    Thread.Sleep(500); // Simulate work
                }
                blockingCollection.CompleteAdding(); // Mark as complete
            });
        }
    }
}
