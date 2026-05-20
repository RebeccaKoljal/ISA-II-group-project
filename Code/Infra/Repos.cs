using Abc.Data;
using Abc.Data.GroupProjectClasses.Elizaveta;
using Abc.Data.GroupProjectClasses.Martin;
using Abc.Data.GroupProjectClasses.Nora;
using Abc.Data.GroupProjectClasses.Rebecca;
using Abc.Data.GroupProjectClasses.Martin;
using Abc.Data.GroupProjectClasses.Robi;
using Microsoft.EntityFrameworkCore;

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
public class UsersRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, User>(c), IUsersRepo
{ }

public class ProductsInUserInventoryRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, ProductsInUserInventory>(c), IProductsInUserInventoryRepo
{
    protected override IQueryable<ProductsInUserInventory> Query() => db.ProductsInUserInventory
        .Include(x => x.User)
        .Include(x => x.Product);
}

public class AvailableRecipesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, AvailableRecipe>(c), IAvailableRecipesRepo
{
    protected override IQueryable<AvailableRecipe> Query() => db.AvailableRecipes
        .Include(x => x.User)
        .Include(x => x.Recipe);
}
public class ProductInfoRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, ProductInfo>(c), IProductInfoRepo
{ }
public class CategoryRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Category>(c), ICategoryRepo
{ }
public class NotificationsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Notifications>(c), INotificationsRepo
{ }
