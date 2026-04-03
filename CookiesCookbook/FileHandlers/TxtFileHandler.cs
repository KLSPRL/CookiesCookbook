using CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.FileHandlers
{
    class TxtFileHandler : IRecipeFileHandler
    {
        public int ReadLines(string fileName)
        {
            return File.ReadAllLines(fileName).Length -1;
        }

        public void Write(string path, Recipe recipe)
        {
            List<string> recipeIds = recipe.ReturnRecipeIngredients();
            string Ids = string.Join(",", recipeIds);
            Ids = Ids + "\n";
            File.AppendAllText(path, Ids);
        }
    }
}
