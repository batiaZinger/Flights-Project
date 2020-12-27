using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;



namespace Services
{
    public interface IFlightService
    {       
        List<CFlight> GetFlightsByCompany(int company);//מחזיר רשימת טיסות של חברה מסוימת על פי פרמטר
        List<CFlight> GetFlightsByDest(int airport);//מחזיר רשימת טיסות ליעד מסוים
        List<CFlight> GetNextFlights(int airport, DateTime date);//מחזיר רשימת טיסות קרובות של שדה תעופה מסוים מתאריך ושעה נתונים
        void AddFlight(CFlight flight);//הוספת טיסה
        

    }
}
