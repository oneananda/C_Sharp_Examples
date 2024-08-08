using System;

class Program
{
    static void Main()
    {
        Guid guid = Guid.NewGuid();
        // The N format specifier omits the braces and hyphens.
        Console.WriteLine(guid.ToString("N")); // Outputs: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    }
}
