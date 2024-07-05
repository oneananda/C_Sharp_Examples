using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Action_In_Dictionary
    {
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Action_In_Dictionary");

            var actions = new Dictionary<int, Action>();

            actions.Add(1, () => Console.WriteLine("Action 1 executed"));
            actions.Add(2, () => Console.WriteLine("Action 2 executed"));
            actions.Add(3, () => Console.WriteLine("Action 3 executed"));


            foreach (var action in actions)
            {
                action.Value();
            }

            Console.WriteLine($"Execute a particular Action from Action_In_Dictionary");

            actions[2]();
        }
    }
}
