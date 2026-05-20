using Abc.Data.GroupProjectClasses.Rebecca;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests.Rebecca;

[TestClass] public class ProductInfoTests : BaseTests<ProductInfo>
{
    [TestMethod] public void IdTest() => IsProperty<Guid>(nameof(ProductInfo.Id));
    [TestMethod] public void NameTest() => IsProperty<string>(nameof(ProductInfo.Name));
    [TestMethod] public void ValidFromTest() => IsProperty<DateTime?>(nameof(ProductInfo.ValidFrom));
}
