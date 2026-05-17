using Abc.Data.GroupProjectClasses.Martin;
using Abc.Infra;

namespace Abc.Soft.Web;

public static class UserRecipesApi
{
    public static IEndpointRouteBuilder MapUserRecipesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<UserRecipe, IUserRecipesRepo>("/api/userrecipes");
}
