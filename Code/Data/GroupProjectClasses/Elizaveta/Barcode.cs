using System;
using Abc.Data.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Data.GroupProjectClasses.Elizaveta;

public class Barcode : NamedEntity 
{
[DisplayName("Scanned on")] public DateTime ScannedAt { get; set; } = DateTime.Now;
[DisplayName("Product ID")] public Guid ProductId { get; set; } 

[Display(AutoGenerateField = false)] public override DateTime? ValidFrom { get; set; }
[Display(AutoGenerateField = false)] public override DateTime? ValidTo { get; set; } //peidan BaseEntity klassid
}
