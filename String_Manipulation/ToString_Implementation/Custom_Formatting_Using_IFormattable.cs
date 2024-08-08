namespace IFormatableImplementation1
{
    public class Person : IFormattable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "F";

            switch (format.ToUpperInvariant())
            {
                case "F": return $"{FirstName} {LastName}";
                case "L": return LastName;
                case "I": return $"{LastName}, {FirstName}";
                default: throw new FormatException($"Format '{format}' not supported.");
            }
        }
        public override string ToString()
        {
            return ToString("F", null);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { FirstName = "Happy", LastName = "Mind" };
            Console.WriteLine(person.ToString("F", null)); // Outputs: Happy Mind
            Console.WriteLine(person.ToString("L", null)); // Outputs: Mind
            Console.WriteLine(person.ToString("I", null)); // Outputs: Mind, Happy

            Console.ReadLine();
        }
    }
}
