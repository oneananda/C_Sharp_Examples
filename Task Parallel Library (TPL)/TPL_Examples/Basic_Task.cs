using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Basic_Task
    {
        public static void BasicTaskMethod(bool canWait)
        {
            Task task = Task.Run(() =>
            {
                for (int counter = 1; counter < 10; counter++)
                    Console.WriteLine($"Task is running in a separate thread! Counter is {counter}..");
            });
            if (canWait)
                task.Wait();

            for (int counter = 1; counter < 10; counter++)
                Console.WriteLine($"Main thread is running in a separate thread! Counter is {counter}..");
            Console.WriteLine("Main thread continues...");
        }
    }
}
