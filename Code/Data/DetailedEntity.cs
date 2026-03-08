namespace Abc.Data
{
    public abstract class DetailedEntity : BaseEntity
    {
        public virtual string Details { get; set; } = "";
    }
}