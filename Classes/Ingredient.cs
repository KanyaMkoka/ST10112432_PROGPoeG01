﻿using System;
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
            //Assigning the provided name to the Name property of the ingredient.
            Name = name;

            Quantity = quantity;
            Unit = unit;
        }
    }
}
