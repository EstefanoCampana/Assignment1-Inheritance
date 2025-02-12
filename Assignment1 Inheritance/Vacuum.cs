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
        private string grade = "";
        private int batteryVoltage;

        // public property
        public int BatteryVoltage { get { return batteryVoltage; } set { batteryVoltage = value; } }
        public string Grade { get { return grade; }set { grade = value; } }

        // constructor 
        public Vacuum(string itemNumber, string brand, int quantity, string wattage, string color, string price, string grade, int batteryVoltage):
                    base (itemNumber, brand, quantity, wattage, color, price)
        {
            this.Grade = grade;
            this.BatteryVoltage = batteryVoltage;
        }

        //public method
        public override string ToString()
        {
            string batteryVoltageText = "";
            if (BatteryVoltage == 18)
            {
                batteryVoltageText = "Low";
            }
            else
            {
                batteryVoltageText = "High";
            }
            return base.ToString() +
                $"Grade: {Grade}\n" +
                $"BatteryVoltage: {batteryVoltageText}\n";
        }
    }
}
