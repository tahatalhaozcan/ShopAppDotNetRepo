using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Data
{
    public class CategoryRepo
    {
        private static List<Category> _categories = null;
        static CategoryRepo()
        {
            _categories = new List<Category>()
            {
                new Category {CategoryId=1,Name="Telefon"},
                new Category {CategoryId=2,Name="Bilgisayar"},
                new Category {CategoryId=3,Name="Tablet"},
                new Category {CategoryId=4,Name="Kamera"},
            };
        }
        public static List<Category> Categories
        {
            get { return _categories; }
        }
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }
        public static Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}