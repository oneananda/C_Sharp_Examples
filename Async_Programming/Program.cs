﻿namespace Async_Programming
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            #region Example 1 Basic example
            Console.WriteLine($"Example 1 Basic example");

            Console.WriteLine($"Starting application at {GetTimeStamp()}!");

            string data = await FetchDataFromWebAsync();

            string data2 = GetDataNormally();

            Console.WriteLine($"Fetched via normal at {GetTimeStamp()}!");

            Console.WriteLine(string.Empty);
            
            Console.WriteLine(data + $"Fetched via async at {GetTimeStamp()}!");

            #endregion

            #region Example 2 Basic Async and Await Example
            Console.WriteLine($"Example 2 Basic Async and Await Example");

            Console.WriteLine("Starting...");
            await DoWorkAsync();
            Console.WriteLine("Finished!");

            Console.WriteLine(string.Empty);
            #endregion


            #region Example 3 Async Method Returning a Value
            Console.WriteLine($"Example 3 Async Method Returning a Value");

            Console.WriteLine("Calculating...");
            int result = await CalculateSumAsync(5, 10);
            Console.WriteLine($"Result: {result}");

            Console.WriteLine(string.Empty);
            #endregion


            #region Example 4 Handling Exceptions in Async Methods
            Console.WriteLine($"Example 4 Handling Exceptions in Async Methods");

            try
            {
                int result2 = await DivideAsync(10, 0);
                Console.WriteLine($"Result: {result2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine(string.Empty);
            #endregion




            #region Example 5 Chaining Multiple Async Calls
            Console.WriteLine($"Example 5 Chaining Multiple Async Calls");

            Console.WriteLine("Starting operations...");
            await FirstOperationAsync();
            await SecondOperationAsync();
            Console.WriteLine("All operations completed!");

            Console.WriteLine(string.Empty);
            #endregion


            #region Example 6 Using WhenAll to Run Multiple Tasks Concurrently
            Console.WriteLine($"Example 6 Using WhenAll to Run Multiple Tasks Concurrently");

            Console.WriteLine("Starting concurrent operations...");
            await Task.WhenAll(FirstOperationAsync(), SecondOperationAsync());
            Console.WriteLine("All operations completed concurrently!");

            Console.WriteLine(string.Empty);
            #endregion


            #region Example 7 Async with Cancellation Tokens
            Console.WriteLine($"Example 7 Async with Cancellation Tokens");

            var cts = new CancellationTokenSource();
            var task = LongRunningOperationAsync(cts.Token);

            // Cancel the operation after 2 seconds
            cts.CancelAfter(2000);

            try
            {
                await task;
                Console.WriteLine("Operation completed successfully.");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was canceled.");
            }

            Console.WriteLine(string.Empty);
            #endregion


            Console.ReadLine(); // Hold the screen
        }
        static async Task LongRunningOperationAsync(CancellationToken cancellationToken)
        {
            for (int i = 0; i < 5; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                Console.WriteLine($"Step {i + 1}/5");
                await Task.Delay(1000, cancellationToken); // Simulate work
            }
        }
        static async Task FirstOperationAsync()
        {
            await Task.Delay(1000); // Simulate async work
            Console.WriteLine("First operation completed.");
        }

        static async Task SecondOperationAsync()
        {
            await Task.Delay(1000); // Simulate async work
            Console.WriteLine("Second operation completed.");
        }
        static async Task<int> DivideAsync(int a, int b)
        {
            await Task.Delay(500); // Simulate async work
            return a / b; // Will throw DivideByZeroException if b is 0
        }

        static async Task<int> CalculateSumAsync(int a, int b)
        {
            await Task.Delay(1000); // Simulate an asynchronous operation
            return a + b;
        }

        static async Task DoWorkAsync()
        {
            Console.WriteLine("Working...");
            await Task.Delay(2000); // Simulates a 2-second delay.
            Console.WriteLine("Work completed.");
        }

        private static string GetDataNormally()
        {
            return Guid.NewGuid().ToString("N");
        }
        private static string GetTimeStamp()
        {
            return DateTime.Now.ToString("HH:mm:ss:ms");
        }
        private static async Task<string> FetchDataFromWebAsync()
        {
            // Simulate a web request
            await Task.Delay(2000); // Simulates a 2-second delay
            return "Data from the web";
        }
    }
}
