﻿using Domain.Entities;

namespace ARManager.Services
{
    class AirportService
    {
        public void DisplayInfoAirport(Airport airport)
        {
            Console.WriteLine("Country: " + airport.country);
            Console.WriteLine("City: " + airport.city);
            Console.WriteLine("Code: " + airport.code);
        }
    }
}
