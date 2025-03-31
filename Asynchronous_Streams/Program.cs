
namespace Asynchronous_Streams
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Asynchronous Streams
            // This will consume sequences of data asynchronously
            // using IAsyncEnumerable<T> and await foreach.

            //await GenerateNumbersAsync.BasicExampele();

            await ReadLogFilesAsync.MediumExampele();

            Console.WriteLine("Asynchronous Streams!");
            Console.ReadLine(); // Hold the screen
        }
    }
}
