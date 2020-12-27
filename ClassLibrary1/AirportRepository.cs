using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    class AirportRepository : IAirportRepository
    {
        private Flights context;
        public AirportRepository(Flights AirportContext)
        {
            context = AirportContext;
        }
        public void DeleteAirPort(int airport)
        {
            var i=context.Airport.First(a => a.Id == airport);
            context.Remove(i);
            context.SaveChanges();
        }
    }
}
