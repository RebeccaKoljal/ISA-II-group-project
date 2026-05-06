using Abc.Data;
using Abc.Infra;

namespace Abc.Soft.Web.Client;

public sealed class CountriesHttpRepo(HttpClient http)
    : HttpRepo<Country>(http, "api/countries"), ICountriesRepo;