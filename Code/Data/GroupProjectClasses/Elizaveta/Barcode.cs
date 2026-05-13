using System;
using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data.GroupProjectClasses.Elizaveta;

public class Barcode : NamedEntity 
{
[DisplayName("Barcode ID")] public DateTime ScannedAt { get; set; } = DateTime.Now;
[DisplayName("Product ID")] public Guid ProductId { get; set; } 
}
