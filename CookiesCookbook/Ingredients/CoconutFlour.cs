using CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.Ingredients
{
    class CoconutFlour : Ingredient, ISiftable
    {
        public CoconutFlour() : base(2, nameof(CoconutFlour) + ".")
        {
        }
        public override string PreparationInstructions => $"{Sieve()} {base.PreparationInstructions}";
        public string Sieve() => "Sieve.";
    }
}
