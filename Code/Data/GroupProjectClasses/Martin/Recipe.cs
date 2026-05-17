using Abc.Data.Common;
using Abc.Data.GroupProjectClasses.Nora;


namespace Abc.Data.GroupProjectClasses.Martin;

public class Recipe : BaseEntity
{
    public string Name { get; set; } = "";
    public string Details { get; set; } = "";
    public ICollection<UserRecipe> Ingredients { get; set; } = [];
    public ICollection<InternetRecipe> Sources { get; set; } = [];
    public ICollection<AvailableRecipe> AvailableRecipes { get; set; } = [];
}
