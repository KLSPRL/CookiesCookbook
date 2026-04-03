using CookiesCookbook;

public interface IRecipeUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    //utilizziamo IEnumarable come best practice, in quanto interfaccia piu generica che puo comprendere anche array
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
}