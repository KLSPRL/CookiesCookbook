using CookiesCookbook;
using CookiesCookbook.Models;

var cookiesCookbookApp = new CookiesCookbookApp(
    new RecipeRepository(new StringsTextualRepository()),
    new RecipeConsoleUserInteraction(new IngredientsRegister()));

string fileExtension = FileFormat.Json.GetFileExtension();

cookiesCookbookApp.Run(fileExtension);

public class CookiesCookbookApp
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IRecipeUserInteraction _recipeUserInteraction;

    public CookiesCookbookApp(
        IRecipeRepository recipeRepository,
        IRecipeUserInteraction recipeConsoleUserInteraction)
    {
        _recipeRepository = recipeRepository;
        _recipeUserInteraction = recipeConsoleUserInteraction;
    }
    public void Run(string filePath)
    {
        //metodo per leggere le ricette
        var allRecipes = _recipeRepository.Read(filePath);
        //metodo per stampare a schermo le ricette - è un interazione con utente per questo recipeUserInteraction
        _recipeUserInteraction.PrintExistingRecipes(allRecipes);


        //richiesta utente creazione ricetta
        _recipeUserInteraction.PromptToCreateRecipe();
        //lettura ingredienti da parte utente
        var ingredients = _recipeUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipeRepository.Write(filePath, allRecipes);

            _recipeUserInteraction.ShowMessage("Recipe added:");
            _recipeUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipeUserInteraction.ShowMessage(
                "no ingredients have been selected. " +
                "recipe will not be saved.");
        }

        _recipeUserInteraction.Exit();
    }
}





