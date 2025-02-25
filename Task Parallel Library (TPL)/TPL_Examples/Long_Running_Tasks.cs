using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Long_Running_Tasks
    {
        public static void Long_Running_Tasks_Method()
        {
            Task longRunningTask = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(2000);
                }
            }, TaskCreationOptions.LongRunning);

            Console.ReadLine(); // Keep the program running
        }
    }
}
