using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Inheritance
{
    public class Dishwasher : Appliances
    {
        //Private
        private string soundRating;
        private string feature;

        //Public
        public string Feature { get { return feature; } set { feature = value; } }
        public string SoundRating { get { return soundRating; } set { soundRating = value; } }

        //Constructor 
        public Dishwasher(string itemNumber, string brand, int quantity, string wattage, string color, string price, string feature, string  soundRating) :
                    base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.SoundRating = soundRating;
            this.Feature = feature;
        }

        //Public Method
        public override string ToString()
        {
            string textSoundRating = "";
            if (this.SoundRating == "Qt")
            {
                textSoundRating = "Quietest";
            }
            else if (this.SoundRating == "Qr")
            {
                textsoundRating = "Quieter";
            }
            else if (this.SoundRating == "Qu")
            {
                textSoundRating = "Quiet";
            }
            else if (this.SoundRating == "M")
            {
                textSoundRating = "Moderate";
            }

            return base.ToString() +
                $"Feature: {Feature}\n" +
                $"Sound Rating: {textSoundRating}\n";
        }
    }
}