using ARManager.Services;
using Domain.Entities;

PlaneService planeService = new PlaneService();
ImportSaveData importSaveData = new ImportSaveData();
List<Plane> planes = new List<Plane>();
List<Airport> airports = new List<Airport>();
CreatePlane createPlane = new CreatePlane();
AirportService airportService = new AirportService();
CreateAirport createAirport = new CreateAirport();
Airport newAirport = new Airport("USA", "Los Angeles", "LAX");


planes.Add(new Plane("Boeing 747", "Boeing", "B747", "2021-10-10", "2021-10-11", "LAX"));

bool running = true;
while (running)
{
    Console.Clear();
    Console.WriteLine("=== Aviation Resource Manager ===");
    Console.WriteLine("1. Add Plane");
    Console.WriteLine("2. Remove Plane(WIP)");
    Console.WriteLine("3. Display planes");
    Console.WriteLine("4. Add Airport");
    Console.WriteLine("5. Display Airport");
    Console.WriteLine("6. Exit");
    Console.Write("\nSelect an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            createPlane.CreatePlan(planes);

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
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        case "5":

            if (airports.Count == 0)
            {
                Console.WriteLine("No airports to display.");
            }
            else
            {

                foreach (var airport in airports)
                {
                    airportService.DisplayInfoAirport(airport);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        case "4":
            createAirport.CreateAirpor(airports);
            break;
        case "6":
            importSaveData.SaveToFile(planes, @"..\..\..\..\..\Planes.json");
            importSaveData.SaveToFile(airports, @"..\..\..\..\..\Airports.json");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option. Press any key to continue...");

            break;
    }
}
