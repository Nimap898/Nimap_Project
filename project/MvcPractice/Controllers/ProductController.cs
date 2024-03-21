using MVCPractice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }
        // GET: Product
        public ActionResult Index()
        { 
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}