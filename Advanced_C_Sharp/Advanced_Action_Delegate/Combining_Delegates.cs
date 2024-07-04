using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Combining_Delegates
    {
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Combining_Delegates");
            Action action1 = () => Console.WriteLine("Action 1");
            Action action2 = () => Console.WriteLine("Action 2");

            // Combine delegates
            Action combinedAction = action1 + action2;
            combinedAction();
        }


    }
}
