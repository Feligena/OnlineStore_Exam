using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Metadata;

namespace OnlineStore_Exam.Models
{
    public class OnlineStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Images> Images { get; set; }

        public OnlineStoreDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasOne(c => c.Image)
                        .WithOne(c => c.Category)
                        .HasForeignKey<Images>(c => c.CategoryId)
                        .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
