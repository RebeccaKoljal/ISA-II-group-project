namespace Abc.Tests.Shared.Components;

using System;
using Abc.Aids;
using Abc.Shared.Components;
using Abc.Tests.Aids;
using Microsoft.AspNetCore.Components.Forms;

[TestClass] public class EditorAdapterTests : BaseTests<EditorAdapter>
{
    private sealed class TestItem
    {
        public string FirstName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Count { get; set; }
    }

    private TestItem item;

    [TestInitialize]
    public override void Initialize()
    {
        base.Initialize();
        item = new TestItem
        {
            FirstName = GetRandom.String(),
            IsActive = true,
            CreatedDate = DateTime.Now,
            Count = GetRandom.Int32()
        };
    }

    [TestMethod]
    public void HasPropertyDefaultIsFalse()
    {
        IsFalse(obj.HasProperty);
    }

    [TestMethod] public void HasEditorDefaultIsFalse()
    {
        IsFalse(obj.HasEditor);
    }

    [TestMethod]
    public void DisplayNameDefaultIsEmpty()
    {
        AreEqual(string.Empty, obj.DisplayName);
    }

    [TestMethod]
    public void PropInfoDefaultIsNull()
    {
        AreEqual(null, obj.PropInfo);
    }

    [TestMethod]
    public void HasPropertyWithValidPropertyIsTrue()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.FirstName));
        IsTrue(a.HasProperty);
    }

    [TestMethod]
    public void HasEditorWithValidPropertyIsTrue()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.FirstName));
        IsTrue(a.HasEditor);
    }

    [TestMethod]
    public void DisplayNameAddsSpacesBeforeCapitals()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.FirstName));
        AreEqual("First Name", a.DisplayName);
    }

    [TestMethod]
    public void DisplayNameForLongerCamelCase()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.CreatedDate));
        AreEqual("Created Date", a.DisplayName);
    }

    [TestMethod]
    public void PropInfoReturnsCorrectProperty()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.FirstName));
        AreEqual(nameof(TestItem.FirstName), a.PropInfo.Name);
    }

    [TestMethod]
    public void EditorForStringIsInputText()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.FirstName));
        AreEqual(typeof(InputText), a.Editor);
    }

    [TestMethod]
    public void EditorForBoolIsInputCheckbox()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.IsActive));
        AreEqual(typeof(InputCheckbox), a.Editor);
    }

    [TestMethod]
    public void EditorForDateIsInputDate()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.CreatedDate));
        AreEqual(typeof(InputDate<DateTime>), a.Editor);
    }

    [TestMethod]
    public void EditorForNumericIsInputNumber()
    {
        var a = new EditorAdapter(null, item, nameof(TestItem.Count));
        AreEqual(typeof(InputNumber<int>), a.Editor);
    }
}