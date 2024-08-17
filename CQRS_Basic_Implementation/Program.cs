using CQRS_Basic_Implementation.Commands.Products;
using CQRS_Basic_Implementation.Models;
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
            for (int productId = 1; productId <= 5; productId++)
            {
                var addProductCommand = new AddProductCommand(productId, GetRandomProduct(), GetRandomPrice());
                productCommandHandler.Handle(addProductCommand);
            }
            // Fetch all the products
            FetchAllProducts(productRepository);

            // Fetching only one product with id 3
            FetchSingleProduct(productRepository, 3);

            // Fetching only one product with id 4
            FetchSingleProduct(productRepository, 4);

            Console.ReadLine();
        }

        private static void FetchSingleProduct(ProductRepository productRepository, int productId)
        {
            var productQueryHandler = new ProductQueryHandler(productRepository);
            // Fetching only one product with id 
            Console.WriteLine(string.Empty);
            Console.WriteLine($"Fetching only one product with id {productId}!");
            Console.WriteLine(string.Empty);
            var getProductQuery = new GetProductQuery(productId);
            var singleProduct = productQueryHandler.Handle(getProductQuery);
            Console.WriteLine($"Id : {singleProduct.Id}, Name : {singleProduct.Name}, Price : {singleProduct.Price} ");
            Console.WriteLine(string.Empty);
        }

        private static void FetchAllProducts(ProductRepository productRepository)
        {
            var productQueryHandler = new ProductQueryHandler(productRepository);

            var getAllProductsQuery = new GetAllProductsQuery();
            var getAllProducts = productQueryHandler.Handle(getAllProductsQuery);

            Console.WriteLine($"Fetching all the products!");
            Console.WriteLine(string.Empty);
            foreach (var product in getAllProducts)
            {
                Console.WriteLine($"Id : {product.Id}, Name : {product.Name}, Price : {product.Price} ");
            }
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
