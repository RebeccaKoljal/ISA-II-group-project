using Abc.Data.GroupProjectClasses.Nora;
using Abc.Infra;

namespace Abc.Soft.Web;
public static class AvailableRecipesApi
{
    public static IEndpointRouteBuilder MapAvailableRecipesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<AvailableRecipe, IAvailableRecipesRepo>("/api/availablerecipes");
}