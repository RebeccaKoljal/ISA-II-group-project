using Abc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Abc.Infra;

public sealed class CountryConfig : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> b)
    {
        b.HasMany(x => x.CountryCurrencies)
            .WithOne(x => x.Country)
            .HasForeignKey(x => x.CountryId);
    }
}
public sealed class CurrencyConfig : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> b) { }
}
public sealed class MovieConfig : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> b) { }
}
public sealed class MoneyConfig : IEntityTypeConfiguration<Money>
{
    public void Configure(EntityTypeBuilder<Money> b)
    {
        b.Property(x => x.Amount).HasColumnType("decimal(18, 2)");
    }
}
public sealed class CountryCurrencyConfig : IEntityTypeConfiguration<CountryCurrency>
{
    public void Configure(EntityTypeBuilder<CountryCurrency> b)
    {
        b.HasOne(x => x.Country)
            .WithMany(x => x.CountryCurrencies)
            .HasForeignKey(x => x.CountryId);
        b.HasOne(x => x.Currency).WithMany().HasForeignKey(x => x.CurrencyId);
    }
}
public sealed class RecipeConfig : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> b)
    {
        b.HasMany(x => x.Ingredients)
            .WithOne(x => x.Recipe)
            .HasForeignKey(x => x.RecipeId);
        b.HasMany(x => x.Sources)
            .WithOne(x => x.Recipe)
            .HasForeignKey(x => x.RecipeId);
    }
}
public sealed class InternetRecipeConfig : IEntityTypeConfiguration<InternetRecipe>
{
    public void Configure(EntityTypeBuilder<InternetRecipe> b)
    {
        b.HasOne(x => x.Recipe).WithMany(x => x.Sources).HasForeignKey(x => x.RecipeId);
    }
}
public sealed class UserRecipeConfig : IEntityTypeConfiguration<UserRecipe>
{
    public void Configure(EntityTypeBuilder<UserRecipe> b)
    {
        b.HasOne(x => x.Recipe).WithMany(x => x.Ingredients).HasForeignKey(x => x.RecipeId);
    }
}
