using Abc.Data.GroupProjectClasses.Robi;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class NotificationTypeTests
    : BaseTests<Abc.Data.GroupProjectClasses.Robi.NotificationType>
{
    [TestMethod]
    public void NameTest()
        => IsProperty<string>(nameof(NotificationType.Name));
    [TestMethod]
    public void DetailsTest()
        => IsProperty<string>(nameof(NotificationType.Details));
}