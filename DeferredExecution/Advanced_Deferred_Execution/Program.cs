namespace Advanced_Deferred_Execution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplier = 2;

            IEnumerable<int> numbers = GenerateNumbers();

            Console.WriteLine("Advanced_Deferred_Execution!");
        }
        static IEnumerable<int> GenerateNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Generating number: {i}");
                Thread.Sleep(500); // Simulate a delay in data generation.
                yield return i;
            }
        }
    }
}
