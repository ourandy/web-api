using Microsoft.EntityFrameworkCore;
using WebApplicationAL.Models;

namespace WebApplicationAL.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }

        public DbSet<Product> Product { get; set; }
    }
}
