using Abc.Data.GroupProjectClasses.Elizaveta;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class ProductTests : BaseTests<Product>
{
    [TestMethod] public void ImageUrlTest() => IsProperty<string>(nameof(Product.ImageUrl));
}