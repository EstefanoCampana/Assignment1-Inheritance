using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Inheritance
{
    public class Vacuum : Appliances
    {
        // private data
        private string itemNumber;
        private string brand;
        private int quantity;
        private string wattage;
        private string color;
        private string price;
        private string grade;
        private int batteryVoltage;

        // constructor 
        public Vacuum(string itemNumber, string brand, int quantity, string wattage, string color, string price, string grade, int batteryVoltage)
        {
            this.itemNumber = itemNumber;
            this.brand = brand;
            this.quantity = quantity;
            this.wattage = wattage;
            this.color = color;
            this.price = price;
            this.grade = grade;
            this.batteryVoltage = batteryVoltage;
        }

        //public method
        public override string ToString()
        {
            return $"Grade: {grade} Doors\n" +
                $"BatteryVoltage: {batteryVoltage}";
        }
    }
}
