using Abc.Data;
using Abc.Data.Common;

namespace Abc.Infra
{
    public interface IRepo<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetAsync(Guid id); 
        Task<IEnumerable<TEntity>> GetAsync(); // search for all entities and gives the info back
        Task<TEntity> CreateAsync(TEntity e); // creates the database
        Task<TEntity> UpdateAsync(TEntity e); 
        Task DeleteAsync(Guid id);
    }
    public interface IMoviesRepo : IRepo<Movie> {}
    public interface ICountriesRepo : IRepo<Country> {}
    public interface ICurrenciesRepo : IRepo<Currency> {}
    public interface IMoniesRepo : IRepo<Money> { }
    public interface ICountryCurrenciesRepo : IRepo<CountryCurrency> { }
    public interface IProductsRepo : IRepo<Product> { }
}
