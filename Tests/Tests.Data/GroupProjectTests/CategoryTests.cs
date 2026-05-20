using Abc.Data.GroupProjectClasses.Rebecca;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests;

[TestClass] public class CategoryTests : BaseTests<Category>
{
    [TestMethod] public void ParentCategoryIdTest() => IsProperty<Guid>(nameof(Category.ParentCategoryId));
}
