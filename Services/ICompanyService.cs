using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ICompanyService
    {
        List<CCompany> GetAll();//מחזיר רשימת חברות שמקיימות טיסות
    }
}
