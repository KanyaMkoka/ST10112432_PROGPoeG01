/* Name: Kanya Mkoka
 * Student Number: ST10112432
 * Group: 01
 * I acknowledge bits of this code is not my own work and has been extracted from https://chat.openai.com/c/38ab336e-fa71-4664-9ee5-b5cc60bf834f 
 * and https://stackoverflow.blog/2022/06/15/c-ienumerable-yield-return-and-lazy-evaluation/
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10112432_PROGPart1.Classes
{
    public class Ingredient //defining a class
    {
        internal static int Length;

        //This class represents an ingredient with properties for name, quantity, and unit of measurement.
        //The properties below stores Name, Quantity and Unit of the ingredient measurements
        //The name of the ingredient
        public string Name { get; set; }
        //Unit of measurement for the ingredient quantity
        public double Quantity { get; set; }
        // Quantity of the ingredient
        public string Unit { get; set; }

        public Ingredient(string name, double quantity, string unit)
        {
            //Assigning the provided name to the Name property of the ingredients.
            Name = name;
            //Assigning the provided quantity to the Quantity property of the ingredients.
            Quantity = quantity;
            //Assigning the provided unit of measurement to the Unit property of the ingredient.
            Unit = unit;
        }
    }
}
