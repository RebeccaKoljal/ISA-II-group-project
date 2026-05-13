using Abc.Data;
using Abc.Data.Common;
using Abc.Data.GroupProjectClasses.Elizaveta;

namespace Abc.Infra;

public interface IRepo<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetAsync(Guid id);
    Task<int> CountAsync(Query q);
    Task<IEnumerable<TEntity>> GetAsync(Query q);
    Task<TEntity> CreateAsync(TEntity e);
    Task<TEntity> UpdateAsync(TEntity e);
    Task DeleteAsync(Guid id);
}

public interface IMoviesRepo : IRepo<Movie> { }
public interface ICountriesRepo : IRepo<Country> { }
public interface ICurrenciesRepo : IRepo<Currency> { }
public interface IMoneyRepo : IRepo<Money> { }
public interface ICountryCurrenciesRepo : IRepo<CountryCurrency> { }
public interface IRecipesRepo : IRepo<Recipe> { }
public interface IInternetRecipesRepo : IRepo<InternetRecipe> { }
public interface IUserRecipesRepo : IRepo<UserRecipe> { }
public interface IBarcodesRepo : IRepo<Barcode> { }
public interface IExpiryDatesRepo : IRepo<ExpiryDate> { }
public interface IProductsRepo : IRepo<Product> { }
