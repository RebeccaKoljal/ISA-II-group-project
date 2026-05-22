using Abc.Data.GroupProjectClasses.Nora;
using Abc.Data.GroupProjectClasses.Rebecca;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests.Nora;

[TestClass]
public sealed class ProductsInUserInventoryTests : BaseTests<ProductsInUserInventory>
{
    [TestMethod] public void ProductIdTest() => IsProperty<Guid?>(nameof(ProductsInUserInventory.ProductId));
    [TestMethod] public void ProductTest() => IsProperty<ProductInfo>(nameof(ProductsInUserInventory.Product));
    [TestMethod] public void UserIdTest() => IsProperty<Guid?>(nameof(ProductsInUserInventory.UserId));
    [TestMethod] public void UserTest() => IsProperty<User>(nameof(ProductsInUserInventory.User));
    [TestMethod] public void QuantityTest() => IsProperty<int>(nameof(ProductsInUserInventory.Quantity));
    [TestMethod] public void ExpiryDateTest() => IsProperty<DateTime?>(nameof(ProductsInUserInventory.ExpiryDate));
    [TestMethod] public void ProductNameTest() => IsProperty<string>(nameof(ProductsInUserInventory.ProductName));
}