using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Annonymous_Method
    {
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Annonymous_Method");
            // Action delegate using anonymous method
            Action<string> greet = delegate (string name)
            {
                Console.WriteLine($"Hello, {name}!");
            };

            greet("Abc");
        }
    }
}
