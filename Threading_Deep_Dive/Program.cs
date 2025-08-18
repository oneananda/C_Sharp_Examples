namespace Threading_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage of EnterScope method
            // This method allows you to execute a block of code within a specific scope.

            EnterScope_Example.EnterScope_Example.EnterScopeMethod (() => Console.WriteLine("Hello, World!"));

            Console.WriteLine("Threading Deep Dive!");
        }
    }
}
