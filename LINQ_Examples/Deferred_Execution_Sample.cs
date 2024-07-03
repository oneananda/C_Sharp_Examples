namespace Deferred_Execution_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Deferred execution
            var query = numbers.Where(n => n > 2);

            // The query is not executed yet
            numbers.Add(6);

            foreach (var number in query) // Deferred Execution is happening
            {
                Console.WriteLine(number); // Output: 3, 4, 5, 6
            }


            // Example 2
            List<string> fruits = new List<string> { "apple", "banana", "cherry", "date" };

            // Deferred execution
            var query2 = fruits.Where(f => f.Contains('a')).Select(f => f.ToUpper());

            // The query is not executed yet
            fruits.Add("avocado");

            foreach (var fruit in query2) // Deferred Execution is happening
            {
                Console.WriteLine(fruit); // Output: APPLE, BANANA, AVOCADO
            }



            Console.ReadLine();
        }
    }
}
