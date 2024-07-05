using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Action_In_Collection
    {
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Action_In_Collection");

            var actions = new List<Action>
            {
                () => Console.WriteLine("First action"),
                () => Console.WriteLine("Second action"),
                () => Console.WriteLine("Third action")
            };

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
