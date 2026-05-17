using Abc.Data.GroupProjectClasses.Robi;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class NotificationSettingsTests
    : BaseTests<Abc.Data.GroupProjectClasses.Robi.NotificationSettings>
{
    [TestMethod]
    public void UserIdTest()
        => IsProperty<Guid>(nameof(NotificationSettings.UserId));
    [TestMethod]
    public void IsEmailEnabledTest()
        => IsProperty<bool>(nameof(NotificationSettings.IsEmailEnabled));
    [TestMethod]
    public void IsPushEnabledTest()
    => IsProperty<bool>(nameof(NotificationSettings.IsPushEnabled));
}