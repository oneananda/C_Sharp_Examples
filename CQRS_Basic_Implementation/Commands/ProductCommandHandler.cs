﻿using CQRS_Basic_Implementation.Models;
using CQRS_Basic_Implementation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Basic_Implementation.Commands
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
    }
}
