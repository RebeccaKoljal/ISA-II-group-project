using Abc.Data;
using Abc.Infra;
using Microsoft.AspNetCore.Routing;

namespace Abc.Soft.Web;

public static class MoviesApi
{
    public static IEndpointRouteBuilder MapMoviesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<Movie, IMoviesRepo>("/api/movies");
}