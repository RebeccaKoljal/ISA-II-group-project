using System.ComponentModel.DataAnnotations;

namespace Abc.Data.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid(); // global unique identifier so that we can use it across different databases without conflicts
        public virtual DateTime? ValidFrom { get; set; }
        public virtual DateTime? ValidTo { get; set; }
        [Timestamp] public virtual byte[] Timestamp { get; set; }
    }
}