﻿using ARManager.Services;
using Domain.Entities;
ImportSaveData importSaveData = new ImportSaveData();
List<Airport> airport;
Airport newAirport = new Airport("USA", "Los Angeles", "LAX");


List<Plane> planes;

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

CreatePlane();
PlaneService planeService = new PlaneService();
planeService.DisplayInfoPlane(planes.Last());

try
{
    importSaveData.SaveToFile(planes);
    Console.WriteLine("Data saved successfully!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error saving plane data: {ex.Message}");
}
