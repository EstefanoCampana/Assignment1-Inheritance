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
        private string grade;
        private int batteryVoltage;

        // public property
        public int BatteryVoltage { get { return batteryVoltage; } set { batteryVoltage = value; } }

        // constructor 
        public Vacuum(string itemNumber, string brand, int quantity, string wattage, string color, string price, string grade, int batteryVoltage):
                    base (itemNumber, brand, quantity, wattage, color, price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
            this.grade = grade;
            this.batteryVoltage = batteryVoltage;
        }

        //public method
        public override string ToString()
        {
            return base.ToString() +
                $"Grade: {grade} Doors\n" +
                $"BatteryVoltage: {batteryVoltage}";
        }
    }
}
