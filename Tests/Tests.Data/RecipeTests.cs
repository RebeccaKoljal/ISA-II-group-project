using Abc.Data;
using Abc.Tests.Aids;
namespace Abc.Tests.Data;

[TestClass]
public sealed class RecipeTests : BaseTests<Recipe>
{
    [TestMethod] public void IngredientsTest() => IsProperty<ICollection<UserRecipe>>(nameof(Recipe.Ingredients));
    [TestMethod] public void SourcesTest() => IsProperty<ICollection<InternetRecipe>>(nameof(Recipe.Sources));
}
