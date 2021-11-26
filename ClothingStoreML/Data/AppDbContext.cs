using Microsoft.EntityFrameworkCore;
using ClothingStoreML.Models;

namespace ClothingStoreML.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductModel> Product {get; set;}
        public AppDbContext(DbContextOptions options) : base(options)
        {

        } 
    }
}
