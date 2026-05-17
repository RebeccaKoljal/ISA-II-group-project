using Abc.Data.GroupProjectClasses.Martin;
using Abc.Infra;

namespace Abc.Soft.Web.Client;

public sealed class InternetRecipesHttpRepo(HttpClient http)
    : HttpRepo<InternetRecipe>(http, "api/internetrecipes"), IInternetRecipesRepo;
