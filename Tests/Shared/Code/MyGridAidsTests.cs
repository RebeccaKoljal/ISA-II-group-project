namespace Abc.Tests.Shared.Code;

using System.Collections.Generic;
using System.Reflection;
using Abc.Shared.Code;
using Abc.Tests.Aids;
using Abc.Aids;

[TestClass]
public class MyGridAidsTests : TestAids
{
    private sealed class TestClass
    {
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }
        public object ObjectProperty { get; set; }
        public List<int> EnumerableProperty { get; set; }
    }

    private TestClass o;

    [TestInitialize]
    public void TestInitialize()
    {
        type = typeof(MyGridAids);
        o = new TestClass
        {
            StringProperty = GetRandom.String(),
            IntProperty = GetRandom.Int32(),
            ObjectProperty = new object(),
            EnumerableProperty = new List<int> { GetRandom.Int32(), GetRandom.Int32() }
        };
    }

    private static PropertyInfo getProp(string name) =>
        typeof(TestClass).GetProperty(name);

    [DataRow(nameof(TestClass.StringProperty), true)]
    [DataRow(nameof(TestClass.IntProperty), true)]
    [DataRow(nameof(TestClass.ObjectProperty), false)]
    [DataRow(nameof(TestClass.EnumerableProperty), false)]
    [TestMethod]
    public void ShowTest(string name, bool show)
    {
        AreEqual(show, MyGridAids.Show(getProp(name)));
    }

    [TestMethod]
    public void ValueTest()
    {
        AreEqual(o.StringProperty, MyGridAids.Value(getProp(nameof(TestClass.StringProperty)), o));
        AreEqual(o.IntProperty.ToString(), MyGridAids.Value(getProp(nameof(TestClass.IntProperty)), o));
        AreEqual(o.ObjectProperty.ToString(), MyGridAids.Value(getProp(nameof(TestClass.ObjectProperty)), o));
        AreEqual(o.EnumerableProperty.ToString(), MyGridAids.Value(getProp(nameof(TestClass.EnumerableProperty)), o));
    }

    [TestMethod]
    public void ValueNullTest()
    {
        o = new TestClass();
        AreEqual("", MyGridAids.Value(getProp(nameof(TestClass.StringProperty)), o));
        AreEqual(o.IntProperty.ToString(), MyGridAids.Value(getProp(nameof(TestClass.IntProperty)), o));
        AreEqual("", MyGridAids.Value(getProp(nameof(TestClass.ObjectProperty)), o));
        AreEqual("", MyGridAids.Value(getProp(nameof(TestClass.EnumerableProperty)), o));
    }
}
