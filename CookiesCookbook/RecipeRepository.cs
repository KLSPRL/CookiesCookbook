using CookiesCookbook;
using CookiesCookbook.Ingredients;

public class RecipeRepository : IRecipeRepository
{
    public List<Recipe> Read(string filePath)
    {

        return new List<Recipe>
        {
            new Recipe(new List<Ingredient> {new Sugar(), new Butter(), new Chocolate(), new WheatFlour()}),
            new Recipe(new List<Ingredient> {new Butter(), new CoconutFlour(), new WheatFlour()})
        };

    }
}