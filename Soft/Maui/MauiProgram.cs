using Microsoft.Extensions.Logging;
using Abc.Infra;

namespace Abc.Soft.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

#if ANDROID
        var serverUrl = "http://10.0.2.2:5000";
#else
        var serverUrl = "http://localhost:5000";
#endif

        builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(serverUrl) });

        builder.Services.AddScoped<IMoviesRepo, MoviesHttpRepo>();
        builder.Services.AddScoped<ICountriesRepo, CountriesHttpRepo>();
        builder.Services.AddScoped<ICurrenciesRepo, CurrenciesHttpRepo>();
        builder.Services.AddScoped<IMoneyRepo, MoneyHttpRepo>();
        builder.Services.AddScoped<ICountryCurrenciesRepo, CountryCurrenciesHttpRepo>();
        builder.Services.AddScoped<IRecipesRepo, RecipesHttpRepo>();
        builder.Services.AddScoped<IUserRecipesRepo, UserRecipesHttpRepo>();
        builder.Services.AddScoped<IInternetRecipesRepo, InternetRecipesHttpRepo>();
        builder.Services.AddScoped<IUsersRepo, UsersHttpRepo>();
        builder.Services.AddScoped<IProductsInUserInventoryRepo, ProductsInUserInventoryHttpRepo>();
        builder.Services.AddScoped<IAvailableRecipesRepo, AvailableRecipesHttpRepo>();
        builder.Services.AddScoped<IBarcodesRepo, BarcodesHttpRepo>();
        builder.Services.AddScoped<IExpiryDatesRepo, ExpiryDatesHttpRepo>();
        builder.Services.AddScoped<IProductsRepo, ProductsHttpRepo>();

        return builder.Build();
    }
}
