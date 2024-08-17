using CQRS_Basic_Implementation.Models;
using CQRS_Basic_Implementation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Basic_Implementation.Commands.Products
{
    public class ProductCommandHandler
    {
        private readonly ProductRepository _productRepository;

        public ProductCommandHandler(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Handle(AddProductCommand command)
        {
            var product = new Product
            {
                Id = command.Id,
                Name = command.Name,
                Price = command.Price,
            };
            _productRepository.Add(product);
        }

        public void Handle(UpdateProductCommand command)
        {
            var product = _productRepository.Get(command.Id);
            if (product != null)
            {
                product.Name = command.Name;
                product.Price = command.Price;
            }
        }
    }
}
