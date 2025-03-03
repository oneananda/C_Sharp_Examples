namespace Producer_Consumer_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Producer-Consumer Pattern
            UsingBlockingCollection.UsingBlockingCollection_Method();

            // Multiple Producers & Consumers
            UsingBlockingCollection_Multiple_Producers_Consumers.Multiple_Producers_Consumers_Method();

            // Using ConcurrentQueue
            UsingConcurrentQueue.UsingConcurrentQueue_Method();

            Console.WriteLine("Hello, Producer-Consumer Pattern!");
        }
    }
}
