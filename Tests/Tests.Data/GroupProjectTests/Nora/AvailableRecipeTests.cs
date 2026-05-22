using Abc.Data.GroupProjectClasses.Martin;
using Abc.Data.GroupProjectClasses.Nora;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests.Nora;
[TestClass] public sealed class AvailableRecipeTests : BaseTests<AvailableRecipe>
{
    [TestMethod] public void UserIdTest() => IsProperty<Guid?>(nameof(AvailableRecipe.UserId));
    [TestMethod] public void UserTest() => IsProperty<User>(nameof(AvailableRecipe.User));
    [TestMethod] public void RecipeIdTest() => IsProperty<Guid>(nameof(AvailableRecipe.RecipeId));
    [TestMethod] public void RecipeTest() => IsProperty<Recipe>(nameof(AvailableRecipe.Recipe));
}