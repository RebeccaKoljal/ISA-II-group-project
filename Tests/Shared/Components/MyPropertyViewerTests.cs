namespace Abc.Tests.Shared.Components;

using Abc.Aids;
using Abc.Shared.Components;
using Abc.Tests.Aids;
using Bunit;

[TestClass]
public sealed class MyPropertyViewerTests : BaseTests<MyPropertyViewer>
{
    private TestContext c;
    private MyPropertyViewer o;
    private string l;
    private string v;

    [TestInitialize]
    public override void Initialize()
    {
        base.Initialize();
        c = new TestContext();
        l = GetRandom.String(5, 10);
        v = GetRandom.String(5, 10);
        o = new MyPropertyViewer { Label = l, Value = v };
    }

    [TestCleanup]
    public void Cleanup()
    {
        c.Dispose();
        c = null;
    }

    [TestMethod]
    public void LabelTest()
    {
        AreEqual(string.Empty, obj.Label);
        AreEqual(l, o.Label);
    }

    [TestMethod]
    public void ValueTest()
    {
        AreEqual(null, obj.Value);
        AreEqual(v, o.Value);
    }

    [TestMethod]
    public void RenderMarkupTest()
    {
        var r = c.RenderComponent<MyPropertyViewer>(p => p
            .Add(x => x.Label, l)
            .Add(x => x.Value, v));
        r.MarkupMatches(
            $"<dl class=\"row\">" +
            $"<dt class=\"col-sm-2\">{l}</dt>" +
            $"<dd class=\"col-sm-10\">{v}</dd>" +
            $"</dl>");
    }
}