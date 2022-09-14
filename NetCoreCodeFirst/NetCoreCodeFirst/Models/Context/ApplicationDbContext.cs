/*
    Microsoft.EntityFrameworkCore
    Microsoft.EntityFrameworkCore.SqlServer
    Microsoft.EntityFrameworkCore.Design
    Microsoft.EntityFrameworkCore.Tools
 */

using Microsoft.EntityFrameworkCore;
using NetCoreCodeFirst.Models.Entity;

namespace NetCoreCodeFirst.Models.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
