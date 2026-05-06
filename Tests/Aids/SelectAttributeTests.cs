using Abc.Aids;

namespace Abc.Tests.Aids;

[TestClass]
public class SelectAttributeTests : TestAids
{
    private string displayProperty;
    private Type entityType;
    private SelectAttribute o;

    [TestInitialize]
    public  void Initialize()
    {
        
        type = typeof(SelectAttribute);
        entityType = typeof(string);
        o = new SelectAttribute(entityType);
    }

    [TestMethod] public void EntityTypeTest() => AreEqual(entityType, o.EntityType);
    [TestMethod] public void DisplayPropertyDefaultTest() => AreEqual("Name", o.DisplayProperty);
    [TestMethod] public void DisplayPropertySetTest()
    {
        var attr = new SelectAttribute(typeof(string), "Title");
        AreEqual("Title", attr.DisplayProperty);
    }
    [TestMethod] public void HasAttributeUsageTests()
    {
        Assert.IsNotEmpty(typeof(SelectAttribute).GetCustomAttributes(typeof(AttributeUsageAttribute), false));
    }
}