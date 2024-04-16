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
                // Prompting user for number of ingredients and steps
                Console.WriteLine("Enter the number of ingredients:");
                int numIngredients = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number of steps:");
                int numSteps = Convert.ToInt32(Console.ReadLine());

                // Creating a new recipe object with the specified number of ingredients and steps
                Recipe recipe = new Recipe(numIngredients, numSteps);

                // Getting details for each ingredient from the user and adding them to the recipe
                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"Enter details for ingredient {i + 1}:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Quantity: ");
                    double quantity = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Unit: ");
                    string unit = Console.ReadLine();

                    recipe.AddIngredient(i, new Ingredient { Name = name, Quantity = quantity, Unit = unit });
                }

                // Getting details for each step from the user and adding them to the recipe
                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Enter step {i + 1}:");
                    string description = Console.ReadLine();

                    recipe.AddStep(i, new Step { Description = description });
                }

                // Displaying the recipe to the user
                recipe.DisplayRecipe();

                // Scaling the recipe based on user input
                Console.WriteLine("\nEnter scaling factor (0.5, 2, or 3):");
                double scalingFactor = Convert.ToDouble(Console.ReadLine());
                recipe.ScaleRecipe(scalingFactor);

                Console.WriteLine("\nRecipe after scaling:");
                recipe.DisplayRecipe();

                // Resetting quantities (implementation pending)
                // Clearing the recipe for entering a new one
                recipe.ClearRecipe();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
