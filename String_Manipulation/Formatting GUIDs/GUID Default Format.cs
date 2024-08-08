using System;

class Program
{
    static void Main()
    {
        Guid guid = Guid.NewGuid();
        Console.WriteLine(guid.ToString()); // Outputs: {xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}
    }
}
