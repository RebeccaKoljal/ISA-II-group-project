using Abc.Data.GroupProjectClasses.Robi;
using Abc.Infra;

namespace Abc.Soft.Web;

public static class NotificationsApi
{
    public static IEndpointRouteBuilder MapNotificationsApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<Notifications, INotificationsRepo>("/api/notifications");
}