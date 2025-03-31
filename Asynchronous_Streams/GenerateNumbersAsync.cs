using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Streams
{
    public class GenerateNumbersAsync
    {
        public static async Task BasicExampele()
        {
            await foreach (var num in GenerateNumbersAsyncMethod())
            {
                Console.WriteLine(num);
            }
        }
        static async IAsyncEnumerable<int> GenerateNumbersAsyncMethod()
        {
            for (int i = 1; i <= 500; i++)
            {
                await Task.Delay(10); // Simulate async work
                yield return i;
            }
        }
    }
}
