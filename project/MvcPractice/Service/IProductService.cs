using MVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Service
{
    internal interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
