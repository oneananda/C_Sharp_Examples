using CQRS_Basic_Implementation.Commands.Products;
using CQRS_Basic_Implementation.Queries.Products;
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
                var addProductCommand = new AddProductCommand(productId, GetRandomProduct(), GetRandomPrice());
                productCommandHandler.Handle(addProductCommand);
            }

            var productQueryHandler = new ProductQueryHandler(productRepository);
            var getAllProductsQuery = new GetAllProductsQuery();
            var getAllProducts = productQueryHandler.Handle(getAllProductsQuery);

            foreach (var product in getAllProducts)
            {
                Console.WriteLine($"Id : {product.Id}, Name : {product.Name}, Price : {product.Price} ");
            }

            Console.ReadLine();
        }

        private static string GetRandomProduct()
        {
            return "Product_" + Guid.NewGuid().ToString("N").Substring(0, 7);
        }
        private static decimal GetRandomPrice()
        {
            string randomString = Guid.NewGuid().ToString("N");
            decimal randomPrice = ((decimal)randomString[0] * (decimal)randomString[1]) * 3.14m;
            return randomPrice;
        }
    }
}
