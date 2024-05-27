
namespace Full_GRASP_And_SOLID
{
    // Cambio el tipo de parámetro recibido en PrintRecipe por IRecipeContent
    public interface IPrinter
    {
        void PrintRecipe(IRecipeContent recipeContent);
    }
}