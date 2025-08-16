using Polly;
using Polly.Retry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._05_Resilience_And_Retry
{
    public static class RetryWithPolly
    {
        private static readonly HttpClient _http = new HttpClient { Timeout = TimeSpan.FromSeconds(2) };
        private static readonly Random _rng = new Random();

        public static async Task Run(string[] args)
        {
            using var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (_, e) => { e.Cancel = true; cts.Cancel(); };

            // Exponential backoff + jitter
            AsyncRetryPolicy<HttpResponseMessage> retryPolicy =
                Policy
                    .Handle<HttpRequestException>()
                    .OrResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                    .WaitAndRetryAsync(
                        retryCount: 5,
                        sleepDurationProvider: attempt =>
                        {
                            var backoff = TimeSpan.FromMilliseconds(200 * Math.Pow(2, attempt)); // 200ms, 400ms, 800ms...
                            var jitter = TimeSpan.FromMilliseconds(_rng.Next(0, 250));
                            return backoff + jitter;
                        },
                        onRetry: (outcome, delay, attempt, ctx) =>
                        {
                            var reason = outcome.Exception?.Message
                                         ?? $"HTTP {(int)outcome.Result.StatusCode}";
                            Console.WriteLine($"[Retry {attempt}] in {delay.TotalMilliseconds:n0} ms due to: {reason}");
                        });

            var url = args.Length > 0 ? args[0] : "https://httpbin.org/status/500,500,500,200";
            Console.WriteLine($"GET {url}");

            try
            {
                var response = await retryPolicy.ExecuteAsync(
                    async ct => await _http.GetAsync(url, ct),
                    cts.Token);

                Console.WriteLine($"Final status: {(int)response.StatusCode} {response.ReasonPhrase}");
                Console.WriteLine(await response.Content.ReadAsStringAsync(cts.Token));
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation cancelled.");
            }
        }
    }
}
