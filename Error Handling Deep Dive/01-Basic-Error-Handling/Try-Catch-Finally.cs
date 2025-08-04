using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._01_Basic_Error_Handling
{
    public class TryCatchFinally
    {
        public static void Run()
        {
            Console.WriteLine("== Try-Catch-Finally Demo ==");

            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int result = 100 / number;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Input is not a valid number.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed. Cleaning up...");
            }
        }
    }
}
