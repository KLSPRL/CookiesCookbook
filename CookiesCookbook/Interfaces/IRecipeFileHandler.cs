using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.Interfaces
{
    internal interface IRecipeFileHandler
    {
        int ReadLines(string fileName);
        void Write(string fileName, Recipe recipe);
    }
}
