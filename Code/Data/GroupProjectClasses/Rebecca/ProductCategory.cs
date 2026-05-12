using Abc.Aids;

namespace Abc.Data.GroupProjectClasses.Rebecca;

public class ProductCategory
{
    [Select(typeof(ProductInfo))] public Guid? ProductId { get; set; }
    [Select(typeof(Category))] public Guid? CategoryId { get; set; }
    public ProductInfo Product { get; set; }
    public Category Category { get; set; }
}
