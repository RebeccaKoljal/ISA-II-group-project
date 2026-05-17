using Abc.Data.GroupProjectClasses.Martin;
using Abc.Infra;
using Microsoft.AspNetCore.Routing;

namespace Abc.Soft.Web;

public static class InternetRecipesApi
{
    public static IEndpointRouteBuilder MapInternetRecipesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<InternetRecipe, IInternetRecipesRepo>("/api/internetrecipes");
}
