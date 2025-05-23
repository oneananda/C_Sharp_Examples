﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer_Pattern
{
    public class UsingConcurrentQueue
    {
        static ConcurrentQueue<int> queue = new ConcurrentQueue<int>(); // Thread-safe queue
        static SemaphoreSlim semaphore = new SemaphoreSlim(0); // Controls consumer waiting
        public static void UsingConcurrentQueue_Method()
        {
            // Producer Task
            Task producer = Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    queue.Enqueue(i); // Add item to the queue
                    Console.WriteLine($"[Producer] Produced: {i}");

                    semaphore.Release(); // Signal the consumer that an item is available
                    Thread.Sleep(500); // Simulating work
                }
            });

            // Consumer Task
            Task consumer = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    semaphore.Wait(); // Wait until an item is available
                    if (queue.TryDequeue(out int item))
                    {
                        Console.WriteLine($"[Consumer] Consumed: {item}");
                        Thread.Sleep(1000); // Simulating processing
                    }
                }
            });

            Task.WaitAll(producer, consumer);
            Console.WriteLine("[Main] Processing complete.");
        }
    }
}
