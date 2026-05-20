using Abc.Data.GroupProjectClasses.Robi;
using Abc.Infra;

namespace Abc.Soft.Web;

public static class NotificationSettingsApi
{
    public static IEndpointRouteBuilder MapNotificationSettingsApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<NotificationSettings, INotificationSettingsRepo>("/api/notificationsettings");
}