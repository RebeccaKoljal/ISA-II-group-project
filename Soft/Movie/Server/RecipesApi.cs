using Abc.Data;
using Abc.Infra;
using Microsoft.AspNetCore.Routing;

namespace Abc.Soft.Web;

public static class RecipesApi
{
    public static IEndpointRouteBuilder MapRecipesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<Recipe, IRecipesRepo>("/api/recipes");
}
