using Domain.Entities;

Airport airport = new Airport("USA","Los Angeles","LAX");
//Plane N607U = new Plane("Boeing 747", "Boeing", "N607U", "12:00", "14:00", "N");


//Plane U067= new Plane("Boeing 747", "Boeing", "U067", "12:00", "14:00", "N");
//Console.WriteLine(airport.country);
//Console.WriteLine(airport.city);
//Console.WriteLine(airport.code);
//U067.DisplayInfo();
Dictionary<string, Plane> planes = new Dictionary<string, Plane>();

Console.Write("Enter the plane ID: ");
string planeName = Console.ReadLine();
planeName = planeName.ToUpper();

Console.Write("Enter Manufacturer: ");


string manufacturer = Console.ReadLine() ?? "Not Assigned";


Console.Write("Enter Model: ");
string model = Console.ReadLine() ?? "Not Assigned";



string code = planeName;

Console.Write("Enter Date of Arrival (DOA): ");
string doa = Console.ReadLine() ?? "Not Assigned";

Console.Write("Enter Date of Departure (DOD): ");
string dod = Console.ReadLine() ?? "Not Assigned";

Console.Write("Enter Heading: ");
string heading = Console.ReadLine() ?? "Not Assigned";


Plane newPlane = new Plane(model, manufacturer, code, doa, dod, heading);


planes[planeName] = newPlane;


if (planes.TryGetValue(planeName, out Plane plane))
{
    plane.DisplayInfo();
}
else
{
    Console.WriteLine("Plane not found.");
}
    