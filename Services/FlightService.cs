using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Repositories;
using Repositories.Models;
using System.Linq;


namespace Services
{
    public class FlightService : IFlightService
    {
        IFlightRepository flightrepository;
        public FlightService(IFlightRepository flightRepository)
        {
            this.flightrepository = flightRepository;
        }

        public void AddFlight(CFlight flight)
        {
            Flight f = new Flight() { From = flight.From, To = flight.To, Takeoff = flight.Takeoff, Landing = flight.Landing, Company = flight.Company };
            flightrepository.AddFlight(f);
        }

        public List<CFlight> GetFlightsByCompany(int company)
        {
            List<CFlight> flights = (from f in flightrepository.GetFlightsByCompany(company)
                                     select new CFlight { From = f.From, To = f.To, Takeoff = f.Takeoff, Landing = f.Landing, Company = f.Company }).ToList();
            return flights;
        }

        public List<CFlight> GetFlightsByDest(int airport)
        {
            List<CFlight> flights = (from f in flightrepository.GetFlightsByDest(airport)
                                     select new CFlight { From = f.From, To = f.To, Takeoff = f.Takeoff, Landing = f.Landing, Company = f.Company }).ToList();
            return flights;
        }

        public List<CFlight> GetNextFlights(int airport, DateTime date)
        {
            List<CFlight> flights = (from f in flightrepository.GetNextFlights(airport, date)
                                     select new CFlight { From = f.From, To = f.To, Takeoff = f.Takeoff, Landing = f.Landing, Company = f.Company }).ToList();
            return flights;
        }
    }
}
