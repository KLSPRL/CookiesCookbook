using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook
{
    public class Recipe
    {
        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
        //usiamo IEnumerable perchè List è rischioso, IEnumerable permette solo ciclare un elenco, List permette anche la modifica 
        public IEnumerable<Ingredient> Ingredients { get; }

        public List<string> ReturnRecipeIngredients()
        {
            List<string> recipeIngredientsIds = new List<string>();

            foreach (var ingredient in Ingredients)
            {
                recipeIngredientsIds.Add(ingredient.Id.ToString());
            }

            return recipeIngredientsIds;
        }

        public override string ToString()
        {
            var steps = new List<string>();

            foreach (var ingredient in Ingredients)
            {
                steps.Add($"{ingredient.Name} {ingredient.PreparationInstructions}");
            }

            return string.Join(Environment.NewLine, steps);
        }
    }
}
