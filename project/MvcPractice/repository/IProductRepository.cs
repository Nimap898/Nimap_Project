using MVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.repository
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
