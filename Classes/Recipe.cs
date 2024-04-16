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
        private Ingredient[] ingredients; // Array to store ingredients
        private Steps[] step; // Array to store steps

        // Constructor to initialize arrays based on the number of ingredients and steps
        public Recipe(int numIngredients, int numSteps)
        {
            ingredients = new Ingredient[numIngredients];
            step = new Steps[numSteps];
        }

        // Method to add an ingredient to the recipe at a specified index
        public void AddIngredient(int index, Ingredient ingredient)
        {
            ingredients[index] = ingredient;
        }

        // Method to add a step to the recipe at a specified index
        public void AddSteps(int index, Steps step)
        {
            Steps[index] = step;
        }

        // Method to display the full recipe, including ingredients and steps
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < step.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {step[i].Description}");
            }
        }

        // Method to scale the recipe by a specified factor
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Method to reset ingredient quantities to their original values
        public void ResetQuantities()
        {
            for (int i = 0; i < Ingredient.Length; i++)
            {
                Ingredient[i].Quantity = originalQuantities[i];
            }

        }

        // Method to clear all data and start afresh for a new recipe
        public void ClearRecipe()
        {
            Array.Clear(ingredients, 0, ingredients.Length);
            Array.Clear(step, 0, step.Length);
        }
    }
}
