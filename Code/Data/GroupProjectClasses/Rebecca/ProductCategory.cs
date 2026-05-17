using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data.GroupProjectClasses.Rebecca;

public class ProductCategory : DetailedEntity
{
    [Select(typeof(ProductInfo))] public Guid? ProductId { get; set; }
    public ProductInfo Product { get; set; }

    [Select(typeof(Category))] public Guid? CategoryId { get; set; }
    public Category Category { get; set; }
}
