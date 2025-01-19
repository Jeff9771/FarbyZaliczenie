using FunnyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FunnyWeb.Controllers.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Vallejo Metal", PaintNumber = 77723, Type = "Metal" },
                new Category { Id = 2, Name = "Vallejo Game", PaintNumber = 77323, Type = "Metal" },
                new Category { Id = 3, Name = "Citadel Shade", PaintNumber = 52762, Type = "Metal" }
            );
        }
    }
}
