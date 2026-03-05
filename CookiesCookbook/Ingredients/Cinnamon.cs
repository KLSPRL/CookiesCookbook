using CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.Ingredients
{
    class Cinnamon : Ingredient, IMeasurable
    {
        public Cinnamon() : base(7, nameof(Cinnamon))
        {
        }

        public override string PreparationInstructions => $"{Measure()} {base.PreparationInstructions}";
        public string Measure() => "Take half a teaspoon.";
    }
}
