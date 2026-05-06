using Microsoft.AspNetCore.Components.Forms;

namespace Abc.Tests.Shared.Components;

using Abc.Aids;
using Abc.Shared.Components;
using Abc.Tests.Aids;
using Bunit;

[TestClass]
public sealed class MyEntityEditorTests : BaseTests<MyEntityEditor>
{
    private sealed class TestEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    private TestContext c;
    private MyEntityEditor o;
    private TestEntity e;

    [TestInitialize]
    public override void Initialize()
    {
        base.Initialize();
        c = new TestContext();
        e = new TestEntity
        {
            Name = GetRandom.String(5, 10),
            Code = GetRandom.String(2, 4)
        };
        o = new MyEntityEditor { Entity = e };
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
        AreEqual(e, o.Entity);
    }

    [TestMethod]
    public void RenderMarkupTest()
    {
        var editContext = new EditContext(e);
        var r = c.RenderComponent<MyEntityEditor>(p => p
        .Add(x => x.Entity, e)
        .AddCascadingValue(editContext));

        var editors = r.FindComponents<MyPropertyEditor>();
         AreEqual(2, editors.Count);

        AreEqual(e, editors[0].Instance.Item);
        AreEqual(nameof(TestEntity.Name), editors[0].Instance.PropertyName);

        AreEqual(e, editors[1].Instance.Item);
        AreEqual(nameof(TestEntity.Code), editors[1].Instance.PropertyName);
    }
}