using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            var product = new Product {Name="Iphone X",Price=6000,Description="güzel telefon"};
            ViewBag.Category = "Telefonlar";
            return View(product);
        }
        public IActionResult list(int? id) 
        {
           
            var products = ProductRepo.Products;
            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepo.GetProductById(id));
        }
    }
}