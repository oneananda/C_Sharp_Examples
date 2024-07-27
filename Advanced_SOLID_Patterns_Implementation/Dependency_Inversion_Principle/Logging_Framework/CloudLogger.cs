using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Logging_Framework
{
    public class CloudLogger : ILogger
    {
        public void Log(string message)
        {
            // Implementation for logging to the cloud
            Console.WriteLine($"Logging to cloud: {message}");
        }
    }
}
