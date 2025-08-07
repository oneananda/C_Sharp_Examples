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
            Console.WriteLine("Error_Handling_Deep_Dive!");
        }
    }
}
