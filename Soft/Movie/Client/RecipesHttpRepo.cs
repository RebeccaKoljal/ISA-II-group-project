using Abc.Data.GroupProjectClasses.Martin;
using Abc.Infra;

namespace Abc.Soft.Web.Client;

public sealed class RecipesHttpRepo(HttpClient http)
    : HttpRepo<Recipe>(http, "api/recipes"), IRecipesRepo;
