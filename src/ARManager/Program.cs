using ARManager.Services;
using Domain.Entities;
using System;
PlaneService planeService = new PlaneService();
ImportSaveData importSaveData = new ImportSaveData();
List<Airport> airport;
Airport newAirport = new Airport("USA", "Los Angeles", "LAX");


List<Plane> planes = new List<Plane>();

planes = ImportSaveData.ReadFromFile<List<Plane>>();


void CreatePlane()
{
    string planeName;
    do
    {
        Console.Write("Enter the plane ID: ");
        planeName = Console.ReadLine();
        if (planeName.Length < 4)
        {
            Console.WriteLine("Plane ID must be at least 4 characters long.");
        }
    }
    while (planeName.Length < 4);
    planeName = planeName.ToUpper();

    Console.Write("Enter Manufacturer: ");
    string manufacturer = Console.ReadLine() ?? "Not Assigned";

    Console.Write("Enter Model: ");
    string model = Console.ReadLine() ?? "Not Assigned";

    string code = planeName;
    Console.Write("Enter Date of Departure (DOD): ");
    string dod = Console.ReadLine() ?? "Not Assigned";

    Console.Write("Enter Date of Arrival (DOA): ");
    string doa = Console.ReadLine() ?? "Not Assigned";

    Console.Write("Enter Heading(Airport code): ");
    string heading = Console.ReadLine() ?? "Not Assigned";
    heading = heading.ToUpper();

    Plane newPlane = new Plane(model, manufacturer, code, doa, dod, heading);
    planes.Add(newPlane);
    
}
bool running = true;
while (running)
{
    Console.Clear();
    Console.WriteLine("=== Aviation Resource Manager ===");
    Console.WriteLine("1. Add Plane");
    Console.WriteLine("2. Remove Plane");
    Console.WriteLine("3. Display planes");
    Console.WriteLine("4. Add Airport");
    Console.WriteLine("5. Remove Airport");
    Console.WriteLine("6. Exit");
    Console.Write("\nSelect an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CreatePlane();
            
            break;
        //case "2":
        //    RemovePlane();
            
        //    break;
        case "3":
            if (planes.Count == 0)
            {
                Console.WriteLine("No planes to display.");
            }
            else
            {
                
                foreach (var plane in planes)
                {
                    planeService.DisplayInfoPlane(plane);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            break;
        //case "4":
        //    RemoveAirport();
        //    break;
        case "6":
            importSaveData.SaveToFile(planes);
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option. Press any key to continue...");
            Console.ReadKey();
            break;
    }
}
