using System;
using System.ComponentModel;
using Abc.Data.Common;

namespace Abc.Data.GroupProjectClasses.Elizaveta;

public class Product : NamedEntity
{
  [DisplayName("Image URL")] public string ImageUrl { get; set; } = "";

}
