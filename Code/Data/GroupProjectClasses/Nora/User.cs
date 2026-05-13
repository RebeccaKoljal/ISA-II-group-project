using System.ComponentModel;
using Abc.Data.Common;

namespace Abc.Data.GroupProjectClasses.Nora;
public sealed class User : NamedEntity 
{
        [DisplayName("User ID")] public override Guid Id { get; set; }
        [DisplayName("Username")] public override string Name { get; set; } = "";
        [DisplayName("Email")] public string Email { get; set; } = "";
}

