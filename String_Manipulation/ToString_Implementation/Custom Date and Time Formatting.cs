using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss")); // Outputs: 2024-08-07 12:34:56 (example)
        Console.WriteLine(now.ToString("dddd, dd MMMM yyyy")); // Outputs: Wednesday, 07 August 2024 (example)
    }
}
