using Abc.Data.GroupProjectClasses.Elizaveta;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class BarcodeTests : BaseTests<Barcode>
{
    [TestMethod] public void ScannedAtTest() => IsProperty<DateTime>(nameof(Barcode.ScannedAt));
    [TestMethod] public void ProductIdTest() => IsProperty<Guid>(nameof(Barcode.ProductId));
}
