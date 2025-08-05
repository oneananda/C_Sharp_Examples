using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._02_Custom_Exceptions
{
    // Base exception for file operations
    public class FileOperationException : Exception
    {
        public FileOperationException(string message, Exception innerException = null)
            : base(message, innerException) { }
    }

    // Specific exception for file reading
    public class FileReadException : FileOperationException
    {
        public FileReadException(string filePath, Exception innerException)
            : base($"Failed to read file: {filePath}", innerException) { }
    }

    class InheritanceAndInnerExceptions
    {
        static void Main()
        {
            Console.WriteLine("== Exception Inheritance and InnerException Demo ==");

            try
            {
                string content = ReadFile("nonexistent.txt");
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (FileReadException ex)
            {
                Console.WriteLine($"Custom exception caught: {ex.Message}");
                Console.WriteLine($"Inner exception: {ex.InnerException?.Message}");
            }
        }

        static string ReadFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                throw new FileReadException(filePath, ex);
            }
        }
    }
}
