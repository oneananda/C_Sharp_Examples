using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._06_Real_World_Scenarios
{
    class FileProcessingWithErrorHandling
    {
        public static void Run(string[] args)
        {
            string filePath = "data.txt";

            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("The file does not exist.", filePath);

                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    try
                    {
                        int number = int.Parse(line); // risky conversion
                        Console.WriteLine($"Processed number: {number}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Invalid data format: '{line}'. Error: {ex.Message}");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.FileName}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("File processing completed (with or without errors).");
            }
        }
    }
}
