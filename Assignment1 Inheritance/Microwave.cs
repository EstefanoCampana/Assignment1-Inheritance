using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Inheritance
{
    public class Microwave : Appliances
    {
        //Private
        private string roomType;
        private float capacity;

        //Public
        public float Capacity { get { return capacity; } set { capacity = value; } }
        public string RoomType { get { return roomType; } set { roomType = value; } }

        //Constructor 
        public Microwave(string itemNumber, string brand, int quantity, string wattage, string color, string price, string roomType, float capacity) :
                    base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.RoomType = roomType;
            this.Capacity = capacity;
        }

        //Public Method
        public override string ToString()
        {
            string textRoomType = "";
            if (this.RoomType == "K")
            {
                textRoomType = "Kitchen";
            }
            else if (this.RoomType == "W")
            {
                textRoomType = "Work Site";
            }

            return base.ToString() +
                $"Capacity: {Capacity}\n" +
                $"Room Type: {textRoomType}\n";
        }
    }
}