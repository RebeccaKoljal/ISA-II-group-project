using Abc.Data.GroupProjectClasses.Nora;
using Abc.Tests.Aids;

namespace Abc.Tests.Data.GroupProjectTests.Nora;

[TestClass]
public sealed class UserTests : BaseTests<User>
{
    [TestMethod] public void IdTest() => IsProperty<Guid>(nameof(User.Id));
    [TestMethod] public void NameTest() => IsProperty<string>(nameof(User.Name));
    [TestMethod] public void EmailTest() => IsProperty<string>(nameof(User.Email));
}