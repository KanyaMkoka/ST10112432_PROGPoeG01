using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10112432_PROGPart1
{
    public class Ingredient //defining a class
    {
        //properties storing Name, Quantity and Unit of the ingredient measurement
        public string Name { get; set; } //name of the ingredient
        public string Quantity { get; set; } //ingredient Quantity
        public string Unit {  get; set; } //Measurement unit of the ingredient

        //initialising ingredient properties using a constructor
        public Ingredient(string name, double quantity, string unit) 
        { 
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
        //ToString method
        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }

    }
}
