using Abc.Aids;
using Abc.Data;
using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data.GroupProjectClasses.Nora;

public class AvailableRecipe : BaseEntity
{
    [Select(typeof(User))] public Guid UserId { get; set; }
    public User User { get; set; }
    [Select(typeof(Recipe))] public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
