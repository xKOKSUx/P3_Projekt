using Domain.Entities;

namespace ARManager.Services
{
    public class PlaneService
    {
        public void DisplayInfoPlane(Plane plane)
        {
            Console.WriteLine("Model: " + plane.Model);
            Console.WriteLine("Manufacturer: " + plane.Manufacturer);
            Console.WriteLine("Code: " + plane.Code);
            Console.WriteLine("DOD: " + plane.DOD);
            Console.WriteLine("DOA: " + plane.DOA);
            Console.WriteLine("Heading: " + plane.Heading);
        }
        
    }

}
