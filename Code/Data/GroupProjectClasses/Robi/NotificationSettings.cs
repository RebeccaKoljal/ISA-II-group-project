using Abc.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Abc.Data.GroupProjectClasses.Robi;

public class NotificationSettings : BaseEntity
{
    [Display(Name = "User ID")]
    public Guid UserId { get; set; }

    [Display(Name = "Email Notifications")]
    public bool IsEmailEnabled { get; set; } = true;

    [Display(Name = "Push Notifications")]
    public bool IsPushEnabled { get; set; } = true;

    [Display(Name = "Days Before Expiry")]
    public int DaysBeforeExpiry { get; set; } = 3;
}