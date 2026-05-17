using Abc.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Abc.Data.GroupProjectClasses.Robi;

public class NotificationType : NamedEntity
{
    [Display(Name = "Type Name")] public override string Name { get; set; }

    [Display(Name = "Description")] public override string Details { get; set; }
}