﻿using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetAll();//מחזיר רשימת חברות שמקיימות טיסות
    }
}
