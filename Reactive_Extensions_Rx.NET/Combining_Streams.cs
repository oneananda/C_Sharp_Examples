using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive_Extensions_Rx.NET
{
    internal class Combining_Streams
    {
        public static void Run()
        {
            // Create two observable sequences
            var sequence1 = System.Reactive.Linq.Observable.Range(1, 5); // Emits 1, 2, 3, 4, 5
            var sequence2 = System.Reactive.Linq.Observable.Range(6, 5); // Emits 6, 7, 8, 9, 10
            // Combine the two sequences using CombineLatest
            var combinedSequence = sequence1.CombineLatest(sequence2, (x, y) => x + y);
            // Subscribe to the combined sequence
            combinedSequence.Subscribe(
                onNext: result => Console.WriteLine($"Combined Result: {result}"),
                onCompleted: () => Console.WriteLine("Combined sequence completed."),
                onError: ex => Console.WriteLine($"Error occurred: {ex.Message}")
            );
            // Keep the console window open for a while to observe the output
            Console.ReadLine();
        }
    }
}
