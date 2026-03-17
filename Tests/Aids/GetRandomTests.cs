using Abc.Aids;

namespace Abc.Tests.Aids;

[TestClass] public sealed class GetRandomTests
{
    private const sbyte min = sbyte.MinValue; // so that there can be negative values as well
    private const sbyte max = sbyte.MaxValue;
    [TestMethod] public void Int8Test() => Assert.AreNotEqual(GetRandom.Int8(min, max), GetRandom.Int8(min, max));
    [TestMethod] public void Int16Test() => Assert.AreNotEqual(GetRandom.Int16(min, max), GetRandom.Int16(min, max));
    [TestMethod] public void Int32Test() => Assert.AreNotEqual(GetRandom.Int32(min, max), GetRandom.Int32(min, max));
    [TestMethod] public void Int64Test() => Assert.AreNotEqual(GetRandom.Int64(min, max), GetRandom.Int64(min, max));
    [TestMethod] public void UInt8Test() => Assert.AreNotEqual(GetRandom.UInt8(0, (byte)max), GetRandom.UInt8(0, (byte)max));
    [TestMethod] public void UInt16Test() => Assert.AreNotEqual(GetRandom.UInt16(0, (ushort)max), GetRandom.UInt16(0, (ushort)max));
    [TestMethod] public void UInt32Test() => Assert.AreNotEqual(GetRandom.UInt32(0, (uint)max), GetRandom.UInt32(0, (uint)max));
    [TestMethod] public void UInt64Test() => Assert.AreNotEqual(GetRandom.UInt64(0, (ulong)max), GetRandom.UInt64(0, (ulong)max));
    [TestMethod] public void DoubleTest() => Assert.AreNotEqual(GetRandom.Double(min, max), GetRandom.Double(min, max));
}
