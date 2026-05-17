using Abc.Data.GroupProjectClasses.Nora;
using Abc.Infra;

namespace Abc.Soft.Web;
public static class UsersApi
{
    public static IEndpointRouteBuilder MapUsersApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<User, IUsersRepo>("/api/users");
}