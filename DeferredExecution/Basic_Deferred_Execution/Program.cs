namespace Basic_Deferred_Execution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of numbers.
            List<int> numbers = new List<int> { 1, 2, 3 };

            IEnumerable<int> query = numbers.Where(n => n > 1);

            // Modify the source collection after the query is defined.
            numbers.Add(4);

            // The query executes here when we enumerate over it.
            // It reflects the updated list: {2, 3, 4}.
            foreach (int number in query)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Basic_Deferred_Execution!");
        }
    }
}
