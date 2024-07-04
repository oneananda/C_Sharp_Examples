namespace Advanced_Func_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic_Func.GetEvenNumbers();

            Combining_multiple_func_delegates.AddAndThenSquare();

            Combining_multiple_func_delegates.SquareAndThenSquare();

            Console.ReadLine();
        }
    }
}
