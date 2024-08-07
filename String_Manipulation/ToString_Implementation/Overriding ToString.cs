using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{FirstName}, {LastName}";
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person { FirstName = "John", LastName = "Doe" };
        Console.WriteLine(person.ToString()); // Outputs: John, Doe
    }
}
