using Abc.Data.Common;
using Abc.Data.GroupProjectClasses.Elizaveta;
using Abc.Aids;

namespace Abc.Data.GroupProjectClasses.Rebecca;

public class ProductInfo : NamedEntity
{
    [Select(typeof(Barcode))] public Guid? BarcodeId { get; set; } // FK to Barcode
    [Select(typeof(Barcode))] public Guid? ProductId { get; set; }
    [Select(typeof(Barcode))] public DateTime? ScannedAt { get; set; }

    [Select(typeof(ExpiryDate))] public DateTime? Date { get; set; }

    public string Brand { get; set; }
    public string WeightOrVolume { get; set; }

    public ICollection<ProductCategory> ProductCategories { get; set; } = [];
    public ICollection<Category> Categories => [.. ProductCategories.Select(c => c.Category)];
}
