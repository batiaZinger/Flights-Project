using System;
using System.Collections.Generic;
using System.Text;
using Repositories.Models;

namespace Repositories
{
    public interface IFlightRepository
    {
        List<Flight> GetList();
        void AddFlight(Flight flight);
        List<Flight> GetFlightsByCompany(int company);//מחזיר רשימת טיסות של חברה מסוימת על פי פרמטר
        List<Flight> GetFlightsByDest(int airport);//מחזיר רשימת טיסות ליעד מסוים
        List<Flight> GetNextFlights(int airport, DateTime date);//מחזיר רשימת טיסות קרובות של שדה תעופה מסוים מתאריך ושעה נתונים
       
    }
}
