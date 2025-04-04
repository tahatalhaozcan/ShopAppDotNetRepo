using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.data.Abstract;
using shopapp.business.Abstract;


namespace shopapp.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Index()
        {
            
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };

            return View(productViewModel);
        }

         // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}