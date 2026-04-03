using CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.Ingredients
{
    internal class Butter : Ingredient, IMeltable
    {
        public Butter() : base(3, nameof(Butter) + ".")
        {
        }
        public override string PreparationInstructions => $"{Melt()} {base.PreparationInstructions}";

        public string Melt() => "Melt on low heat.";
    }
}

