using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class TaskFactoryExample
    {
        public static async Task TaskFactoryExample_Method()
        {
            TaskFactory factory = new TaskFactory();
            Task[] tasks = new Task[3];

            for (int i = 0; i < 3; i++)
            {
                int taskNum = i;
                tasks[i] = factory.StartNew(() =>
                {
                    Console.WriteLine($"Task {taskNum} is running.");
                });
            }

            await Task.WhenAll(tasks);
            Console.WriteLine("All tasks completed.");
        }
    }
}
