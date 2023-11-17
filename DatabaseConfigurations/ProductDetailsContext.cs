using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StoreBilling.Models;

namespace StoreBilling.DatabaseConfigurations
{
    public class ProductDetailsContext : DbContext 
    {
        public ProductDetailsContext(DbContextOptions<ProductDetailsContext> options)
            : base(options)
        {
            
        }
        public DbSet<Products> Products { get; set; }
    }
}
