namespace Abc.Data
{
    public class TypeOfProduct
    {
        public Guid ProductTypeId { get; set; } // not Guid? cause it needs to have Guid or else it doesn't exist
        public ProductType ProductType { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }


        public DateTime? AssignedAt { get; set; }
    }
}
