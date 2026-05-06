using Abc.Data;
using Abc.Infra;

namespace Abc.Soft.Web.Client;

public sealed class MoviesHttpRepo(HttpClient http)
    : HttpRepo<Movie>(http, "api/movies"), IMoviesRepo;