namespace Async_Programming
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


            Console.ReadLine(); // Hold the screen
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
