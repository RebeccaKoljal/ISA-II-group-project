using Abc.Data.GroupProjectClasses.Robi;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests.Robi;

[TestClass]
public sealed class NotificationsTests
    : BaseTests<Notifications>
{
    [TestMethod]
    public void UserIdTest()
        => IsProperty<Guid>(nameof(Abc.Data.GroupProjectClasses.Robi.Notifications.UserId));
    [TestMethod]
    public void NotificationTypeIdTest()
        => IsProperty<Guid>(nameof(Abc.Data.GroupProjectClasses.Robi.Notifications.NotificationTypeId));
    [TestMethod]
    public void NameTest()
        => IsProperty<string>(nameof(Abc.Data.GroupProjectClasses.Robi.Notifications.Name));
    [TestMethod]
    public void SentAtTest()
        => IsProperty<DateTime?>(nameof(Abc.Data.GroupProjectClasses.Robi.Notifications.SentAt));
    [TestMethod]
    public void IsReadTest()
        => IsProperty<bool>(nameof(Abc.Data.GroupProjectClasses.Robi.Notifications.IsRead));
}