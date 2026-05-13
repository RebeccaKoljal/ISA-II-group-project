using Abc.Data.Common;
using Abc.Data.GroupProjectClasses.Nora;

namespace Abc.Data;

public class Recipe : NamedEntity
{
    public ICollection<UserRecipe> Ingredients { get; set; } = [];
    public ICollection<InternetRecipe> Sources { get; set; } = [];
    public ICollection<AvailableRecipe> AvailableRecipes { get; set; } = [];
}
