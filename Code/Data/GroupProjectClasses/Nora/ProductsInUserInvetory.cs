using Abc.Aids;
using Abc.Data.Common;
using Abc.Data.GroupProjectClasses.Rebecca;
using System.ComponentModel;

namespace Abc.Data.GroupProjectClasses.Nora;
public class ProductsInUserInvetory : BaseEntity
{
    [Select(typeof(ProductInfo))] public Guid ProductId { get; set; }
    public ProductInfo Product { get; set; }
    [Select(typeof(User))] public Guid UserId { get; set; }
    public User User { get; set; }
    [DisplayName("Quantity")] public int Quantity { get; set; }
    [DisplayName("Expiry Date")] public DateTime ExpiryDate { get; set; }
   
}
