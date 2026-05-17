using Abc.Data.GroupProjectClasses.Elizaveta;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class ExpiryDateTests : BaseTests<ExpiryDate>
{
    [TestMethod] public void DateTest() => IsProperty<DateTime>(nameof(ExpiryDate.Date));
    [TestMethod] public void ProductInfoIdTest() => IsProperty<Guid>(nameof(ExpiryDate.ProductInfoId));
    [TestMethod] public void IsExpiredTest() => Assert.IsNotNull(typeof(ExpiryDate).GetProperty(nameof(ExpiryDate.IsExpired)));
    
    [TestMethod] 
    public void IsExpiredReturnsFalseForFutureDate()
    {
        var e = new ExpiryDate { Date = DateTime.Now.AddDays(1) };
        Assert.IsFalse(e.IsExpired);
    }

    [TestMethod]
    public void IsExpiredReturnsTrueForPastDate()
    {
        var e = new ExpiryDate { Date = DateTime.Now.AddDays(-1) };
        Assert.IsTrue(e.IsExpired);
    }
}