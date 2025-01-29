using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Assignment1_Inheritance.Appliances;

namespace Assignment1_Inheritance
{
    public class Appliances
    {
        //Constants
        private const string PATH = @"../../../res/appliances.txt";
        private const char sep = ';';

        //Private properties
        private string itemNumber;
        private string brand;
        private int quantity;
        private string wattage;
        private string color;
        private string price;

        //Public properties
        public string ItemNumber {get {return itemNumber; } set { itemNumber = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Wattage { get { return wattage; } set { wattage = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Price { get { return price; } set { price = value; } }

        //Constructor
        public Appliances() { }
        public Appliances(string iN, string b, int q, string w, string c, string p)
        {
            ItemNumber = iN;
            Brand = b;
            Quantity = q;
            Wattage = w;
            Color = c;
            Price = p;
        }
        //Public methods
        public override string ToString()
        {
            return $"Item number: {ItemNumber}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}\n" +
                $"Color: {Color}\n" +
                $"Price: {Price}\n";
        }
        public static List<Appliances> ReadFile()
        {
            StreamReader streamreader = new StreamReader(PATH);
            List<Appliances> applianceList = new List<Appliances>();

            string line;
            string[] fields;
            string applianceId;
            string id;
            while (!streamreader.EndOfStream)
            {
                line = streamreader.ReadLine();
                fields = line.Split(sep);
                applianceId = fields[0];
                id = Convert.ToString(applianceId[0]);
                Appliances appliance = null;
                if (id == "1")
                {
                    appliance = new Refrigerator(applianceId, fields[1], Convert.ToInt32(fields[2]), fields[3], fields[4], fields[5], Convert.ToInt32(fields[6]), fields[7], fields[8]);
                }
                if (id == "2")
                {
                    appliance = new Vacuum(applianceId, fields[1], Convert.ToInt32(fields[2]), fields[3], fields[4], fields[5], fields[6], Convert.ToInt32(fields[7]));
                }
                if (id == "3")
                {
                    appliance = new Microwave(applianceId, fields[1], Convert.ToInt32(fields[2]), fields[3], fields[4], fields[5], fields[6], fields[7]);
                }
                if (id == "4" || id == "5")
                {
                    appliance = new Dishwasher(applianceId, fields[1], Convert.ToInt32(fields[2]), fields[3], fields[4], fields[5], fields[6], fields[7], fields[8]);
                }
                applianceList.Add(appliance);
            }
            return applianceList;
        }
        public string PurchaseAppliance()
        {
            Console.WriteLine("Enter the item number of the appliance:");
            int applianceNumber = Convert.ToInt32(Console.ReadLine());
            string availability = "";
            foreach(Appliances app in Appliances.ReadFile())
            {
                if(applianceNumber == app.ApplianceNumber)
                {
                    if(app.Quantity != 0)
                    {
                        availability = $"Appliance {applianceNumber} has been checked out.");
                        app.Quantity -= 1;
                    }
                    else
                    {
                        availability = "The appliance is not available to be checked out.");
                    }
                }
                else
                {
                    availability = "No appliances found with that item number.");
                }
            }
            return availability;
        }
        public string DisplayByType() 
        {
            Console.WriteLine("Appliance Types\n1 - Refrigerators\n2 - Vacuum\n3 - Microwave\n4 - Dishwasher");
            Console.WriteLine("Enter type of appliance:");
            int applianceType = Convert.ToInt32(Console.ReadLine());
            string appliance = "";
            if (applianceType == 1)
            {
                while (true)
                {
                    Console.WriteLine("Enter number of doors: 2, 3 or 4.");
                    int numberDoors = Convert.ToInt32(Console.ReadLine());
                    if (numberDoors > 1 && numberDoors < 5)
                    {
                        Console.WriteLine("Matching Refrigerators:");
                        foreach (Appliances app in Appliances.ReadFile())
                        {
                            Refrigerator refrigerator = (Refrigerator)app;
                            if (refrigerator.NumberOfDoors == numberDoors)
                            {
                                appliance += app;

                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid number of doors.(2,3 or 4)");
                        continue;
                    }
                }
            }
            if (applianceType == 2)
            {
                while (true)
                {
                    Console.WriteLine("Enter battery voltage value: 18 V (low) or 24 V (high).");
                    int batteryVoltage = Convert.ToInt32(Console.ReadLine());
                    if (batteryVoltage == 18 || batteryVoltage == 24)
                    {
                        Console.WriteLine("Matching Vacuums:");
                        foreach (Appliances app in Appliances.ReadFile())
                        {
                            Vacuum vacuum = (Vacuum)app;
                            if (vacuum.BatteryVoltage == batteryVoltage)
                            {
                                appliance += app;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid number of voltage. (18 or 24)");
                        continue;
                    }
                }
            } 
            if (applianceType == 3)
            {
                while (true)
                {
                    Console.WriteLine("Room where the microwave will be instaled: K (kitchen) or W (work site).");
                    string roomType = Console.ReadLine().ToUpper();
                    if (roomType == "K" || roomType == "M")
                    {
                        Console.WriteLine("Matching Microwaves:");
                        foreach (Appliances app in Appliances.ReadFile())
                        {
                            Microwave microwave = (Microwave)app;
                            if (microwave.RoomType == roomType)
                            {
                                appliance += app ;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid room type.(K or M)");
                        continue;
                    }
                }
            }
            if(applianceType == 4 || applianceType == 5)
            {
                while (true)
                {
                    Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu (Quit) or M (Moderate).");
                    string soundRating = Console.ReadLine();
                    if (soundRating == "Qt" || soundRating == "Qr" || soundRating == "Qu" || soundRating == "M")
                    {
                        Console.WriteLine("Matching Dishwashers:");
                        foreach (Appliances app in Appliances.ReadFile())
                        {
                            Dishwasher dishwasher = (Dishwasher)app;
                            if (dishwasher.SoundRating == soundRating)
                            {
                                appliance += app;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid sound rating. (Qt, Qr, Qu or M");
                        continue;
                    }
                }
            }
            return appliance;
        }
    }
}

