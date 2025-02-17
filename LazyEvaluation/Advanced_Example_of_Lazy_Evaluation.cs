using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyEvaluation
{
    class DatabaseConnection
    {
        public string ConnectionString { get; }
        public bool IsOpen { get; }

        public DatabaseConnection(string connectionString)
        {
            Console.WriteLine("Initializing Database Connection...");
            ConnectionString = connectionString;
            IsOpen = true; // Simulate opening a connection
        }
    }
    public class Advanced_Example_of_Lazy_Evaluation
    {

    }
}
