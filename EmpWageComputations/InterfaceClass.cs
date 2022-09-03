using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    interface InterfaceClass
    {
        public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        public int ComputeMonthlyWage(CompanyEmpWage company);
        public void DisplayCompanyWages();
    }
}
