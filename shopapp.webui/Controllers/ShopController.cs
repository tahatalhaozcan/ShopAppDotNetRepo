using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;

namespace shopapp.webui.Controllers
{
    public class ShopController :Controller
    {
        private IProductService _productService;
        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult List()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };
            return View(productViewModel);
        }
        public IActionResult Details(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            Product product = _productService.GetById((int)id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}