using CQRS_Basic_Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Basic_Implementation.Repositories
{
    public class ProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Product Get(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
