namespace Domain.Entities
{
    public class Airport
    {
        public string country { get; set; }
        public string city { get; set; }
        public string code { get; set; }

        public Airport(string countryName, string cityName, string codeName)
        {
            country = countryName;
            city = cityName;
            code = codeName;
        }

    }
}
