using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10112432_PROGPart1.Classes
{
    public class Recipe
    {
        public Ingredient[] Ingredients { get; set; }
        public string[] Procedure { get; set; }

        public Recipe(int numIngredients, int numProcedure)
        { 
            Ingredients = new Ingredient[numIngredients];
            Procedure = new string[numProcedure];
        }
    }
}
