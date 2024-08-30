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
        public void AnonymousMethod()
        {
            PrintDelegateForAnonymous pda = delegate (string message)
            {
                Console.WriteLine(message);
            };
            pda("Hello from an anonymous method!");
        }
    }
}
