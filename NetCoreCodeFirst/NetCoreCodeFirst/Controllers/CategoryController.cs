using Microsoft.AspNetCore.Mvc;
using NetCoreCodeFirst.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCodeFirst.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categories = categoryService.GetCategories();
            return View();
        }
    }
}
