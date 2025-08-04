namespace Error_Handling_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _01_Basic_Error_Handling.Basic_Error_Handling.Run();
            _01_Basic_Error_Handling.TryCatchFinally.Run();
            _01_Basic_Error_Handling.CommonExceptions.Run();
            Console.WriteLine("Error_Handling_Deep_Dive!");
        }
    }
}
