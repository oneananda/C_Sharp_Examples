using CQRS_Basic_Implementation.Models;
using CQRS_Basic_Implementation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Basic_Implementation.Queries.Products
{
    public class ProductQueryHandler
    {
        private readonly ProductRepository _productRepository;

        public ProductQueryHandler(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProduct(GetProductQuery query)
        {
            return _productRepository.Get(query.Id);
        }
    }
}
