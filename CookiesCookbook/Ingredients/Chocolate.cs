using CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.Ingredients
{
    class Chocolate : Ingredient, IMeltable
    {
        public Chocolate() : base(4, nameof(Chocolate))
        {
        }
        public override string PreparationInstructions => $"{Melt()} {base.PreparationInstructions}";

        public string Melt() => "Melt on water bath.";
    }
}
