namespace TPL_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Basic_Task.BasicTaskMethod(true);// Wait for task to run

            Basic_Task.BasicTaskMethod(false);// Can't wait for task to run, this will run in parallel

            */

            Task_with_Return_Value.ReturnValueTaskMethod();

            Console.WriteLine("Hello, World, it's Task Parallel Library (TPL)!");
        }
    }
}
