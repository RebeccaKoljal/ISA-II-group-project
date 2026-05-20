using Abc.Data.GroupProjectClasses.Robi;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests.Robi;

[TestClass]
public sealed class NotificationTypeTests
    : BaseTests<NotificationType>
{
    [TestMethod]
    public void NameTest()
        => IsProperty<string>(nameof(NotificationType.Name));
    [TestMethod]
    public void DetailsTest()
        => IsProperty<string>(nameof(NotificationType.Details));
}