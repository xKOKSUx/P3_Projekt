namespace Domain.Entities
{
    public class Plane
    {
        string Model { get; set; }
        string Manufacturer { get; set; }
        string Code { get; set; }
        string DOA { get; set; }
        string DOD { get; set; }
        string Heading { get; set; }

        public Plane()
        {
            Model = "";
            Manufacturer = "";
            Code = "";
            DOA = "";
            DOD = "";
            Heading = "";

        }
    }
}
