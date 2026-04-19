using Abc.Data;
using Abc.Data.Common;

namespace Abc.Infra
{
    public sealed class Query(Dictionary<string, string> d = null)
    {
        public static int[] PageSizes => [7, 15, 25, 50, 100];
        public int Page => toInt(get(nameof(Page)), 1);
        public int PageSize => toInt(get(nameof(PageSize)), PageSizes[0]);
        private string get(string s) => (d ?? []).TryGetValue(s, out var x) ? x : null;
        private static int toInt(string s, int def) => int.TryParse(s, out var i) ? i : def;
    }
    public interface IRepo<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetAsync(Guid id);
        Task<int> CountAsync(Query q); // counts the number of entities in the database
        Task<IEnumerable<TEntity>> GetAsync(Query q); // search for all entities and gives the info back
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
