namespace CancellationToken_Implementation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            WithAwaitOperation.DoWork();
            WithoutAwaitOperation.DoWork();
            Console.ReadLine();
        }
    }
}
