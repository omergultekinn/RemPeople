using RemPeople.Data;
using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Business.Implementations
{
    /// <summary>
    /// Sabit aylık maaş hesaplamaları
    /// </summary>
    internal class FixedCalculator : ICalculatorService
    {
        /// <summary>
        /// Sabit aylık maaş
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public decimal Calculate(Employee employee)
        {
            return employee.EmployeeFixedSalary.FixedSalary;
        }
    }
}
