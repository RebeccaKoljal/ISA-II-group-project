using Abc.Aids;

namespace Abc.Tests.Aids;

[TestClass] public class PropertyAdapterTests : BaseTests<PropertyAdapter>
{
    private class TestClass
    {
        public int? IntProp { get; set; }
        public string StringProp { get; set; }
    }
    private TestClass item;
    private string propName = nameof(TestClass.IntProp);
    private PropertyAdapter oStr;
    [TestInitialize] public override void Initialize()
    {
        base.Initialize();
        item = new TestClass();
        obj = new PropertyAdapter(item, propName);
        oStr = new PropertyAdapter(item, nameof(TestClass.StringProp));
    }
    [TestMethod] public void ItemTypeTest() => AreEqual(typeof(TestClass), obj.ItemType);
    [TestMethod] public void ItemTest() => AreSame(item, obj.Item);
    [TestMethod] public void PropInfoTest() => AreEqual(propName, obj.PropInfo.Name);
    [TestMethod] public void PropTypeTest() 
    { 
        AreEqual(typeof(int?), obj.PropType);
        AreEqual(typeof(string), oStr.PropType);
    }
    [TestMethod] public void UnderLyingTypeTest()
    {
        AreEqual(typeof(int), obj.UnderLyingType);
        AreEqual(typeof(string), oStr.UnderLyingType);
    }
    [TestMethod] public void PropValueTest() 
    { 
        AreEqual(null, obj.PropValue); 
        AreEqual(null, oStr.PropValue); 
    }
    [TestMethod] public void SetValueTest()
    {
        var i = GetRandom.Int32();
        var s = GetRandom.String();
        obj.SetValue(i);
        oStr.SetValue(s);
        AreEqual(i, item.IntProp);
        AreEqual(s, item.StringProp);
        AreEqual(obj.PropValue, item.IntProp);
        AreEqual(oStr.PropValue, item.StringProp);
    }
}
