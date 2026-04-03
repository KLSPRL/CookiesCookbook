using CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookiesCookbook.FileHandlers
{
    class JsonFileHandler : IRecipeFileHandler
    {
        public List<string> ReadLines(string path)
        {
            throw new NotImplementedException();
        }

        public void Write(string path, Recipe recipe)
        {
            throw new NotImplementedException();
        }

        int IRecipeFileHandler.ReadLines(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
