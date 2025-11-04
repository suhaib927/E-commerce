using E_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.DataAcess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = 1},
                new Category { Id = 2, Name = "Books", Description = 2},
                new Category { Id = 3, Name = "Clothing", Description = 3 }
            );
        }
        
    }
}
