using System.Runtime.InteropServices;

namespace CookiesCookbook;

public abstract class Ingredient
{
    protected Ingredient(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; }
    public string Name { get;}
    public virtual string PreparationInstructions => "Add to other ingredients.";
    public override string ToString() => $"{Id}. {Name}";

}
