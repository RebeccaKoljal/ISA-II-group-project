using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data.GroupProjectClasses.Elizaveta;

public class ShoppingSession : NamedEntity
{
    [DisplayName("Store Name")] public string StoreName { get; set; } = "";
    [DisplayName("Session Date")] public DateTime SessionDate { get; set; } = DateTime.UtcNow;
}