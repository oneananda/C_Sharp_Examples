using System;
using System.IO;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
    public class CustomExceptionWithLogging : Exception
    {
        public string LogFilePath { get; set; } = "error_log.txt";
        public DateTime Timestamp { get; } = DateTime.Now;

        public CustomExceptionWithLogging() : base("An error occurred in the application.") { }

        public CustomExceptionWithLogging(string message) : base(message) { }

        public CustomExceptionWithLogging(string message, Exception innerException)
            : base(message, innerException) { }

        public void LogError()
        {
            string logMessage = $"{Timestamp}: {Message}";
            if (InnerException != null)
            {
                logMessage += $"\nInner Exception: {InnerException.Message}";
            }
            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);
        }

        public override string ToString()
        {
            return $"{Timestamp}: {Message}";
        }

        public static void Run()
        {
            Console.WriteLine("== Custom Exception with Logging Demo ==");
            try
            {
                SimulateError();
            }
            catch (CustomExceptionWithLogging ex)
            {
                ex.LogError();
                Console.WriteLine($"Custom exception caught: {ex.Message}");
                Console.WriteLine($"Logged to: {ex.LogFilePath}");
            }
        }

        static void SimulateError()
        {
            try
            {
                // Simulate an error
                throw new InvalidOperationException("An unexpected error occurred.");
            }
            catch (InvalidOperationException ex)
            {
                // Wrap it in a custom exception with logging
                var customEx = new CustomExceptionWithLogging("An error occurred while simulating an operation.", ex);
                throw customEx;
            }
        }
    }
}