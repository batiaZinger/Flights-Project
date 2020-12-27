using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IAirportService
    {
        //void IFlightService.DeleteAirPort(Airport airport)
        //{
        //    throw new NotImplementedException();
        //}

        //List<Company> IFlightService.GetAll()//מחזיר רשימת חברות שמקיימות טיסות
        //{
        //    throw new NotImplementedException();
        //}
        void DeleteAirPort(int airport);//מחיקת שדה תעופה מסוים
    }
}
