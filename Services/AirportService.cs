using System;
using System.Collections.Generic;
using System.Text;
using Repositories;
using Repositories.Models;

namespace Services
{
    class AirportService : IAirportService
    {
        IAirportRepository airportRepository;
        public AirportService(IAirportRepository airportRepository)
        {
            this.airportRepository = airportRepository;
        }
        public void DeleteAirPort(int airport)
        {
            airportRepository.DeleteAirPort(airport);
        }
    }
}
