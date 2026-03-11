using Abc.Aids;

namespace Abc.Tests.Aids;

[TestClass]
public sealed class GetRandomTests
{
    private const sbyte min = sbyte.MinValue; // so that there can be negative values as well
    private const sbyte max = sbyte.MaxValue;
    [TestMethod] public void Int32Test() => Assert.AreNotEqual(GetRandom.Int32(min, max), GetRandom.Int32(min, max));
    [TestMethod] public void Int64Test() => Assert.AreNotEqual(GetRandom.Int64(min, max), GetRandom.Int64(min, max));
    [TestMethod] public void DoubleTest() => Assert.AreNotEqual(GetRandom.Double(min, max), GetRandom.Double(min, max));
}
