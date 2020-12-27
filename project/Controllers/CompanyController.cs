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
    public class CompanyController: ControllerBase
    {
        private ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [HttpGet]
        public List<CCompany> GetAll()
        {
            return companyService.GetAll();
        }
    }
}
