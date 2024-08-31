using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Deep_Dive.Advanced_Delegate
{
    public delegate void KeyPressHandler();
    internal class ConsoleEventHandlingExample
    {
        public event KeyPressHandler KeyPress;

        public void ListenForKey()
        {
            Console.WriteLine("Press the Enter key to trigger the event...");

            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    OnKeyPress();
                }
            }
        }

        public static void ConsoleEventHandling()
        {
            ConsoleEventHandlingExample keyListener = new ConsoleEventHandlingExample();

            // Subscribe methods to the KeyPress event
            keyListener.KeyPress += KeyListener_KeyPress1;
            keyListener.KeyPress += KeyListener_KeyPress2;

            // Start listening for key press
            keyListener.ListenForKey();
        }

        private static void KeyListener_KeyPress2()
        {
            Console.WriteLine("Enter key was pressed! (Handler 2)");
        }

        private static void KeyListener_KeyPress1()
        {
            Console.WriteLine("Enter key was pressed! (Handler 1)");
        }

        private void OnKeyPress()
        {
           if(KeyPress != null)
            {
                KeyPress();
            }
        }
    }
}
