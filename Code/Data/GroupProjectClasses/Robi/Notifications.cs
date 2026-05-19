using Abc.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Abc.Data.GroupProjectClasses.Robi;

public class Notifications : NamedEntity
{
    [Display(Name = "User ID")] public Guid UserId { get; set; }

    [Display(Name = "Notification Type ID")] public Guid NotificationTypeId { get; set; }

    [Display(Name = "Message")] public override string Name { get; set; }

    [Display(Name = "Sent At")] public DateTime? SentAt { get; set; }

    public bool IsRead { get; set; }
    public Guid? ProductId { get; set; }

}