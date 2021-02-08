using RemPeople.Business;
using RemPeople.Business.Implementations;
using RemPeople.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Test
{
    public class EmployeeSalaryFixture : IDisposable
    {
        public ISalaryCalculator SalaryCalculator { get; set; }
        public ICalculateServiceCreater CalculateServiceCreater { get; set; }
        public ISalaryRepo SalaryRepo { get; set; }
        public EmployeeSalaryFixture()
        {
            CalculateServiceCreater = new CalculateServiceCreater();
            SalaryRepo = new SalaryRepo();
            SalaryCalculator = new SalaryCalculator(CalculateServiceCreater, SalaryRepo);
        }
        public void Dispose()
        {

        }
    }
}
