using Carmodels.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Carmodels.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Taxonomy> Taxonomies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Product>(sc => sc.Product)
                .WithMany(s => s.ProductCategories)
                .HasForeignKey(sc => sc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(sc => sc.CategoryId);
        }
    }
}
