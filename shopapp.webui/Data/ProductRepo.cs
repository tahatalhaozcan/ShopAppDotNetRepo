using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.webui.Models;

namespace shopapp.webui.Data
{
    public static class ProductRepo
    {
        private static List<Product> _products = null;
        static ProductRepo()
        {
            _products = new List<Product>()
            {
                  new Product {ProductId=1,Name="Iphone 7",Price=3000,imageUrl="iphone7.jpg",Description="iyi telefon",IsApproved=true,CategoryId=1},
                new Product {ProductId=2,Name="Iphone 8",Price=4000,imageUrl="iphone 8.jpg",Description="çok iyi telefon",IsApproved=true,CategoryId=1},
                new Product {ProductId=3,Name="Iphone X",Price=5000,imageUrl="iphone x.jpg",Description="çok iyi telefon",IsApproved=true,CategoryId=1},
                new Product {ProductId=4,Name="Iphone 11",Price=7000,imageUrl="iphone 11 pro.jpg",Description="çok iyi telefon",IsApproved=true,CategoryId=1},
                new Product {ProductId=5,Name="Lenovo Thinkpad",Price=3000,imageUrl="thinkpad.jpg",Description="iyi bilgisayar",IsApproved=true,CategoryId=2},
                new Product {ProductId=6,Name="Asus Zenbook",Price=4000,imageUrl="asus.jpg",Description="çok iyi bilgisayar",IsApproved=true,CategoryId=2},
                new Product {ProductId=7,Name="Canon",Price=5000,imageUrl="canon.jpg",Description="çok iyi kamera",IsApproved=true,CategoryId=4},
                new Product {ProductId=8,Name="matepad",Price=7000,imageUrl="matepad.jpg",Description="çok iyi tablet",IsApproved=true,CategoryId=3},
            };
        }
        public static List<Product> Products
        {
            get { return _products; }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}