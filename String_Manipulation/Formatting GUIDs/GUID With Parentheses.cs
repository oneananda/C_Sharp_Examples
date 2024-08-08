using System;

class Program
{
    static void Main()
    {
        Guid guid = Guid.NewGuid();
        Console.WriteLine(guid.ToString("P")); // Outputs: (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
    }
}
