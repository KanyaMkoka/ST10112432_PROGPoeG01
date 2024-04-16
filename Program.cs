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
                //asking the User for the number of ingredients and steps
                Console.WriteLine("Please enter the number of ingredients: ");
                int numIngredients = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the number of steps: ");
                int numProcedure = Convert.ToInt32(Console.ReadLine());

                //creating a recipe object with the specified number of ingredients
                Recipe rec = new Recipe(numIngredients, numProcedure);

                //Getting details for each ingredient and adding them to the recipe 
                for(int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"Please enter the details for the ingredient {i + 1}:");
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Quantity: ");
                    double quantity = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Unit: ");
                    string unit = Console.ReadLine();

                    Recipe.addIngredient(i, new Ingredient { Name = name, Quantity = quantity, Unit = unit });

                }
                //Getting details for each step from the user and adding them to the recipe
                for(int i = 0; i < numProcedure; i++)
                {
                    Console.WriteLine($"Enter step {i + 1}:");
                    string description = Console.ReadLine();

                    Recipe.addProcedure(i, new Procedure { Description = description });
                }

                //display 
                Recipe.displayRecipe();

                //Scaling recipe
                Console.WriteLine("\nPlease enter the scaling factor (0.5, 2, or 3): ");
                double scaleFactor = Convert.ToDouble(Console.ReadLine());
                Recipe.scaleRecipe();

                Console.WriteLine("\nRecipe after scaling: ");
                Recipe.displayRecipe();


                //resetting quantities
                Recipe.resetQuantities();

                //code to clear recipe
                Recipe.ClearRecipe();
            }
            catch (FormatException f)
            {
                Console.WriteLine($"Error: {f.Message}. Please enter a valid number.");
            }
            catch (Exception f)
            {
                Console.WriteLine($"Error: {f.Message}");
            }
        }
    }
}
