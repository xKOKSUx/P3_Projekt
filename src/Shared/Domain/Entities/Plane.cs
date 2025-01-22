
namespace Domain.Entities
{
    public class Plane
    {
        
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Code { get; set; }
        public string DOA { get; set; }//Date of Arrival
        public string DOD { get; set; }//Date of Departure
        public string Heading { get; set; }

        public Plane(string ModelName, string ManufacturerName, string CodeName, string DODTime, string DOATime, string HeadingDirection)
        {
            Model = ModelName;
            Manufacturer = ManufacturerName;
            Code = CodeName;
            DOA = DOATime;
            DOD = DODTime;
            Heading = HeadingDirection;


        }

    }
}
