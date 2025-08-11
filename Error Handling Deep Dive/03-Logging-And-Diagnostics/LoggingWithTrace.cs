using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._03_Logging_And_Diagnostics
{
    public class LoggingWithTrace
    {
        public static void Run()
        {
            // Configure trace listeners
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.Listeners.Add(new TextWriterTraceListener("trace_log.txt"));
            Trace.AutoFlush = true;

            Trace.WriteLine("Application started");

            try
            {
                Trace.TraceInformation("Starting calculation...");

                int x = 10, y = 0;
                Trace.TraceInformation($"Dividing {x} by {y}");

                int result = x / y; // will throw exception
            }
            catch (DivideByZeroException ex)
            {
                Trace.TraceError($"Error occurred: {ex.Message}");
                Trace.TraceError($"StackTrace: {ex.StackTrace}");
            }
            finally
            {
                Trace.TraceInformation("Application shutting down");
            }
        }
    }
}
