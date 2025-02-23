using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class Basic_Task
    {
        public static void BasicTaskMethod()
        {
            Task task = Task.Run(() =>
            {
                for (int counter = 0; counter < 1000; counter++) 
                Console.WriteLine($"Task is running in a separate thread! Counter is {counter}..");
            });
            task.Wait();
            Console.WriteLine("Main thread continues...");
        }
    }
}
