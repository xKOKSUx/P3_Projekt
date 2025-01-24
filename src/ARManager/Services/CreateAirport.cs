using Domain.Entities;

namespace ARManager.Services
{
    public class CreateAirport
    {
        public void CreateAirpor(List<Airport> airports)
        {
            Console.Write("Enter country: ");
            string country = Console.ReadLine() ?? "Not Assigned";
            Console.Write("Enter city: ");
            string city = Console.ReadLine() ?? "Not Assigned";
            Console.Write("Enter code: ");
            string code = Console.ReadLine() ?? "Not Assigned";
            code = code.ToUpper();
            airports.Add(new Airport(country,city,code));
        }
    }
}
