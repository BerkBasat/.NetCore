using NetCoreCodeFirst.Models.Context;
using NetCoreCodeFirst.Models.Entity;
using NetCoreCodeFirst.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCodeFirst.Models.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext context;

        public CategoryService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
    }
}
