using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryReepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryReepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryReepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
