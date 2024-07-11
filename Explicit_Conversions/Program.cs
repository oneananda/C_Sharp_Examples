namespace Explicit_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic_Explicit_Conversions.Example1(); // Converting `double` to `int`
            Basic_Explicit_Conversions.Example2(); // Converting `float` to `int`
            Basic_Explicit_Conversions.Example3(); // Converting `long` to `int`
            Basic_Explicit_Conversions.Example4(); // Converting `decimal` to `int`
            Basic_Explicit_Conversions.Example5(); // Converting `string` to `int` using `Parse` and `TryParse`
            Basic_Explicit_Conversions.Example6(); // Converting `object` to a specific type


            Advanced_Explicit_Conversions.Example1(); // Converting Object to Specific Type: using 'as' keyword

            Advanced_Explicit_Conversions.Example2(); // Converting Object to Specific Type: using 'as' keyword - null


            Console.ReadLine();
        }
    }
}
