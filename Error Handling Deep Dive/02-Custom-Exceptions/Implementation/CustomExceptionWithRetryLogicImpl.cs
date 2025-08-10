using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions.Implementation
{
    internal class CustomExceptionWithRetryLogicImpl
    {
        public static void Run()
        {
            try
            {
                CustomExceptionWithRetryLogic.ExecuteWithRetry(() =>
                {
                    // Simulating an operation that may fail
                    Console.WriteLine("Attempting operation...");
                    throw new InvalidOperationException("Simulated failure");
                }, maxRetries: 3, delayBetweenRetries: TimeSpan.FromSeconds(1));
            }
            catch (CustomExceptionWithRetryLogic ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Operation failed after {ex.RetryAttempts} attempts. Last exception: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
