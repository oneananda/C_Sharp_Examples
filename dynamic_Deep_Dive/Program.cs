using dynamic_Deep_Dive._01_Basics;
using dynamic_Deep_Dive._02_Intermediate;
using dynamic_Deep_Dive._03_Advanced;
using dynamic_Deep_Dive._04_RealWorld;
using System.Dynamic;

namespace dynamic_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic.Run();
            Medium.Run();
            Advanced.Run();
            RealWorld.Run();
            Console.WriteLine("Dyanamic Deep Dive!");
        }
    }
}
