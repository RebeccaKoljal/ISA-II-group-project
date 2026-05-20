using Abc.Data.GroupProjectClasses.Rebecca;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests.Rebecca;

[TestClass] public class ProductCategoryTests : BaseTests<ProductCategory>
{
    [TestMethod] public void ProductIdTest() => IsProperty<Guid?>(nameof(ProductCategory.ProductId));
    [TestMethod] public void CategoryIdTest() => IsProperty<Guid?>(nameof(ProductCategory.CategoryId));
    [TestMethod] public void ProductTest() => IsProperty<ProductInfo>(nameof(ProductCategory.Product));
    [TestMethod] public void CategoryTest() => IsProperty<Category>(nameof(ProductCategory.Category));
}
