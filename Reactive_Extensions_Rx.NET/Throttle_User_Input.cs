using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive_Extensions_Rx.NET
{
    internal class Throttle_User_Input
    {
        public static void Run()
        {
            // Create an observable sequence that simulates user input events
            var userInput = System.Reactive.Linq.Observable.Interval(TimeSpan.FromMilliseconds(100))
                .Select(i => $"Input {i}");
            // Throttle the user input to only allow one event every 500 milliseconds
            var throttledInput = userInput.Throttle(TimeSpan.FromMilliseconds(500));
            // Subscribe to the throttled input sequence
            throttledInput.Subscribe(
                onNext: input => Console.WriteLine($"Received: {input}"),
                onCompleted: () => Console.WriteLine("Sequence completed."),
                onError: ex => Console.WriteLine($"Error occurred: {ex.Message}")
            );
            // Keep the console window open for a while to observe the output
            Console.ReadLine();
        }
    }
}
