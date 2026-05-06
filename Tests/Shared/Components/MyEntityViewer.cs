namespace Abc.Tests.Shared.Components;

using System.Linq;
using Abc.Aids;
using Abc.Shared.Components;
using Abc.Tests.Aids;
using Bunit;

[TestClass]
public sealed class MyEntityViewerTests : BaseTests<MyEntityViewer>
{
    private sealed class SampleEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    private TestContext c;
    private MyEntityViewer o;
    private SampleEntity e;

    [TestInitialize]
    public override void Initialize()
    {
        base.Initialize();
        e = new SampleEntity
        {
            Name = GetRandom.String(5, 10),
            Age = GetRandom.Int32(1, 100)
        };
        o = new MyEntityViewer { Entity = e };
        c = new TestContext();
    }

    [TestCleanup]
    public void Cleanup()
    {
        c.Dispose();
        c = null;
    }

    [TestMethod]
    public void EntityTest()
    {
        AreEqual(null, obj.Entity);
        AreSame(e, o.Entity);
    }

    [TestMethod]
    public void RenderMarkupTest()
    {
        var r = c.RenderComponent<MyEntityViewer>(p => p.Add(x => x.Entity, e));
        var labels = r.FindAll("dt").Select(x => x.TextContent).ToList();
        var values = r.FindAll("dd").Select(x => x.TextContent).ToList();

        AreEqual(2, labels.Count);
        AreEqual(2, values.Count);
        Assert.Contains("Name", labels);
        Assert.Contains("Age", labels);
        Assert.Contains(e.Name, values);
        Assert.Contains(e.Age.ToString(), values);
    }
    [TestMethod]
    public void RenderNullEntityTest()
    {
        var r = c.RenderComponent<MyEntityViewer>(p => p.Add(x => x.Entity, null));
        AreEqual(0, r.FindAll("dt").Count);
        AreEqual(0, r.FindAll("dd").Count);
    }
}