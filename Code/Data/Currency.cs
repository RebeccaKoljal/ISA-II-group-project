using System.ComponentModel.DataAnnotations;

namespace Abc.Data
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual DateTime? ValidFrom { get; set; }
        public virtual DateTime? ValidTo { get; set; }
        [Timestamp] public virtual byte[] Timestamp { get; set; }
    }
    public abstract class DetailedEntity : BaseEntity
    {
        public virtual string Details { get; set; } = "";
    }
    public abstract class NamedEntity : DetailedEntity
    {
        public virtual string Name { get; set; } = "";
        public virtual string Code { get; set; } = "";
    }
    public class Currency : NamedEntity
    {
        public string NumericCode { get; set; } = "";
        public string MajorUnitSymbol { get; set; } = "";
        public string MinorUnitSymbol { get; set; } = "";
        public string RatioOfMinorUnit { get; set; }
        public bool IsIsoCurrency { get; set; }
    }
}