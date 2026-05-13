using System;
using Abc.Data.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Abc.Data.GroupProjectClasses.Elizaveta;

public class ExpiryDate : BaseEntity
{
  [DisplayName("Expiry Date")] public DateTime Date { get; set; }
  [DisplayName("Product Info")] public Guid ProductInfoId { get; set; }
  [NotMapped][DisplayName ("Is Expired")] public bool IsExpired => Date < DateTime.Now;
}

