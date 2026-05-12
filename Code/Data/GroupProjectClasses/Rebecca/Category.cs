using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data.GroupProjectClasses.Rebecca;

public class Category : NamedEntity
{
    [DisplayName("Category ID")] public override Guid Id { get; set; }
    [DisplayName("Category name")] public override string Name { get; set; }
    public Guid ParentCategoryId { get; set; } // so when we want to expand the category types
}
