using Error_Handling_Deep_Dive._02_Custom_Exceptions;

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

            try
            {
                string userEmail = "invalidemail.com"; // Invalid email
                validator.ValidateEmail(userEmail);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("Error_Handling_Deep_Dive!");
        }
    }
}
