using CookiesCookbook;
using CookiesCookbook.Ingredients;

public class RecipeRepository : IRecipeRepository
{
    private readonly IStringsRepository _stringsRepository;

    public RecipeRepository(IStringsRepository stringsRepository)
    {
        _stringsRepository = stringsRepository;
    }


    public List<Recipe> Read(string filePath)
    {

        return new List<Recipe>
        {
            new Recipe(new List<Ingredient> {new Sugar(), new Butter(), new Chocolate(), new WheatFlour()}),
            new Recipe(new List<Ingredient> {new Butter(), new CoconutFlour(), new WheatFlour()})
        };

    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = new List<string>();
        foreach (var recipe in allRecipes)
        {
            var allIds = new List<int>();
            foreach (var ingredient in recipe.Ingredients) 
            {
                allIds.Add(ingredient.Id);
            }
            recipesAsStrings.Add(string.Join(",", allIds));
        }
        _stringsRepository.Write(filePath, recipesAsStrings);
    }
}