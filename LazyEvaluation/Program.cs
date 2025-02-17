namespace LazyEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic example

            // Lazy initialization of a string
            Lazy<string> lazyString = new Lazy<string>(() => Basic_Example_of_Lazy_Evaluation.ComputeExpensiveString());

            // The computation won't happen until the value is accessed.
            Console.WriteLine("Before accessing lazy string.");

            // Accessing the Value triggers the computation
            Console.WriteLine("Lazy Value: " + lazyString.Value);

            Console.WriteLine("After accessing lazy string.");

            // Advanced example

            // Lazy initialization of a resource-heavy object
            Lazy<DatabaseConnection> lazyDbConnection = new Lazy<DatabaseConnection>(() => new DatabaseConnection("MyConnectionString"));

            Console.WriteLine("Before accessing the DB connection.");

            // The database connection will only be created when it's first used
            var connection = lazyDbConnection.Value;
            Console.WriteLine("Database Connection Initialized: " + connection.IsOpen);

            // Accessing the connection again doesn't trigger any new initialization.
            connection = lazyDbConnection.Value;
            Console.WriteLine("Database Connection Reused: " + connection.IsOpen);

            Console.WriteLine("After accessing the DB connection.");



            Console.WriteLine("Lazy Evaluation!");
        }
    }
}
