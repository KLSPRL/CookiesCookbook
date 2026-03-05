namespace CookiesCookbook.Ingredients
{
    public abstract class IngredientBase
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public abstract string PreparationInstructions { get; }
    }
}