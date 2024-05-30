/* Name: Kanya Mkoka
 * Student Number: ST10112432
 * Group: 01
 * I acknowledge bits of this code is not my own work and has been extracted from https://chat.openai.com/c/38ab336e-fa71-4664-9ee5-b5cc60bf834f, 
 * https://www.youtube.com/watch?v=67oWw9TanOk&list=PL82C6-O4XrHfoN_Y4MwGvJz5BntiL0z0D and https://stackoverflow.blog/2022/06/15/c-ienumerable-yield-return-and-lazy-evaluation/
 * 
 */
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
        public string Name { get; set; }
        private Ingredient[] ingredients;
        private Step[] steps;

        public delegate void CalorieNotification(string message);
        public event CalorieNotification onCalorieNotification;

        public Recipe(string name)
        {
            Name = name;
            ingredients = new Ingredient[1];
            steps = new Step[1];
        }

        public Recipe(int numIngredients, int numSteps)
        {
            ingredients = new Ingredient[numIngredients];
            steps = new Step[numSteps];
        }

        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
            CheckCalories();
        }

        public void AddStep(Step step)
        {
            steps.Add(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }

            Console.WriteLine($"Total Calories: {GetTotalCalories()}");
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity = ingredient.OriginalQuantity;
            }

        }

        private double GetTotalCalories()
        {
            double totalCalories = 0;
            foreach (var ingredient in ingredients)
            {
                totalCalories += ingredient.Calories * ingredient.Quantity;
            }
            return totalCalories;
        }

        private void CalorieCheck ()
        {
            if (GetTotalCalories() > 300)
            {
                onCalorieNotification?.Invoke($"Warning: The recipe \"{Name}\" exceeeds 300 calories!!");
            }
        }
        internal void ClearData()
        {
            throw new NotImplementedException();
        }

        internal void ResetQuantities()
        {
            throw new NotImplementedException();
        }
    }
}
