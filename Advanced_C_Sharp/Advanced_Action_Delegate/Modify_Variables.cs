using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Modify_Variables
    {
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Modify_Variables");
            int result = 0;

            // Action delegate to modify a variable
            Action<int, int> addNumbers = (a, b) =>
            {
                result = a + b;
            };

            addNumbers(5, 7);
            Console.WriteLine($"Result: {result}");
        }
    }
}
