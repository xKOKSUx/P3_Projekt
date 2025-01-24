using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
namespace ARManager.Services
{
    public class CreatePlane
    {
        public void CreatePlan()
        {
            List<Plane> planes = new List<Plane>();

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
    }
}
