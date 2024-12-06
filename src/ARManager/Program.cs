using ARManager.Services;
using Domain.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;


string path = Path.Combine("", @"..\..\..\..\..\Planes.json");
//string jsonR = File.ReadAllText(path);
//if (!File.Exists(path))
//{
//    Console.WriteLine($"Error: File '{path}' not found!");
//    return;
//}

//Dictionary<string, Plane> planes = JsonSerializer.Deserialize<Dictionary<string, Plane>>(jsonR);


Airport airport = new Airport("USA", "Los Angeles", "LAX");
List<Plane> plane= new List<Plane>();
Dictionary<string, Plane> planes = new Dictionary<string, Plane>();

void createplane()
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
    planes[planeName] = newPlane;
}

//void displayplanes()
//{
//    Console.WriteLine("Enter the plane ID: ");
//    string planeName = Console.ReadLine();
//    planeName = planeName.ToUpper();
//    if (planes.TryGetValue(planeName, out Plane plane))
//    {
//        PlaneService planeServices = new PlaneService();
//        planeServices.DisplayInfo(plane);
//    }
//    else
//    {
//        Console.WriteLine("Plane not found.");
//    }
//}

createplane();


string jsonW = JsonSerializer.Serialize(planes);
File.WriteAllText(path, jsonW);
//PlaneService.DisplayInfoPlane();
