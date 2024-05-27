using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        // Le cambio el parámetro recibido de un tipo Recipe a un tipo RecipeContent
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
        }
    }
}