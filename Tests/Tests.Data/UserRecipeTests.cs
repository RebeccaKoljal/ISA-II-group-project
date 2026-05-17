using Abc.Data.GroupProjectClasses.Martin;
using Abc.Tests.Aids;
namespace Abc.Tests.Data;

[TestClass]
public sealed class UserRecipeTests : BaseTests<UserRecipe>
{
    [TestMethod] public void RecipeIdTest() => IsProperty<Guid?>(nameof(UserRecipe.RecipeId));
    [TestMethod] public void RecipeTest() => IsProperty<Recipe>(nameof(UserRecipe.Recipe));
    [TestMethod] public void ProductNameTest() => IsProperty<string>(nameof(UserRecipe.ProductName));
}
