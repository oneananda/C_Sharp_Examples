using System;

class Program
{
    static void Main()
    {
        object obj = new object();


        // The ToString() method is available in all types,
        // derived from the base Object class.
        // By default, it returns the fully qualified name of the object's type.

        Console.WriteLine(obj.ToString()); // Outputs: System.Object
    }
}
