using NetCoreCodeFirst.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCodeFirst.Models.Repository
{
    public interface ICategoryService
    {
        List<Category> GetCategories();

       
    }
}
