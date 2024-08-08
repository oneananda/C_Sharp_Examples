using System;

class Program
{
    static void Main()
    {
        Guid guid = Guid.NewGuid();
        Console.WriteLine(guid.ToString("X")); // Outputs: {0xXXXXXXXX,0xXXXX,0xXXXX,{0xXX,0xXX,0xXX,0xXX,0xXX,0xXX,0xXX,0xXX}}
    }
}
