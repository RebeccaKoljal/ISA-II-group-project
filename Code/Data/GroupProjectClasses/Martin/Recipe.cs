using Abc.Data.Common;

namespace Abc.Data;

public class Recipe : NamedEntity
{
    public ICollection<UserRecipe> Ingredients { get; set; } = [];
    public ICollection<InternetRecipe> Sources { get; set; } = [];
}
