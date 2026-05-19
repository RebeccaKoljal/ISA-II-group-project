using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Abc.Infra;

namespace Abc.Shared.Code.GroupProjectCode;

public static class SharedProgram
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services, Action<DbContextOptionsBuilder> dbOptions)
    {
        // 1. Andmebaasi tehase ja konteksti seadistus (ühine andmebaas ja migratsioonid)
        services.AddDbContextFactory<ApplicationDbContext>(dbOptions);
        services.AddScoped(sp => sp.GetRequiredService<IDbContextFactory<ApplicationDbContext>>().CreateDbContext());

        services.AddScoped<IUsersRepo, UsersRepo>();
        services.AddScoped<IProductsInUserInventoryRepo, ProductsInUserInventoryRepo>();
        services.AddScoped<IAvailableRecipesRepo, AvailableRecipesRepo>();
        services.AddScoped<INotificationsRepo, NotificationsRepo>();
        services.AddScoped<INotificationSettingsRepo, NotificationSettingsRepo>();
        services.AddScoped<INotificationTypeRepo, NotificationTypeRepo>();
        services.AddScoped<IRecipesRepo, RecipesRepo>();
        services.AddScoped<IInternetRecipesRepo, InternetRecipesRepo>();
        services.AddScoped<IUserRecipesRepo, UserRecipesRepo>();
        services.AddScoped<IBarcodesRepo, BarcodesRepo>();
        services.AddScoped<IExpiryDatesRepo, ExpiryDatesRepo>();
        services.AddScoped<IProductsRepo, ProductsRepo>();

        return services;
    }
}
