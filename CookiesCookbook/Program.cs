using CookiesCookbook;
using CookiesCookbook.Models;

var cookiesCookbookApp = new CookiesCookbookApp(
    new RecipeRepository(),
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
            //_recipeRepository.Write(filepath, allrecipes);

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
















/* 
Variabile booleana per tenere traccia del formato del file, se TXT o JSON - OK
Architettura applicazione - Creazione Punto di Partenza (Classe + metodo Run()) 
Printing existing recipes
Printing single recipe
Storing recipes in a text file
Printing available ingredients
Selecting ingredients for a new recipe
 */

//File method to count number of lines in the file based on the file format (TXT or JSON)
//using CookiesCookbook;
//using CookiesCookbook.FileHandlers;
//using CookiesCookbook.Ingredients;
//using CookiesCookbook.Models;

//var fileFormat = FileFormat.Txt; // Change to FileFormat.JSON if you want to use JSON format
//var fileName = $"recipes.{fileFormat}";

//List<Ingredient> chocolateCakeIngredients = new List<Ingredient>
//{
//    new Chocolate(),
//    new Sugar(),
//    new WheatFlour()
//};
//List<Ingredient> brownieIngredients = new List<Ingredient>
//{
//    new Chocolate(),
//    new Sugar(),
//    new Butter()
//};

//Recipe brownies = new Recipe(brownieIngredients);
//Recipe chocolateCake = new Recipe(chocolateCakeIngredients);
////controllo che file esiste
//bool RecipeFileExists(string fileName) => File.Exists(fileName);

//TxtFileHandler txt = new TxtFileHandler();

//txt.Write(fileName, brownies);
//Console.WriteLine(txt.ReadLines(fileName));

//Console.ReadKey();
////se ho almeno una ricetta chiamo il metodo Printing existing recipes

//    /* Printing existing recipes:


//    */

