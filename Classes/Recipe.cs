﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10112432_PROGPart1.Classes
{
    //This Recipe class was created to store
    public class Recipe
    {
        public Ingredient[] Ingredients { get; set; }
        public string[] Procedure { get; set; }

        public Recipe(int numIngredients, int numProcedure)
        { 
            Ingredients = new Ingredient[numIngredients];
            Procedure = new string[numProcedure];
        }

        public void placeIngredient(int index, string name, double quantity, string unit)
        {
            Ingredients[index] = new Ingredient(name, quantity, unit);
        }

        public void steps (int index, string describeStep)
        {
            Step[index] = describeStep;
        }

        public void recipeScale(double factor)
        {

        }
    }
}