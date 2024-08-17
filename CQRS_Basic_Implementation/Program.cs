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

            // Adding random products
            for (int productId = 1; productId < 20; productId++)
            {
                var addProductCommand = new AddProductCommand(productId, "Product_"+Guid.NewGuid().ToString("N").Substring(0,5), GetRandomPrice());
                productCommandHandler.Handle(addProductCommand);
            }

            Console.ReadLine();
        }

        private static decimal GetRandomPrice()
        {
            string randomString = Guid.NewGuid().ToString("N");
            char firstChar = randomString[0];
            decimal randomPrice = (decimal)firstChar * 3;
            return randomPrice;
        }
    }
}
