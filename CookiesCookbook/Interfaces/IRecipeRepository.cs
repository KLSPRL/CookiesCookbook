using CookiesCookbook;

public interface IRecipeRepository
{
    List<Recipe>Read(string filePath);
}