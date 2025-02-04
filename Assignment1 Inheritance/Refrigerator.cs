using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Inheritance
{
    public class Refrigerator : Appliances
    {
        // private data
        private int numOfDoors;
        private string height;
        private string width;

        // public properties
        public int NumberOfDoors { get { return numOfDoors; } set { numOfDoors = value; } }
        public string Height { get { return height; } set { height = value; } }
        public string Width { get { return width; } set { width = value; } }
        
        // constructor 
        public Refrigerator() { }
        public Refrigerator(string itemNumber, string brand, int quantity, string wattage, string color, string price, int numOfDoors, string height, string width):
            base (itemNumber,brand,quantity,wattage,color,price)
        {
            this.NumberOfDoors = numOfDoors;
            this.Height = height;
            this.Width = width;
        }

        // public method
        public override string ToString()
        {
            // if statemnt to convert numOfDoors into text
            string textNumOfDoors = "";
            if (this.NumberOfDoors == 2)
            {
                textNumOfDoors = "Two";
            }
            else if (this.NumberOfDoors == 3)
            {
                textNumOfDoors = "Three";
            }
            else if (this.NumberOfDoors == 4)
            {
                textNumOfDoors = "Four";
            }

            // return text
            return base.ToString() +
                $"Number of Doors: {textNumOfDoors} Doors\n" +
                $"Height: {Height}\n" +
                $"Width: {Width}\n";
        }
    }
}
