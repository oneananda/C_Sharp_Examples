using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double number = 9876.54;

        // Formatting for US culture
        Console.WriteLine(number.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // Outputs: $9,876.54

        // Formatting for French culture
        Console.WriteLine(number.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"))); // Outputs: 9 876,54 €
    }
}
