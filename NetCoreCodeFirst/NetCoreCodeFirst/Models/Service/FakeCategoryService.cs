using NetCoreCodeFirst.Models.Entity;
using NetCoreCodeFirst.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCodeFirst.Models.Service
{
    public class FakeCategoryService : ICategoryService
    {


        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category{ID=1,CategoryName="Test Giyim"},
                new Category{ID=1,CategoryName="Test Teknoloji"},
                new Category{ID=1,CategoryName="Test Hede"}
            };

            return categories;
        }
    }
}
