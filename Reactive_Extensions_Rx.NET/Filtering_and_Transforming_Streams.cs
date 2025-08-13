using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive_Extensions_Rx.NET
{
    internal class Filtering_and_Transforming_Streams
    {
        public static void Run()
        {
            // Create an observable sequence of integers
            var numbers = System.Reactive.Linq.Observable.Range(1, 20);
            // Filter the sequence to only include even numbers and transform them by squaring
            var filteredAndTransformed = numbers
                .Where(n => n % 2 == 0) // Filter: keep only even numbers
                .Select(n => n * n);    // Transform: square the number
            // Subscribe to the filtered and transformed sequence
            filteredAndTransformed.Subscribe(
                onNext: number => Console.WriteLine($"Received: {number}"),
                onCompleted: () => Console.WriteLine("Sequence completed."),
                onError: ex => Console.WriteLine($"Error occurred: {ex.Message}")
            );
        }
    }
}
