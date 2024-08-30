using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Deep_Dive
{
    public delegate void PrintDelegateForAnonymous(string message);
    internal class AnonymousMethodExample
    {
        public static void AnonymousMethod()
        {
            Console.WriteLine($"Example 4 : Anonymous Method Example");
            PrintDelegateForAnonymous pda = delegate (string message)
            {
                Console.WriteLine(message);
            };
            pda("Hello from an anonymous method!");
            Console.WriteLine(string.Empty);    
        }
    }
}
