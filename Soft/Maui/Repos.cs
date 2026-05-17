using Abc.Data;
using Abc.Data.GroupProjectClasses.Elizaveta;
using Abc.Data.GroupProjectClasses.Martin;
using Abc.Data.GroupProjectClasses.Nora;
using Abc.Infra;

namespace Abc.Soft.App;

public sealed class MoviesHttpRepo(HttpClient http) : HttpRepo<Movie>(http, "api/movies"), IMoviesRepo;
public sealed class CountriesHttpRepo(HttpClient http) : HttpRepo<Country>(http, "api/countries"), ICountriesRepo;
public sealed class CurrenciesHttpRepo(HttpClient http) : HttpRepo<Currency>(http, "api/currencies"), ICurrenciesRepo;
public sealed class MoneyHttpRepo(HttpClient http) : HttpRepo<Money>(http, "api/money"), IMoneyRepo;
public sealed class CountryCurrenciesHttpRepo(HttpClient http) : HttpRepo<CountryCurrency>(http, "api/countrycurrencies"), ICountryCurrenciesRepo;
public sealed class RecipesHttpRepo(HttpClient http) : HttpRepo<Recipe>(http, "api/recipes"), IRecipesRepo;
public sealed class UserRecipesHttpRepo(HttpClient http) : HttpRepo<UserRecipe>(http, "api/userrecipes"), IUserRecipesRepo;
public sealed class InternetRecipesHttpRepo(HttpClient http) : HttpRepo<InternetRecipe>(http, "api/internetrecipes"), IInternetRecipesRepo;
public sealed class UsersHttpRepo(HttpClient http) : HttpRepo<User>(http, "api/users"), IUsersRepo;
public sealed class ProductsInUserInventoryHttpRepo(HttpClient http) : HttpRepo<ProductsInUserInventory>(http, "api/productsInUserInventory"), IProductsInUserInventoryRepo;
public sealed class AvailableRecipesHttpRepo(HttpClient http) : HttpRepo<AvailableRecipe>(http, "api/availablerecipes"), IAvailableRecipesRepo;
public sealed class BarcodesHttpRepo(HttpClient http) : HttpRepo<Barcode>(http, "api/barcodes"), IBarcodesRepo;
public sealed class ExpiryDatesHttpRepo(HttpClient http) : HttpRepo<ExpiryDate>(http, "api/expirydates"), IExpiryDatesRepo;
public sealed class ProductsHttpRepo(HttpClient http) : HttpRepo<Product>(http, "api/products"), IProductsRepo;
