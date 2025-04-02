using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            // ViewBag
            // Model
            // ViewData

            var product = new Product {Name="Iphone X",Price=6000,Description="güzel telefon"};

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            // ViewBag.Product
            return View(product);
        }
         // localhost:5000/product/list
        public IActionResult list() 
        {
            var products = new List<Product>()
            {
                new Product{Name="Iphone X",Price=6000,Description="güzel telefon",IsApproved=true},
                new Product{Name="Samsung S6",Price=3000,Description="iyi telefon"},
                new Product{Name="Xiaomi Mi 10",Price=4000,Description="güzel telefon",IsApproved=true},
                new Product{Name="Nokia 3310",Price=1000,Description="eski telefon"},
            };
            var category = new Category{
                Name = "Telefonlar",
                Description = "Akıllı telefonlar"
            };
            var productViewModel = new ProductViewModel()
            {
                Category = category,
                Products = products
            };
            return View(productViewModel);
        }

         // localhost:5000/product/details/2
        public IActionResult Details(int id)
        {
            // name: "samsung s6"
            // price: 3000
            // description: "iyi telefon"

            // ViewBag.Name = "samsung s6";
            // ViewBag.Price = 3000;
            // ViewBag.Description = "iyi telefon";

            var product = new Product();

            product.Name = "samsung s6";
            product.Price = 3000;
            product.Description = "iyi telefon";
 
            return View(product);
        }
    }
}