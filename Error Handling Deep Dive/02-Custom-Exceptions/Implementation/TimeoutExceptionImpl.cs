using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions.Implementation
{
    public class TimeoutExceptionImpl
    {
        public static void SimulateLongRunningOperation(string operationName, TimeSpan allowedTime)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Simulate work (3 seconds, which exceeds the allowed 2 seconds)
            Thread.Sleep(3000);

            stopwatch.Stop();

            if (stopwatch.Elapsed > allowedTime)
            {
                string message = $"{operationName} timed out after {allowedTime.TotalSeconds} seconds.";
                throw new TimeoutException(message);
            }

            Console.WriteLine("Operation completed successfully.");
        }
    }
}
