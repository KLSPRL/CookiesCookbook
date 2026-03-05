/* 
Variabile booleana per tenere traccia del formato del file, se TXT o JSON
Printing existing recipes
Printing single recipe
Storing recipes in a text file
Printing available ingredients
Selecting ingredients for a new recipe
 */

//File method to count number of lines in the file based on the file format (TXT or JSON)
using CookiesCookbook.Models;

var fileFormat = FileFormat.Txt; // Change to FileFormat.JSON if you want to use JSON format
var fileName = "recipes";

bool RecipeFileExists(string fileName, FileFormat fileFormat)
{
    string extension = fileFormat.GetFileExtension();
    string fullFileName = fileName + extension;

    return File.Exists(fullFileName);
}






Console.ReadKey();