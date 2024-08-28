namespace Async_Programming
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"Starting application at {GetTimeStamp()}!");

            string data = await FetchDataFromWebAsync();

            string data2 = GetDataNormally();

            Console.WriteLine($"Fetched via normal at {GetTimeStamp()}!");

            Console.WriteLine(string.Empty);
            
            Console.WriteLine(data + $"Fetched via async at {GetTimeStamp()}!");
            
            Console.ReadLine(); // Hold the screen
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
