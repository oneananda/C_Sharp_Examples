using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_Deep_Dive.EnterScope_Example
{
    internal class EnterScope_Example
    {
        // EnterScope is a method that allows you to enter a scope for a given action.
        // It takes an Action as a parameter and executes it within the scope.
        public static void EnterScopeMethod(Action action)
        {
            // Here you can add any setup code that needs to run before the action.
            Console.WriteLine("Entering scope...");
            // Execute the action within the scope.
            action.Invoke();
            // Here you can add any cleanup code that needs to run after the action.
            Console.WriteLine("Exiting scope...");
        }
    }
}
