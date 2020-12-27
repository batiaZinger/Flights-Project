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
    public class AirportController : ControllerBase
    {
        IAirportService airportService;
        public AirportController(IAirportService airportService)
        {
            this.airportService = airportService;
        }
        [HttpDelete("{Id}")]
        public void DeleteAirPort(int Id)
        {
            airportService.DeleteAirPort(Id);
        }
    }
}
