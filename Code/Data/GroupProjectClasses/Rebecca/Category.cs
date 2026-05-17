using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data.GroupProjectClasses.Rebecca;

public class Category : NamedEntity
{
    public Guid ParentCategoryId { get; set; } // so when we want to expand the category types
}
