// See https://aka.ms/new-console-template for more information
using Assignment1_Inheritance;
Appliances.ReadFile();


while (true) 
{
    Console.WriteLine($"Welcome to Modern Appliances!");
    Console.WriteLine($"How may we assist you?");
    Console.WriteLine($"1 – Check out appliance");
    Console.WriteLine($"2 – Find appliances by brand");
    Console.WriteLine($"3 – Display appliances by type");
    Console.WriteLine($"4 – Produce random appliance list");
    Console.WriteLine($"5 – Save & exit");
    Console.WriteLine($"Enter option:");
    var userOption = Console.ReadLine();

    switch (userOption)
    {
        case "1":
            
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
