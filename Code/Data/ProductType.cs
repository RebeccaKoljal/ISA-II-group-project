using Abc.Data.Common;

namespace Abc.Data
{
    public class ProductType : NamedEntity
    {
        public ICollection<TypeOfProduct> TypeOfProduct { get; set; } = new List<TypeOfProduct>();
    }
}
