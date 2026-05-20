using Abc.Data.GroupProjectClasses.Robi;
using Abc.Infra;

namespace Abc.Soft.Web;

public static class NotificationTypesApi
{
    public static IEndpointRouteBuilder MapNotificationTypesApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<NotificationType, INotificationTypeRepo>("/api/notificationtypes");
}