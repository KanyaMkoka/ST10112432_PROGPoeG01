using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10112432_PROGPart1.Classes
{
    //This Recipe class was created to store all the ingredients and steps of the recipe
    public class Recipe
    {
        public Ingredient[] Ingredients { get; set; }
        public string[] Procedure { get; set; }

        public Recipe(int numIngredients, int numProcedure)
        { 
            Ingredients = new Ingredient[numIngredients];
            Procedure = new string[numProcedure];
        }

        public void addIngredient(int index, string name, double quantity, string unit)
        {
            Ingredients[index] = new Ingredient(name, quantity, unit);
        }

        public void steps (int index, string describeStep)
        {
            Procedure[index] = describeStep;
        }

        public void displayRecipe()
        {
            Console.WriteLine("Ingredients: ");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{Ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Procedure.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Procedure[i].Description}");
            }
        }

        public void recipeScale(double factor)
        {
            foreach (var ingredients in Ingredient)
            {
                ingredients.Quantity *= factor;
            }
        }

        public void resetQuantities ()
        {

        }
    }
}
