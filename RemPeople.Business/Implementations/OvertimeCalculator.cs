using RemPeople.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemPeople.Business.Implementations
{
    ///<inheritdoc cref="IOvertimeCalculator"/>
    internal class OvertimeCalculator : IOvertimeCalculator
    {
        /// <summary>
        /// fazla mesai saati * fazla mesai saat ücreti hesaplar
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public decimal GetOvertimeWage(EmployeeOvertime employeeOvertime)
        {
            if (employeeOvertime == null || employeeOvertime.EmployeeOvertimeWorkings == null)
                return 0;
            return employeeOvertime.PerHour * employeeOvertime.EmployeeOvertimeWorkings.Sum(s => s.WorkingHours);
        }
    }
}
