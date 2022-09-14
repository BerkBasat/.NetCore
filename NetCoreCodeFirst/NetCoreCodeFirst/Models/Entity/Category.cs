using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCodeFirst.Models.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
