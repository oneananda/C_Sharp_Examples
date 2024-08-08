using System;

class Program
{
    static void Main()
    {
        Guid guid = Guid.NewGuid();
        Console.WriteLine(guid.ToString("B")); // Outputs: {xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}
    }
}
