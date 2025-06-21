namespace Basic_Debugging
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start Main");
            await DoWorkAsync();
            Console.WriteLine("End Main");
        }

        static async Task DoWorkAsync()
        {
            Console.WriteLine("Start DoWorkAsync");

            // Simulate async work
            await Task.Delay(1000);

            Console.WriteLine("Middle of DoWorkAsync");

            // Simulate more async work
            var result = await GetDataAsync();

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("End DoWorkAsync");
        }

        static async Task<string> GetDataAsync()
        {
            Console.WriteLine("Fetching data...");
            await Task.Delay(500); // Simulate IO delay
            return "Hello from Task!";
        }
    }
}
