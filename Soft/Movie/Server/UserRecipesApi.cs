using Abc.Data;
using Abc.Infra;
using Microsoft.AspNetCore.Routing;

namespace Abc.Soft.Web;

public static class UserRecipesApi
{
    public static IEndpointRouteBuilder MapUserRecipesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<UserRecipe, IUserRecipesRepo>("/api/userrecipes");
}
