using GeneratedInterfaces;

namespace T4_Template_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("T4 Template Implementation");

            ICustomer myObject = new Customer
            {
                Id = 1,
                Name = "Customer 1",
                CreatedDate = DateTime.Now
            };

            Console.WriteLine($"Id: {myObject.Id}");
            Console.WriteLine($"Name: {myObject.Name}");
            Console.WriteLine($"Created Date: {myObject.CreatedDate}");

            Console.ReadLine();
        }
    }
}
