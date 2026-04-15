using Abc.Data.Common;

namespace Abc.Data
{
    public class Product : NamedEntity
    {
        // inherited: Guid Id, string Name, string Code (from NamedEntity/DetailedEntity)
        public string Barcode { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public DateTime? CachedAt { get; set; }

        // ICollection is for the many to many relationship and better for future
        public ICollection<TypeOfProduct> TypeOfProduct { get; set; } = new List<TypeOfProduct>();
    }
}
