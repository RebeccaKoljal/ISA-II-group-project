using Abc.Data;
using Microsoft.EntityFrameworkCore;
using Abc.Data.GroupProjectClasses.Elizaveta;

namespace Abc.Infra;

public class MoviesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Movie>(c), IMoviesRepo
{ }
public class CurrenciesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Currency>(c), ICurrenciesRepo
{ }
public class CountriesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Country>(c), ICountriesRepo
{
    protected override IQueryable<Country> Query() => db.Countries
        .Include(x => x.CountryCurrencies)
        .ThenInclude(x => x.Currency);
}
public class MoneyRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Money>(c), IMoneyRepo
{ }
public class CountryCurrenciesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, CountryCurrency>(c), ICountryCurrenciesRepo
{
    protected override IQueryable<CountryCurrency> Query() => db.CountryCurrencies
            .Include(x => x.Country)
            .Include(x => x.Currency);
}
public class RecipesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Recipe>(c), IRecipesRepo
{
    protected override IQueryable<Recipe> Query() => db.Recipes
        .Include(x => x.Ingredients)
        .Include(x => x.Sources);
}
public class InternetRecipesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, InternetRecipe>(c), IInternetRecipesRepo
{
    protected override IQueryable<InternetRecipe> Query() => db.InternetRecipes
        .Include(x => x.Recipe);
}
public class UserRecipesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, UserRecipe>(c), IUserRecipesRepo
{
    protected override IQueryable<UserRecipe> Query() => db.UserRecipes
        .Include(x => x.Recipe);
}
public class BarcodesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Barcode>(c), IBarcodesRepo
{ }
public class ExpiryDatesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, ExpiryDate>(c), IExpiryDatesRepo
{ }
public class ProductsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Product>(c), IProductsRepo
{ }