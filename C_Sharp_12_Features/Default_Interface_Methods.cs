// A considerable change in C# w.r.to interface is allowing the interfaces to have concrete methods

// An interface is defined with concrete methods, either using a lambda (expression bodied member) or a fully qualifying method like Log

//  Note that the interface is not implementing any methods at the client code and still it is building

namespace Interfaces_Example
{
    public interface ILogger
    {
        void LogError(string error) => Log(error);
        void Log(string error)
        {
            Console.WriteLine($"Error: {error}");
        }       
    }

    public class ConsoleLogger : ILogger
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.LogError("Something went wrong!");

            Console.ReadLine();
        }
    }
}

