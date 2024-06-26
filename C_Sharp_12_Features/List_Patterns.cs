namespace List_Patterns_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            bool result = numbers is [1, 2, 3, 4]; 
            Console.WriteLine(result); // true

            Console.WriteLine(string.Empty);

            bool result2 = numbers is [1, 2, ..]; 
            Console.WriteLine(result2); // true, matches any list starting with 1, 2

            Console.WriteLine(string.Empty);

            bool result3 = numbers is [1, 3, ..];
            Console.WriteLine(result3); // false, not matches any list starting with 1, 3

            Console.ReadLine();

            //Console.WriteLine("Hello, World!");
        }
    }
}
