using Polly;
using Polly.CircuitBreaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._05_Resilience_And_Retry
{
    public static class CircuitBreaker
    {
        private static int _counter = 0;

        public static async Task Run()
        {
            var breaker = Policy
                .Handle<Exception>()
                .CircuitBreakerAsync(
                    exceptionsAllowedBeforeBreaking: 3,
                    durationOfBreak: TimeSpan.FromSeconds(10),
                    onBreak: (ex, breakDelay) =>
                    {
                        Console.WriteLine($"[BREAK] Circuit open for {breakDelay.TotalSeconds:n0}s. Reason: {ex.Message}");
                    },
                    onReset: () => Console.WriteLine("[RESET] Circuit closed; operations normal."),
                    onHalfOpen: () => Console.WriteLine("[HALF-OPEN] Trial call is permitted."));

            // Simulated work: first 5 calls fail; later ones succeed
            for (int i = 1; i <= 12; i++)
            {
                await Task.Delay(700);
                try
                {
                    await breaker.ExecuteAsync(DoWorkAsync);
                    Console.WriteLine($"Call {i}: SUCCESS");
                }
                catch (BrokenCircuitException)
                {
                    Console.WriteLine($"Call {i}: FAST-FAIL (circuit OPEN)");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Call {i}: FAILED => {ex.Message}");
                }
            }
        }

        private static Task DoWorkAsync()
        {
            _counter++;
            if (_counter <= 5)
            {
                throw new InvalidOperationException($"Simulated failure #{_counter}");
            }

            // After some time we succeed
            return Task.CompletedTask;
        }
    }
}
