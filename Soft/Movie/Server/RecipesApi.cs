using Abc.Data.GroupProjectClasses.Martin;
using Abc.Infra;

namespace Abc.Soft.Web;

public static class RecipesApi
{
    public static IEndpointRouteBuilder MapRecipesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<Recipe, IRecipesRepo>("/api/recipes");
}
