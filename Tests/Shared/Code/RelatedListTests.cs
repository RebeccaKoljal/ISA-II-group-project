using System.Linq;
using System.Reflection;
using Abc.Shared.Code;

namespace Abc.Tests.Shared.Code;

[TestClass]
public sealed class RelatedListTests
{
    private sealed class TestItem
    {
        public string FirstName { get; set; }
        public int Count { get; set; }
    }

    private sealed class Holder
    {
        public List<TestItem> ListProp { get; set; } = [];
        public TestItem[] ArrayProp { get; set; } = [];
        public int NotCollection { get; set; }
    }

    private static PropertyInfo prop(string name) => typeof(Holder).GetProperty(name);
    private IQueryable<object> items;
    private RelatedList obj;

    [TestInitialize]
    public void Initialize()
    {
        items = new List<object> { new TestItem(), new TestItem() }.AsQueryable();
        obj = new RelatedList(prop(nameof(Holder.ListProp)), items);
    }

    [TestMethod] public void NameTest() => Assert.AreEqual(nameof(Holder.ListProp), obj.Name);

    [TestMethod] public void ItemsTest() => Assert.AreEqual(2, obj.Items.Count());

    [TestMethod] public void CountTest() => Assert.AreEqual(2, obj.Count);

    [TestMethod]
    public void ItemTypeTest()
    {
        Assert.AreEqual(typeof(TestItem), obj.ItemType);
        var a = new RelatedList(prop(nameof(Holder.ArrayProp)), items);
        Assert.AreEqual(typeof(TestItem), a.ItemType);
        var n = new RelatedList(prop(nameof(Holder.NotCollection)), items);
        Assert.IsNull(n.ItemType);
    }

    [TestMethod]
    public void PropertiesTest()
    {
        var names = obj.Properties.Select(p => p.Name).ToList();
        Assert.IsTrue(names.Contains(nameof(TestItem.FirstName)));
        Assert.IsTrue(names.Contains(nameof(TestItem.Count)));
        var n = new RelatedList(prop(nameof(Holder.NotCollection)), items);
        Assert.AreEqual(0, n.Properties.Length);
    }
}