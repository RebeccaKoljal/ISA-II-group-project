using Abc.Data;


namespace Abc.Infra
{
    public class MoviesRepos (ApplicationDbContext c = null): EfBaseRepo<ApplicationDbContext, Movie> (c), IMoviesRepo { }
    public class CurrencyRepos (ApplicationDbContext c = null) : EfBaseRepo<ApplicationDbContext, Currency>(c), ICurrenciesRepo { }
    public class CountriesRepos (ApplicationDbContext c = null) : EfBaseRepo<ApplicationDbContext, Country>(c), ICountriesRepo { }
}
