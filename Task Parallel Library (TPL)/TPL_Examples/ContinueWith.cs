using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Examples
{
    public class ContinueWith
    {
        public async Task ContinueWith_Method()
        {
            Task<int> task = Task.Run(() =>
            {
                return 42;
            });

            task = task.ContinueWith(t => t.Result * 2);

            int result = await task;
            Console.WriteLine($"Result: {result}");
        }
    }
}
