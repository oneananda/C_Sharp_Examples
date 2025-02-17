namespace LazyEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lazy initialization of a string
            Lazy<string> lazyString = new Lazy<string>(() => Basic_Example_of_Lazy_Evaluation.ComputeExpensiveString());

            // The computation won't happen until the value is accessed.
            Console.WriteLine("Before accessing lazy string.");

            // Accessing the Value triggers the computation
            Console.WriteLine("Lazy Value: " + lazyString.Value);

            Console.WriteLine("After accessing lazy string.");

            Console.WriteLine("Lazy Evaluation!");
        }
    }
}
