using RemPeople.Data;
using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Business.Implementations
{
    /// <summary>
    /// Günlük çalışan hesaplamaları
    /// </summary>
    internal class DailyCalculator : ICalculatorService
    {
        /// <summary>
        /// günlük ücret * çalışılan gün sayısı
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public decimal Calculate(Employee employee)
        {
            if (employee.EmployeeDayWage == null || employee.EmployeeDayWage.EmployeeWorkingDays == null)
                return 0;
            return employee.EmployeeDayWage.WagePerDay * employee.EmployeeDayWage.EmployeeWorkingDays.Count();
        }

    }
}
