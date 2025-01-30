using System;
using System.Collections.Generic;
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
        public int NumberOfDoors { get { return numOfDoors; } } set { numOfDoors = value; } }
        
        // constructor 
        public Refrigerator() { }
        public Refrigerator(string itemNumber, string brand, int quantity, string wattage, string color, double price, int numOfDoors, string height, string width):
            base (itemNumber,brand,quantity,wattage,color,price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
            this.numOfDoors = numOfDoors;
            this.height = height;
            this.width = width;
        }

        // public method
        public override string ToString()
        {
            // if statemnt to convert numOfDoors into text
            string textNumOfDoors = "";
            if (this.numOfDoors == 2)
            {
                textNumOfDoors = "Two";
            }
            else if (this.numOfDoors == 3)
            {
                textNumOfDoors = "Three";
            }
            else if (this.numOfDoors == 4)
            {
                textNumOfDoors = "Four";
            }

            // return text
            return base.ToString() +
                $"Number of Doors: {textNumOfDoors} Doors\n" +
                $"Height: {height}\n" +
                $"Width: {width}";
        }
    }
}
