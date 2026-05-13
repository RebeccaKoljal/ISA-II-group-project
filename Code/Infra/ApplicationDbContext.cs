using Abc.Data;
using Abc.Data.GroupProjectClasses.Nora;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Abc.Data.GroupProjectClasses.Elizaveta;


namespace Abc.Infra;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Barcode> Barcodes { get; set; } = default!;
    public DbSet<ExpiryDate> ExpiryDates { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;
    public DbSet<Movie> Movies { get; set; } = default!;
    public DbSet<Country> Countries { get; set; } = default!;
    public DbSet<Currency> Currencies { get; set; } = default!;
    public DbSet<Money> Money { get; set; } = default!;
    public DbSet<CountryCurrency> CountryCurrencies { get; set; } = default!;
    public DbSet<Recipe> Recipes { get; set; } = default!;
    public DbSet<InternetRecipe> InternetRecipes { get; set; } = default!;
    public DbSet<UserRecipe> UserRecipes { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;
    public DbSet<ProductsInUserInventory> ProductsInUserInventory { get; set; } = default!;
    public DbSet<AvailableRecipe> AvailableRecipes { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder b)
    {
        base.OnModelCreating(b);
        b.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
