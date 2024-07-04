using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Passing_Action_As_Parameter
    {
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Passing_Action_As_Parameter");
            // Method that accepts an Action delegate
            void PerformAction(Action action)
            {
                Console.WriteLine("Before action");
                action();
                Console.WriteLine("After action");
            }

            Action myAction = () => Console.WriteLine("Action executed");

            PerformAction(myAction);
        }

    }
}
