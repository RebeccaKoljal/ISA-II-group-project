using Abc.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Abc.Data.GroupProjectClasses.Robi;

public class NotificationSettings : NamedEntity
{
    [Display(Name = "User ID")] public Guid UserId { get; set; }

    [Display(Name = "Email Notifications")] public bool IsEmailEnabled { get; set; }

    [Display(Name = "Push Notifications")] public bool IsPushEnabled { get; set; }
}