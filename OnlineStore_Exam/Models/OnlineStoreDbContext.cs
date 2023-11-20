using Microsoft.EntityFrameworkCore;

namespace OnlineStore_Exam.Models
{
    public class OnlineStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<CategoryImage> CategoriesImages { get; set; }

        public OnlineStoreDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
