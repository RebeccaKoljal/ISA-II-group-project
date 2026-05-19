using Abc.Soft.Web;
using Abc.Infra;
using Abc.Data.GroupProjectClasses.Nora;
using Abc.Soft.Web.Components;
using System.Text.Json.Serialization;
using Abc.Soft.Web.Components.Account;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContextFactory<MovieDbContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("ApplicationDbContext") ?? throw new InvalidOperationException("Connection string 'AbcSoftWebContext' not found.")));

builder.Services.ConfigureHttpJsonOptions(o =>
    o.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Kui kuskil on DI-s vaja ApplicationDbContext-i (mitte factory't), võta see factory kaudu
builder.Services.AddQuickGridEntityFrameworkAdapter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddAuthenticationStateSerialization();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = true;
        options.Stores.SchemaVersion = IdentitySchemaVersions.Version3;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

// if repo is needed, then it needs to be added here, before app is built
builder.Services.AddScoped<IMoviesRepo, MoviesRepo>();
builder.Services.AddScoped<ICountriesRepo, CountriesRepo>();
builder.Services.AddScoped<ICurrenciesRepo, CurrenciesRepo>();
builder.Services.AddScoped<IMoneyRepo, MoneyRepo>();
builder.Services.AddScoped<ICountryCurrenciesRepo, CountryCurrenciesRepo>();
builder.Services.AddScoped<IRecipesRepo, RecipesRepo>();
builder.Services.AddScoped<IInternetRecipesRepo, InternetRecipesRepo>();
builder.Services.AddScoped<IUserRecipesRepo, UserRecipesRepo>();
builder.Services.AddScoped<IUsersRepo, UsersRepo>();
builder.Services.AddScoped<IProductsInUserInventoryRepo, ProductsInUserInventoryRepo>();
builder.Services.AddScoped<IAvailableRecipesRepo, AvailableRecipesRepo>();
builder.Services.AddScoped<IBarcodesRepo, BarcodesRepo>();
builder.Services.AddScoped<IExpiryDatesRepo, ExpiryDatesRepo>();
builder.Services.AddScoped<IProductsRepo, ProductsRepo>();
builder.Services.AddScoped<INotificationsRepo, NotificationsRepo>();
builder.Services.AddScoped<INotificationSettingsRepo, NotificationSettingsRepo>();
builder.Services.AddScoped<INotificationTypeRepo, NotificationTypeRepo>();

var app = builder.Build();

using var scope = app.Services.CreateScope();
var sp = scope.ServiceProvider;
var db = sp.GetRequiredService<ApplicationDbContext>();
await new SeedDb(db, 100).Seed();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Abc.Soft.Web.Client._Imports).Assembly,
                             typeof(Abc.Shared.Pages.Countries.Index).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapCountriesApi();
app.MapMoviesApi();
app.MapCurrenciesApi();
app.MapMoneyApi();
app.MapCountryCurrenciesApi();
app.MapRecipesApi();
app.MapInternetRecipesApi();
app.MapUserRecipesApi();
app.MapAdditionalIdentityEndpoints();
app.MapUsersApi();
app.MapProductsInUserInventoryApi();
app.MapAvailableRecipesApi();
app.MapNotificationsApi();
app.MapNotificationSettingsApi();
app.MapNotificationTypesApi();


app.Run();
