using Error_Handling_Deep_Dive._02_Custom_Exceptions;
using Error_Handling_Deep_Dive._02_Custom_Exceptions.Implementation;
using Error_Handling_Deep_Dive._03_Logging_And_Diagnostics;
using Error_Handling_Deep_Dive._06_Real_World_Scenarios;
using ErrorHandlingDeepDive._02_Custom_Exceptions;

namespace Error_Handling_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _01_Basic_Error_Handling.Basic_Error_Handling.Run();
            _01_Basic_Error_Handling.TryCatchFinally.Run();
            _01_Basic_Error_Handling.CommonExceptions.Run();
            _02_Custom_Exceptions.SimpleCustomException.Run();
            _02_Custom_Exceptions.InheritanceAndInnerExceptions.Run();
            _02_Custom_Exceptions.CustomExceptionWithLogging.Run();
            
            var validator = new UserInputValidator();

            // Simulating user input validation with a custom exception
            try
            {
                string userEmail = "invalidemail.com"; // Invalid email
                validator.ValidateEmail(userEmail);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Simulating a database operation that throws a custom exception

            try
            {
                DatabaseExceptionImpl.ExecuteDatabaseOperation();
            }
            catch (DatabaseException dbEx)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Database operation failed!");
                Console.WriteLine(dbEx.ToString());
                Console.ResetColor();
            }

            // Simulating a long-running operation with a timeout
            try
            {
                TimeoutExceptionImpl.SimulateLongRunningOperation("Data Import", TimeSpan.FromSeconds(2));
            }
            catch (System.TimeoutException ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Timeout detected!");
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
            AggregateCustomExceptionImpl.Run();
            CustomExceptionWithRetryLogicImpl.Run();

            LoggingWithTrace.Run();

            NLogExample.Run();

            FileProcessingWithErrorHandling.Run();
            APIErrorResponseModel.Run();

            Console.WriteLine("Error_Handling_Deep_Dive!");
        }
    }
}
