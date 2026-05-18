using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data.GroupProjectClasses.Martin;

public class InternetRecipe : BaseEntity
{
    [Select(typeof(Recipe))] public Guid? RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    [Random(10, 50)] public string Url { get; set; } = "";
    [Random(5, 15)] public string Source { get; set; } = "";
}



