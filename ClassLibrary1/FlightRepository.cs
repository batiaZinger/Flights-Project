using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories.Models;

namespace Repositories
{
    class FlightRepository : IFlightRepository
    {
        private Flights context;
        public FlightRepository(Flights FlightContext)
        {
            context = FlightContext;
        }
        public List<Flight> GetFlightsByCompany(int company)
        {
            return context.Flight.Where(f => f.Company == company).ToList();
        }

        public List<Flight> GetFlightsByDest(int airport)
        {
            return context.Flight.Where(a => a.To == airport).ToList();
        }

        public List<Flight> GetList()
        {
            return context.Flight.ToList();
        }

        public List<Flight> GetNextFlights(int airport, DateTime date)
        {
            return context.Flight.Where(a => a.From == airport && a.Takeoff >= date).ToList();
        }

        public void AddFlight(Flight flight)
        {
            flight.Id = (context.Flight.Max(a => a.Id)+1);                
            context.Flight.Add(flight);
            context.SaveChanges();
        }
    }
}
