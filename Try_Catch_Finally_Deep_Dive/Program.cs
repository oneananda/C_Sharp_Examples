using System.Reflection;

namespace Try_Catch_Finally_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Normal_Try_Catch_Finally.Example1(); // Initial Value
            Introducing_an_Error.Example1(); // Catch Value
            Assigning_Values_in_Finally_Block.Example1();
            // Returned Value: Catch Value
            // Passing Value: Finally Value
            Console.ReadLine();
        }
    }
}
