/*
Composite formatting allows you to combine multiple values 
into a single formatted string using the String.Format method, 
which internally calls ToString() on each object.
*/
using System;

class Program
{
    static void Main()
    {
        int age = 30;
        double height = 5.9;
        string name = "Happy Man";

        string formattedString = string.Format("Name: {0}, Age: {1}, Height: {2} ft", name, age, height);
        Console.WriteLine(formattedString); // Outputs: Name: Happy Man, Age: 30, Height: 5.9 ft

        Console.ReadLine();
    }
}
