/* Name: Kanya Mkoka
 * Student Number: ST10112432
 * Group: 01
 * I acknowledge bits of this code is not my own work and has been extracted from https://chat.openai.com/c/38ab336e-fa71-4664-9ee5-b5cc60bf834f, 
 * https://www.youtube.com/watch?v=67oWw9TanOk&list=PL82C6-O4XrHfoN_Y4MwGvJz5BntiL0z0D and https://stackoverflow.blog/2022/06/15/c-ienumerable-yield-return-and-lazy-evaluation/
 */
using Microsoft.SqlServer.Server;
using ST10112432_PROGPart1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10112432_PROGPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Recipe App!");

                Console.WriteLine("Please enter the number of ingredients:");
                int numIngredients = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the number of steps:");
                int numSteps = Convert.ToInt32(Console.ReadLine());

                Recipe recipe = new Recipe(numIngredients, numSteps);

                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"Enter details for ingredient {i + 1}:");
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Quantity:");
                    double quantity = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Unit of Measurement:");
                    string unit = Console.ReadLine();

                    recipe.AddIngredient(i, new Ingredient(name, quantity, unit));
                }

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Enter step {i + 1}:");
                    string description = Console.ReadLine();

                    recipe.AddStep(i, new steps(description));
                }  

                recipe.PrintRecipe();

                Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
                double factor = Convert.ToDouble(Console.ReadLine());
                recipe.ScaleRecipe(factor);
                recipe.PrintRecipe();

                //Reset quantities
                recipe.ResetQuantities();

                Console.WriteLine("Do you want to enter a new recipe? (yes/no)");
                string input = Console.ReadLine();
                if (input.ToLower() == "yes")
                {
                    //Clear data to enter a new recipe
                    recipe.ClearData();
                    //Repeat process for new recipe
                }
                else
                {
                    Console.WriteLine("Thank you for using the Recipe App!");
                }
            }
            catch (Exception rec)
            {
                Console.WriteLine($"An error occurred: {rec.Message}");
            }
        
        }
        static void AddRecipe()
        {
            Console.WriteLine("Please enter the name of the recipe: ");
            string recipeName = Console.ReadLine();

            Recipe recipe = new Recipe(recipeName);
            recipe.onCalorieNotification += Message => Console.WriteLine(Message);

            Console.WriteLine("Please enter the number of ingredients: ");
            int numIngredients = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numIngredients;i++)
            {
                Console.WriteLine($"Please enter the details for ingredient{i + 1}: ");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Quantity: ");
                double quantity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Unit of Measurement: ");
                string unit = Console.ReadLine();
                Console.WriteLine("Calories");
                double calories = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Food Group: ");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(new Ingredient(name, quantity, unit, foodGroup));
            }
            Console.WriteLine("Please enter the number of steps: ");
            int numSteps = Convert.ToInt32(Console.ReadLine());
            
                for(int i = 0; i < numSteps;i++)
                {
                  Console.WriteLine($"Enter step{i + 1}: ");
                  string description = Console.ReadLine();
                  recipe.AddStep(new Step(description));
                }
                recipes.Add(recipe);
        }
    }
}
