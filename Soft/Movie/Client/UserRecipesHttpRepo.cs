using Abc.Data.GroupProjectClasses.Martin;
using Abc.Infra;

namespace Abc.Soft.Web.Client;

public sealed class UserRecipesHttpRepo(HttpClient http)
    : HttpRepo<UserRecipe>(http, "api/userrecipes"), IUserRecipesRepo;
