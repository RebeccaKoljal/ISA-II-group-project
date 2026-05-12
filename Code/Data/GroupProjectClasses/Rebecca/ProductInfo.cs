using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data.GroupProjectClasses.Rebecca;

public class ProductInfo : NamedEntity
{
    [DisplayName("Product ID")] public override Guid Id { get; set; }
    public string Barcode { get; set; } // FK to Barcode
    [DisplayName("Product name")] public override string Name { get; set; }
    public string Brand { get; set; }
    [DisplayName("Description")] public override string Details { get; set; }
    public string ImageUrl { get; set; }
    [DisplayName("Expiry Date")] public override DateTime? ValidTo { get; set; }
    public Guid CategoryId { get; set; } // FK to Category NEED TO REPLACE WHEN CATEGORY IS DONE IG
    public string WeightOrVolume { get; set; }
    [DisplayName("Created at")] public override DateTime? ValidFrom { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
