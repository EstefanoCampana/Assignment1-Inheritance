// See https://aka.ms/new-console-template for more information
using Assignment1_Inheritance;

//Calls ReadFile method to fill the list with objects.
Appliances.ReadFile();

var userOption = "";
while (userOption != "5") 
{
    Console.WriteLine($"Welcome to Modern Appliances!\n"+
        $"How may we assist you?\n"+
        $"1 – Check out appliance\n"+
        $"2 – Find appliances by brand\n"+
        $"3 – Display appliances by type\n"+
        $"4 – Produce random appliance list\n"+
        $"5 – Save & exit\n"+
        $"Enter option:");
    userOption = Console.ReadLine();

    switch (userOption)
    {
        case "1":
            Console.WriteLine(Appliances.PurchaseAppliance());
            break;
        case "2":
            Console.WriteLine(Appliances.DisplayByBrand());
            break;
        case "3":
            Console.WriteLine(Appliances.DisplayByType());
            break;
        case "4":
            Console.WriteLine(Appliances.DisplayRandomAppliances());
            break; 
        case "5":
            Appliances.WriteToFile();
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}
