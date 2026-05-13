using Abc.Data;
using Abc.Tests.Aids;
namespace Abc.Tests.Data;

[TestClass]
public sealed class InternetRecipeTests : BaseTests<InternetRecipe>
{
    [TestMethod] public void RecipeIdTest() => IsProperty<Guid?>(nameof(InternetRecipe.RecipeId));
    [TestMethod] public void RecipeTest() => IsProperty<Recipe>(nameof(InternetRecipe.Recipe));
    [TestMethod] public void UrlTest() => IsProperty<string>(nameof(InternetRecipe.Url));
    [TestMethod] public void SourceTest() => IsProperty<string>(nameof(InternetRecipe.Source));
}
