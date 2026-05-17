using Abc.Aids;

namespace Abc.Tests.Aids;

[TestClass]
public sealed class RandomAttributeTests
{
    private readonly RandomAttribute attr = new(1, 10);

    [TestMethod] public void MinTest() => Assert.AreEqual(1, attr.Min);
    [TestMethod] public void MaxTest() => Assert.AreEqual(10, attr.Max);
    [TestMethod] public void ScaleTest() => Assert.AreEqual((sbyte)2, new RandomAttribute(1, 10, (sbyte)2).Scale);
    [TestMethod] public void CharsTest() => Assert.AreEqual("abc", new RandomAttribute(1, 10, "abc").Chars);

    [TestMethod] public void StringValueTest() => Assert.IsInstanceOfType(attr.CreateValue(typeof(string)), typeof(string));
    [TestMethod] public void DateTimeValueTest() => Assert.IsInstanceOfType(attr.CreateValue(typeof(DateTime)), typeof(DateTime));
    [TestMethod] public void DoubleValueTest() => Assert.IsInstanceOfType(attr.CreateValue(typeof(double)), typeof(double));
    [TestMethod] public void DecimalValueTest() => Assert.IsInstanceOfType(attr.CreateValue(typeof(decimal)), typeof(decimal));
    [TestMethod] public void Int32ValueTest() => Assert.IsInstanceOfType(attr.CreateValue(typeof(int)), typeof(int));
    [TestMethod] public void NullableValueTest() => Assert.IsInstanceOfType(attr.CreateValue(typeof(int?)), typeof(int));
    [TestMethod] public void BoolValueTest() => Assert.IsInstanceOfType(attr.CreateValue(typeof(bool)), typeof(bool));

    [TestMethod]
    public void ScaleRoundsTest()
    {
        var a = new RandomAttribute(0, 100, (sbyte)2);
        var d = (double)a.CreateValue(typeof(double));
        Assert.AreEqual(Math.Round(d, 2), d);
    }
}