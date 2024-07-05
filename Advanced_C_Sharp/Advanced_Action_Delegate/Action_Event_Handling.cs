using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Action_Delegate
{
    internal class Action_Event_Handling
    {
        // Declaring Func as event
        static event Action OnNotify;
        public static void ActionMethod()
        {
            Console.WriteLine($"Using Action_Event_Handling");

            OnNotify += Action_Event_Handling_OnNotify;
            OnNotify += () => Console.WriteLine("Action Event triggered");

            OnNotify?.Invoke(); // ? symbol will check for null
        }

        private static void Action_Event_Handling_OnNotify()
        {
            Console.WriteLine("Regular Event triggered");
        }
    }
}
