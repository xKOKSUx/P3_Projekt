namespace Domain.Entities
{
    public class Plane
    {
        string Model { get; set; }
        string Manufacturer { get; set; }
        string Code { get; set; }
        string DOA { get; set; }//Date of Arrival
        string DOD { get; set; }//Date of Departure
        string Heading { get; set; }

        public Plane(string ModelName,string ManufacturerName,string CodeName,string DODTime,string DOATime,string HeadingDirection)
        {
            Model = ModelName;
            Manufacturer = ManufacturerName;
            Code = CodeName;
            DOA = DOATime;
            DOD = DODTime;
            Heading = HeadingDirection;


        }
        public void DisplayInfo()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Code: " + Code);
            Console.WriteLine("DOD: " + DOD);
            Console.WriteLine("DOA: " + DOA);   
            Console.WriteLine("Heading: " + Heading);
        }
    }
}
