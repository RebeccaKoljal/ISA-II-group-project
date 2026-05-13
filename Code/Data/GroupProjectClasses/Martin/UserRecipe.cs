using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data;

public class UserRecipe : BaseEntity
{
    [Select(typeof(Recipe))] public Guid? RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    [Random(4, 12)] public string ProductName { get; set; } = "";
}
