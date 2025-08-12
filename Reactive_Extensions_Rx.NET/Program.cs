namespace Reactive_Extensions_Rx.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BasicObservable example
            BasicObservable.Run();
            Console.WriteLine("Reactive Extensions (Rx.NET)!");

            // Timer_Interval_Stream example
            Timer_Interval_Stream.Run();

            // Filtering_and_Transforming_Streams example
            Filtering_and_Transforming_Streams.Run();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
