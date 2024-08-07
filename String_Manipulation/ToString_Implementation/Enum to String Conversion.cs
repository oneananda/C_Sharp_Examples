using System;

enum Colors
{
    Red,
    Green,
    Blue
}

class Program
{
    static void Main()
    {
        Colors color = Colors.Green;
        Console.WriteLine(color.ToString()); // Outputs: Green
    }
}
