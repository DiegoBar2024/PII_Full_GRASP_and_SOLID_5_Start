using System;

namespace Full_GRASP_And_SOLID
{
    // Creo una interfaz IRecipeContent la cual me defina una única operación abstracta GetTextToPrint
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}