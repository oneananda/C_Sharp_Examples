using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Logging_Framework
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Implementation for logging to a database
            Console.WriteLine($"Logging to database: {message}");
        }
    }
}
