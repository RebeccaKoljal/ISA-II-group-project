using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Abc.Soft.Web.Client;
using Abc.Infra;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthenticationStateDeserialization();
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICountriesRepo, CountriesHttpRepo>();
builder.Services.AddScoped<IMoviesRepo, MoviesHttpRepo>();

await builder.Build().RunAsync();
