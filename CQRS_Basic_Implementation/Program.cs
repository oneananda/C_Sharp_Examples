using CQRS_Basic_Implementation.Commands.Products;
using CQRS_Basic_Implementation.Repositories;

namespace CQRS_Basic_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();

            // Command: Add a new product
            var productCommandHandler = new ProductCommandHandler(productRepository);
            var addProductCommand = new AddProductCommand(1, "Laptop", 100000);
            productCommandHandler.Handle(addProductCommand);

            Console.ReadLine();
        }
    }
}
