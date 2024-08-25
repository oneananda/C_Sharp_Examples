namespace ref_out_Deep_Comparision
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            #region Example 1: Combining ref and out

            Console.WriteLine($"Example 1: Combining ref and out");

            int a = 5;
            int b;

            Console.WriteLine("Original value of a: " + a);

            Calculate(ref a, out b);

            Console.WriteLine("Value of a after Calculate: " + a);
            Console.WriteLine("Value of b after Calculate: " + b);

            Console.WriteLine(string.Empty);

            #endregion


            #region Example 2: Ref and Out with Object Parameters

            Console.WriteLine($"Example 2: Ref and Out with Object Parameters");

            Person person = new Person { Name = "Alex", Age = 30 };
            string message;

            Console.WriteLine($"Before: {person.Name}, Age: {person.Age}");

            UpdatePerson(ref person, out message);

            Console.WriteLine($"After: {person.Name}, Age: {person.Age}");
            Console.WriteLine("Message: " + message);           


            Console.WriteLine(string.Empty);

            #endregion           


            Console.ReadLine(); // To hold the screen
        }
        static void UpdatePerson(ref Person person, out string resultMessage)
        {
            // Modify the object passed by reference
            person.Age += 5;
            person.Name = "Alex Great";

            // Assign a value to the out parameter
            resultMessage = $"Updated {person.Name}'s age to {person.Age}.";
        }


        static void Calculate(ref int x, out int y)
        {
            x *= 10; // Modify x
            y = x + 5; // Assign value to y
        }
    }
}
