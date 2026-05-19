using Abc.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Abc.Data.GroupProjectClasses.Robi;

public class NotificationType : BaseEntity
{
    [Display(Name = "Type Name")]
    public string Name { get; set; } = "";

    [Display(Name = "Description")]
    public string Details { get; set; } = "";
}