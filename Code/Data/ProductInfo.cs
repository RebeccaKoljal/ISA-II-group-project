using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data;

public class ProductInfo : NamedEntity
{
    [DisplayName("Product ID")] public override Guid Id { get; set; }
    public string Barcode { get; set; } // FK to Barcode
    [DisplayName("Product")] public override string Name { get; set; }
    public string Brand { get; set; }
    [DisplayName("Description")] public override string Details { get; set; }
    public string ImageUrl { get; set; }
    [DisplayName("Expiry Date")] public override DateTime? ValidTo { get; set; }
    public int CategoryId { get; set; } // FK to Category
    public string WeightOrVolume { get; set; }
    [DisplayName("Created At")] public override DateTime? ValidFrom { get; set; }
    public DateTime UpdatedAt { get; set; }
}
