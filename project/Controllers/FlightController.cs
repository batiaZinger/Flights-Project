using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Common;

namespace project.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private IFlightService flightService;
        public FlightController(IFlightService flightService)
        {
            this.flightService = flightService;
        }
        [HttpGet("company/{CompanyId}")]
        public List<CFlight> GetFlightsByCompany(int CompanyId)
        {
            return flightService.GetFlightsByCompany(CompanyId);
        }
        [HttpGet("dest/{AirportId}")]
        public List<CFlight> GetFlightsByDest(int AirportId)
        {
            return flightService.GetFlightsByDest(AirportId);
        }
        [HttpGet("nextFlights/{AirportId}/{date}")]
        public List<CFlight> GetNextFlights(int AirportId, DateTime date)//לבקש מחר מהמורה עזרה בהרצת פונקציה שמקבלת 2 פרמטרים
        {
            return flightService.GetNextFlights(AirportId, date);
        }
        [HttpPost]
        public void AddFlight(CFlight cFlight)
        {
            flightService.AddFlight(cFlight);
        }
    }
}