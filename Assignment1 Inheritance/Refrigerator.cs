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
        private string itemNumber;
        private string brand;
        private int quantity;
        private string wattage;
        private string color;
        private double price;
        private int numOfDoors;
        private string height;
        private string width;

        // constructor 
        public Refrigerator(string itemNumber, string brand, int quantity, string wattage, string color, double price, int numOfDoors, string height, string width)
        {
            this.itemNumber = itemNumber;
            this.brand = brand;
            this.quantity = quantity;
            this.wattage = wattage;
            this.color = color;
            this.price = price;
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
            return $"Number of Doors: {textNumOfDoors} Doors\n" +
                $"Height: {height}\n" +
                $"Width: {width}";
        }
    }
}
