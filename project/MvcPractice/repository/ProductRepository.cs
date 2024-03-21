using MVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository()
        {
             _context = new ApplicationDbContext();
        }

        public IEnumerable<Product> GetAll()
        {
            var products = _context.Products.ToList();

            return products;
        }
    }
}