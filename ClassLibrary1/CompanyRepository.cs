using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories.Models;

namespace Repositories
{
    class CompanyRepository : ICompanyRepository
    {
        private Flights context;
        public CompanyRepository(Flights flightContext)
        {
            context = flightContext;
        }
        public List<Company> GetAll()//מחזיר רשימת חברוץ תעופה שיש להן טיסות
        {
            return context.Company.Where(c => c.Flight .Count>0).ToList();
           
        }
    }
}
