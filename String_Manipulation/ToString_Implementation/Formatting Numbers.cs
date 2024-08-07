using System;

class Program
{
    static void Main()
    {
        int number = 12345;
        Console.WriteLine(number.ToString("N0")); // Outputs: 12,345 (thousands separator)

        double price = 1234.56;
        Console.WriteLine(price.ToString("C")); // Outputs: $1,234.56 (currency format based on culture)

        double percent = 0.1234;
        Console.WriteLine(percent.ToString("P")); // Outputs: 12.34 % (percent format)
    }
}
