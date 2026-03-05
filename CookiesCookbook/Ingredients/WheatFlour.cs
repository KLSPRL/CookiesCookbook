using CookiesCookbook.Interfaces;

namespace CookiesCookbook.Ingredients;

public class WheatFlour : Ingredient, ISiftable
{
    public WheatFlour() : base(1, nameof(WheatFlour))
    {
    }
    public override string PreparationInstructions => $"{Sieve()} {base.PreparationInstructions}"; 

    public string Sieve() => "Sieve.";
}


    
