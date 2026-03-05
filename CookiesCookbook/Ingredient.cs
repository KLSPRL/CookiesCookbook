namespace CookiesCookbook;

public abstract class Ingredient
{
    protected Ingredient(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; init; }
    public string Name { get; init; }
    public virtual string PreparationInstructions => "Add to other ingredients.";

}
