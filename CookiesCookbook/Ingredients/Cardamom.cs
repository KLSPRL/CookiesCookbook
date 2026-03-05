using CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.Ingredients
{
    class Cardamom : Ingredient, IMeasurable
    {
        public Cardamom() : base(6, nameof(Cardamom))
        {
        }
        public override string PreparationInstructions => $"{Measure()} {base.PreparationInstructions}";
        public string Measure() => "Take half teaspoon.";
    }
}
