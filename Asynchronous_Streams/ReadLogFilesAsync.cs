using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Streams
{
    public class ReadLogFilesAsync
    {
        public static async Task MediumExampele()
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Log", "random_log.txt");
            
            await foreach (var line in ReadFileAsync(filePath))
            {
                Console.WriteLine(line);
            }
        }
        static async IAsyncEnumerable<string> ReadFileAsync(string filePath)
        {
            using var reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
            {
                var line = await reader.ReadLineAsync();
                yield return line;
            }
        }
    }
}
