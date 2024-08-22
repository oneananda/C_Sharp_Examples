using System.Diagnostics.Metrics;

namespace ref_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Basic implementation of 'ref'
            int num = 10;
            Console.WriteLine($"Before method call: {num}");

            ModifyValue(ref num);

            Console.WriteLine($"After method call: {num}");

            // Output
            // Before method call: 10
            // After method call: 20

            Console.ReadLine();
        }

        static void ModifyValue(ref int x)
        {
            x = x * 2;
        }
    }
}
