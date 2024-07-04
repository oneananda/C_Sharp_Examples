using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Multiple_Parameters
    {
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Multiple_Parameters");
            // Action delegate with two parameters
            Action<int, string> printDetails = (age, name) =>
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            };

            printDetails(25, "Abc Xyz");
        }
    }
}
