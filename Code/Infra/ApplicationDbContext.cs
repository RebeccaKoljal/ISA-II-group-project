using Abc.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Movie> Movies { get; set; } = default!;
        public DbSet<Country> Countries { get; set; } = default!;
        public DbSet<Currency> Currencies { get; set; } = default!;
        public DbSet<Money> Money { get; set; } = default!;
        public DbSet<CountryCurrency> CountryCurrencies { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<ProductType> ProductTypes { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder) // cause there isn't primary key in the TypeOfProduct
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TypeOfProduct>()
                .HasKey(tp => new { tp.ProductId, tp.ProductTypeId });

            modelBuilder.Entity<TypeOfProduct>()
                .HasOne(tp => tp.Product)
                .WithMany(p => p.TypeOfProduct)
                .HasForeignKey(tp => tp.ProductId);

            modelBuilder.Entity<TypeOfProduct>()
                .HasOne(tp => tp.ProductType)
                .WithMany(pt => pt.TypeOfProduct)
                .HasForeignKey(tp => tp.ProductTypeId);
        }
    }
}
