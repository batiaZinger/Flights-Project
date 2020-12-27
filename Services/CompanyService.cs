using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Repositories;

namespace Services
{
    class CompanyService : ICompanyService
    {
        ICompanyRepository companyrepository;
        public CompanyService(ICompanyRepository compantRepository)
        {
            this.companyrepository = compantRepository;
        }
        public List<CCompany> GetAll()
        {
            List<CCompany> company =(from c in companyrepository.GetAll() select new CCompany{ Company = c.Id }).ToList();
            return company;
        }
    }
}
