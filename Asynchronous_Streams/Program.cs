
namespace Asynchronous_Streams
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Asynchronous Streams
            // This will consume sequences of data asynchronously
            // using IAsyncEnumerable<T> and await foreach.

            await BasicExampele();

            Console.WriteLine("Asynchronous Streams!");
            Console.ReadLine(); // Hold the screen
        }

        private static async Task BasicExampele()
        {
            await foreach (var num in GenerateNumbersAsync())
            {
                Console.WriteLine(num);
            }
        }
        static async IAsyncEnumerable<int> GenerateNumbersAsync()
        {
            for (int i = 1; i <= 500; i++)
            {
                await Task.Delay(10); // Simulate async work
                yield return i;
            }
        }
    }
}
