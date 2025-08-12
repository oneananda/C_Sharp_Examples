using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive_Extensions_Rx.NET
{
    internal class Timer_Interval_Stream
    {
        public static void Run()
        {
            // Create an observable that emits a value every second
            var timerObservable = System.Reactive.Linq.Observable.Interval(TimeSpan.FromSeconds(1));
            // Subscribe to the observable
            timerObservable.Subscribe(
                onNext: value => Console.WriteLine($"Tick: {value}"),
                onCompleted: () => Console.WriteLine("Timer completed."),
                onError: ex => Console.WriteLine($"Error occurred: {ex.Message}")
            );
            // Keep the console window open for a while to see the output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
