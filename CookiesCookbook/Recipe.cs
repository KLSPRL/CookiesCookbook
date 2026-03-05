using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook
{
    public class Recipe
    {
        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
        public List<Ingredient> Ingredients { get; }
    }
}
