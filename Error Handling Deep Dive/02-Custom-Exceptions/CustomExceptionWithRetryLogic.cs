using System;
using System.Threading;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
    public class CustomExceptionWithRetryLogic : Exception
    {
        public int RetryAttempts { get; }
        public TimeSpan DelayBetweenRetries { get; }
        public int AttemptsPerformed { get; private set; }

        public CustomExceptionWithRetryLogic(string message, int retryAttempts = 3, TimeSpan? delayBetweenRetries = null)
            : base(message)
        {
            RetryAttempts = retryAttempts;
            DelayBetweenRetries = delayBetweenRetries ?? TimeSpan.FromSeconds(2);
            AttemptsPerformed = 0;
        }

        public CustomExceptionWithRetryLogic(string message, Exception innerException, int retryAttempts = 3, TimeSpan? delayBetweenRetries = null)
            : base(message, innerException)
        {
            RetryAttempts = retryAttempts;
            DelayBetweenRetries = delayBetweenRetries ?? TimeSpan.FromSeconds(2);
            AttemptsPerformed = 0;
        }

        public static void ExecuteWithRetry(Action action, int maxRetries = 3, TimeSpan? delayBetweenRetries = null)
        {
            var delay = delayBetweenRetries ?? TimeSpan.FromSeconds(2);
            Exception? lastException = null;

            for (int attempt = 1; attempt <= maxRetries; attempt++)
            {
                try
                {
                    action();
                    return; // If successful, exit the method
                }
                catch (Exception ex) when (ex is not CustomExceptionWithRetryLogic)
                {
                    lastException = ex;
                    if (attempt < maxRetries)
                    {
                        Console.WriteLine($"Attempt {attempt} failed. Retrying in {delay.TotalSeconds} seconds...");
                        Thread.Sleep(delay);
                    }
                }
            }

            throw new CustomExceptionWithRetryLogic(
                $"Operation failed after {maxRetries} attempts",
                lastException!,
                maxRetries,
                delay);
        }

        public static async Task ExecuteWithRetryAsync(Func<Task> action, int maxRetries = 3, TimeSpan? delayBetweenRetries = null)
        {
            var delay = delayBetweenRetries ?? TimeSpan.FromSeconds(2);
            Exception? lastException = null;

            for (int attempt = 1; attempt <= maxRetries; attempt++)
            {
                try
                {
                    await action();
                    return; // If successful, exit the method
                }
                catch (Exception ex) when (ex is not CustomExceptionWithRetryLogic)
                {
                    lastException = ex;
                    if (attempt < maxRetries)
                    {
                        Console.WriteLine($"Attempt {attempt} failed. Retrying in {delay.TotalSeconds} seconds...");
                        await Task.Delay(delay);
                    }
                }
            }

            throw new CustomExceptionWithRetryLogic(
                $"Operation failed after {maxRetries} attempts",
                lastException!,
                maxRetries,
                delay);
        }

        public static void Run()
        {
            Console.WriteLine("== Custom Exception with Retry Logic Demo ==");

            // Example 1: Synchronous operation with retry
            try
            {
                CustomExceptionWithRetryLogic.ExecuteWithRetry(() =>
                {
                    SimulateUnstableOperation();
                }, maxRetries: 3, delayBetweenRetries: TimeSpan.FromSeconds(1));
            }
            catch (CustomExceptionWithRetryLogic ex)
            {
                Console.WriteLine($"Final error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Original error: {ex.InnerException.Message}");
                }
            }

            // Example 2: Asynchronous operation with retry
            Task.Run(async () =>
            {
                try
                {
                    await CustomExceptionWithRetryLogic.ExecuteWithRetryAsync(async () =>
                    {
                        await SimulateUnstableOperationAsync();
                    }, maxRetries: 3, delayBetweenRetries: TimeSpan.FromSeconds(1));
                }
                catch (CustomExceptionWithRetryLogic ex)
                {
                    Console.WriteLine($"Final error: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"Original error: {ex.InnerException.Message}");
                    }
                }
            }).Wait();
        }

        private static void SimulateUnstableOperation()
        {
            var random = new Random();
            if (random.Next(100) < 70) // 70% chance of failure
            {
                throw new InvalidOperationException("Simulated transient error occurred");
            }
            Console.WriteLine("Operation completed successfully!");
        }

        private static async Task SimulateUnstableOperationAsync()
        {
            await Task.Delay(100); // Simulate some async work
            SimulateUnstableOperation();
        }
    }
}