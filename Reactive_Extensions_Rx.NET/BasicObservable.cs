using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive_Extensions_Rx.NET
{
    internal class BasicObservable
    {
        // This class demonstrates a basic observable sequence using Reactive Extensions (Rx.NET).
        // It creates an observable sequence of integers from 1 to 10 and subscribes to it.
        // The subscription prints each number received, a completion message, or an error message if an error occurs.

        public static void Run()
        {
            var numbers = Observable.Range(1, 10);
            // Subscribe to the observable sequence
            numbers.Subscribe(
            onNext: number => Console.WriteLine($"Received: {number}"),
            onCompleted: () => Console.WriteLine("Sequence completed."),
            onError: ex => Console.WriteLine($"Error occurred: {ex.Message}")
            );

        }
    }
}
