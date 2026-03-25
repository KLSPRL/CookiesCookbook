using CookiesCookbook;
using CookiesCookbook.Ingredients;
using System.Collections.Concurrent;

public class IngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new Butter(),
        new Chocolate(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder(),
        new CoconutFlour(),
        new Sugar()
    };
}

public class RecipeConsoleUserInteraction : IRecipeUserInteraction
{
    private readonly IngredientsRegister _ingredientsRegister;

    public RecipeConsoleUserInteraction(IngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:\n");
            int counter = 1;

            foreach(var recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                counter++;
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:\n");

        foreach (var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}