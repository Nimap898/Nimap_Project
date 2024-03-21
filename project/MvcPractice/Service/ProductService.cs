using MVCPractice.Models;
using MVCPractice.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public IEnumerable<Product> GetProducts()
        {
            if (_productRepository == null)
            {
                Console.WriteLine("Product Not Found");
            }
            return _productRepository.GetAll();
        }
    }
}