namespace TPL_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uncomment desired method calls to see the output

            //Basic_Task.BasicTaskMethod(true);// Wait for task to run

            //Basic_Task.BasicTaskMethod(false);// Can't wait for task to run, this will run in parallel
          
            //Task_with_Return_Value.ReturnValueTaskMethod();                     

            //Parallel_For.Parallel_For_Method();

            //Parallel_Invoke.Parallel_Invoke_Method();

            Console.WriteLine("Hello, World, it's Task Parallel Library (TPL)!");
        }
    }
}
