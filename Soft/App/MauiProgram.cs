using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Abc.Infra;

namespace Abc.Soft.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "abc-soft.db");
        var connectionString = $"Data Source={dbPath}";
        builder.Services.AddDbContextFactory<ApplicationDbContext>(o => {
            o.UseSqlite(connectionString);
            o.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
        });
        builder.Services.AddScoped(sp => sp.GetRequiredService<IDbContextFactory<ApplicationDbContext>>().CreateDbContext());

        builder.Services.AddScoped<IMoviesRepo, MoviesRepo>();
        builder.Services.AddScoped<ICountriesRepo, CountriesRepo>();
        builder.Services.AddScoped<ICurrenciesRepo, CurrenciesRepo>();
        builder.Services.AddScoped<IMoneyRepo, MoneyRepo>();
        builder.Services.AddScoped<ICountryCurrenciesRepo, CountryCurrenciesRepo>();
        builder.Services.AddScoped<IUsersRepo, UsersRepo>();
        builder.Services.AddScoped<IProductsInUserInventoryRepo, ProductsInUserInventoryRepo>();
        builder.Services.AddScoped<IAvailableRecipesRepo, AvailableRecipesRepo>();
        builder.Services.AddScoped<INotificationsRepo, NotificationsRepo>();
        builder.Services.AddScoped<INotificationSettingsRepo, NotificationSettingsRepo>();
        builder.Services.AddScoped<INotificationTypeRepo, NotificationTypeRepo>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        var app = builder.Build();
        initializeDb(app);
        return app;
    }

    private static void initializeDb(MauiApp app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        try
        {
            // Try to seed normally
            new SeedDb(db, 100).Seed().GetAwaiter().GetResult();
        }
        catch (Exception ex)
        {
#if DEBUG
            // If it crashes during local development, automatically wipe the broken Windows file
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "abc-soft.db");
            if (File.Exists(dbPath))
            {
                System.Diagnostics.Debug.WriteLine($"[DB FIX] Database migration failed: {ex.Message}. Deleting local file...");

                // Clear the connection pool and delete the file safely
                Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();
                File.Delete(dbPath);

                // Re-initialize a brand new clean database
                var cleanDb = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                new SeedDb(cleanDb, 100).Seed().GetAwaiter().GetResult();
                return;
            }
#endif
            // If it's a real non-migration crash, throw the error
            throw;
        }
    }

}
